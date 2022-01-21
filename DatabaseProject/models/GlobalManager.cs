using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    internal static class GlobalManager
    {

        public static bool InitializeApp()
        {
            try
            {
                Logger.Initialize();
                DBController.Initialize();
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex.ToString());
                return false;
            } 
        }
    }
}
