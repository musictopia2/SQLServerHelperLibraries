using System.Data.Common;

namespace SQLServerHelperLibraries;
public class CustomSQLServerConnectionClass : ISQLServerConnector
{
    EnumDatabaseCategory IDbConnector.GetCategory(IDbConnection connection)
    {
        if (connection is SqlConnection == false)
        {
            throw new CustomBasicException("Should have been a sql server connection.  Rethink");
        }
        return EnumDatabaseCategory.SQLServer; //will always be sql server with this class.
    }
    IDbCommand IDbConnector.GetCommand()
    {
        return new SqlCommand();
    }
    IDbConnection IDbConnector.GetConnection(EnumDatabaseCategory category, string connectionString)
    {
        if (category != EnumDatabaseCategory.SQLServer)
        {
            throw new CustomBasicException("Only sql server is supported for this category.  Rethink");
        }
        return new SqlConnection(connectionString);
    }
    DbParameter IDbConnector.GetParameter()
    {
        return new SqlParameter();
    }
}