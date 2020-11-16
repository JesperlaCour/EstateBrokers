using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class ControllerSingleton
    {
        private static ControllerSingleton _instance;
        CRUDLogic crud;

        protected ControllerSingleton()
        {
            crud = new CRUDLogic();
        }
        public static ControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new ControllerSingleton();
            }
            return _instance;
        }
    }
}
