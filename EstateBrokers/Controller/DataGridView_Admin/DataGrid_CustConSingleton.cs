using Persistence;
using Model.Models;

public class DataGrid_CustConSingleton
{
    private static DataGrid_CustConSingleton _instance;



    protected DataGrid_CustConSingleton()
    {

    }
    public static DataGrid_CustConSingleton Instance()
    {
        if (_instance == null)
        {
            _instance = new DataGrid_CustConSingleton();
        }
        return _instance;
    }

    IDatabase db;
    public EstateBrokersContext GetGridCustomerData()
    {
        db = new DatabaseProxy();
        return db.GetGridCustomerData();
    }

    public void UpdateGridCustomerData()
    {
        db.UpdateGridCustomerData();
    }
}


