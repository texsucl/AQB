﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.QueryTransformer;
using ActiveQueryBuilder.Web.Core;
using ActiveQueryBuilder.Web.Server;
using ActiveQueryBuilder.Web.Server.Services;
using ASP.NET_Core.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MVC_Samples.Controllers
{
    public class SimpleOdbcDemoController : Controller
    {
        private const string filename = "UserQueriesStructure.xml";
        private string instanceId = "SimpleOledbDemo";

        private readonly IHostingEnvironment _env;
        private readonly IQueryBuilderService _aqbs;

        // Use IQueryBuilderService to get access to the server-side instances of Active Query Builder objects. 
        // See the registration of this service in the Startup.cs.
        public SimpleOdbcDemoController(IQueryBuilderService aqbs, IHostingEnvironment env)
        {
            _aqbs = aqbs;
            _env = env;
        }

        public ActionResult Index()
        {
            // Get an instance of the QueryBuilder object
            var qb = _aqbs.Get(instanceId);

            if (qb == null)
                qb = CreateQueryBuilder();

            return View(qb);
        }

        public ActionResult GetData()
        {
            var qb = _aqbs.Get(instanceId);
            var conn = qb.MetadataProvider.Connection;

            var sqlQuery = new SQLQuery(qb.SQLContext)
            {
                SQL = qb.ActiveUnionSubQuery.SQL
            };

            QueryTransformer qt = new QueryTransformer
            {
                QueryProvider = sqlQuery
            };

            qt.Take("7");

            var columns = qt.Columns.Select(c => c.ResultName).ToList();

            try
            {
                var data = DataBaseHelper.GetDataList(conn, qt.SQL);
                var result = new { columns, data };
                return Json(result);
            }
            catch (Exception e)
            {
                var result = new { columns, data = new List<List<object>> { new List<object> { e.Message } } };
                return Json(result);
            }
        }

        /// <summary>
        /// Creates and initializes a new instance of the QueryBuilder object.
        /// </summary>
        /// <returns>Returns instance of the QueryBuilder object.</returns>
        private QueryBuilder CreateQueryBuilder()
        {
            // Define connection string here
            //var connectionString = @"Driver={SQL Server};Server=(local);Uid=User;Pwd=Passw0rd;Database=Northwind;";
            var connectionString = "";

            if (string.IsNullOrEmpty(connectionString))
                throw new ApplicationException("Connection string is not set");

            // Create an instance of the QueryBuilder object
            var queryBuilder = _aqbs.Create(instanceId);
            queryBuilder.SyntaxProvider = new AutoSyntaxProvider();

            // Turn this property on to suppress parsing error messages when user types non-SELECT statements in the text editor.
            queryBuilder.BehaviorOptions.AllowSleepMode = false;

            #region ODBC
            // Bind Active Query Builder to a live database connection.
            //queryBuilder.MetadataProvider = new ODBCMetadataProvider
            //{
            //    // Assign an instance of DBConnection object to the Connection property.
            //    Connection = DataBaseHelper.CreateOdbcConnection(connectionString)
            //};
            #endregion

            #region OleDb
            // Bind Active Query Builder to a live database connection.
            queryBuilder.MetadataProvider = new OLEDBMetadataProvider
            {
                // Assign an instance of DBConnection object to the Connection property.
                Connection = DataBaseHelper.CreateMSAccessConnection("NorthwindDataBase")
            };
            #endregion



            //Comment these 2 lines for using browser localStorage
            ImportUserQueriesFromFile(queryBuilder.UserQueries);
            queryBuilder.UserQueries.Changed += ExportUserQueriesToFile;

            // Assign the initial SQL query text the user sees on the _first_ page load
            //queryBuilder.SQL = GetDefaultSql();

            return queryBuilder;
        }

        private void ExportUserQueriesToFile(object sender, MetadataStructureItem item)
        {
            var uq = (UserQueriesContainer)sender;
            uq.ExportToXML(_env.WebRootPath + @"/../" + filename);
        }

        private void ImportUserQueriesFromFile(UserQueriesContainer uqc)
        {
            var file = _env.WebRootPath + @"/../" + filename;

            if (System.IO.File.Exists(file))
                uqc.ImportFromXML(file);
        }

        public void GetUserQueriesXml()
        {
            var qb = _aqbs.Get(instanceId);
            qb.UserQueries.ExportToXML(Response.Body);
        }

        public void LoadUserQueries(string xml)
        {
            var qb = _aqbs.Get(instanceId);
            qb.UserQueries.XML = xml;
        }

        //private string GetDefaultSql()
        //{
        //    return @"select CustomerID,City from Customers ";
        //}
        private string GetDefaultSql()
        {
            return @"Select o.OrderID,
                      c.CustomerID As a1,
                      c.CompanyName,
                      s.ShipperID
                    From (Orders o
                      Inner Join Customers c On o.CustomerID = c.CustomerID)
                      Inner Join Shippers s On s.ShipperID = o.ShipperID
                    Where o.Ship_City = 'A'";
        }
    }
}
