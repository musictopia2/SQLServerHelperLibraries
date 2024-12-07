namespace SQLServerHelperLibraries;
public class SQLServerConnectionManager : IDatabaseConnectionManager
{
    EnumDatabaseCategory IDatabaseConnectionManager.PrepareDatabase()
    {
        GlobalClass.SQLServerConnector ??= new CustomSQLServerConnectionClass();
        return EnumDatabaseCategory.SQLServer;
    }
}