# GenericRecords

Generic records system that allows you to create and amend records of different types, e.g. Dogs and Aeroplanes.

Business layer is the main area where we can create categories of records and the records themselves. We also store the changes in an audit log.

The Data layer contains a mock 'in memory' database as well as an instance of the LiteDB NOSQL database.

The Service layer allows external access via an ASP.NET Web API instance. It returns data in Json format.
