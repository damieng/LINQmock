LINQmock
========

Mock your remote LINQ queries against LINQ to Objects.

Today if you use any provider-specific extensions (e.g. SqlMethods.Like) against LINQ to Objects you'll get exception messages. This makes mocking any kind of queries a real pain.

This project aims to solve that by giving you a way to remap those provider-specific extensions to LINQ to Objects equivalents. The plan is to include a bunch of these pre-made for various LINQ providers, e.g. LINQ to SQL, ElasticLINQ.

This is very early days right now. The basic syntax is:

1. Make your IEnumerable IQueryable
2. Put .Remap(LinqToSqlMap.Instance) on the end of your query

This is currently a portable class library (PCL) under active development with tests to come.
