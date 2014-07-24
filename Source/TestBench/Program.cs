using LinqMock;
using LinqMock.Maps;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using LinqMock.Operations;

namespace TestBench
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateOperations.DateDiffHour(new DateTime(2011,01,03,10,59,59), new DateTime(2011,01,03,11,00,00)));

            var source = new List<Robot> {
                new Robot { Name = "Kryten" },
                new Robot { Name = "Abobo" }
            }.AsQueryable();

            var query = source.Where(r => SqlMethods.Like(r.Name, "%bob%"));

            foreach (var robot in query.Remap(LinqToSqlMap.Instance))
                Console.WriteLine(robot.Name);
        }
    }

    class Robot
    {
        public string Name { get; set; }
    }
}