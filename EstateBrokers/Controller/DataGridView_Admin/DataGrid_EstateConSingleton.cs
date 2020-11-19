
using Model.Models;
using Persistence;


    public class DataGrid_EstateConSingleton
    {
        private static DataGrid_EstateConSingleton _instance;

        protected DataGrid_EstateConSingleton()
        {

        }
        public static DataGrid_EstateConSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new DataGrid_EstateConSingleton();
            }
            return _instance;
        }


        IDatabase db;
        public EstateBrokersContext GetGridEstateData()
        {
            db = new DatabaseProxy();
            return db.GetGridEstateData();
        }

        public void UpdateGridEstateData()
        {
            db.UpdateGridEstateData();
        }

    }

