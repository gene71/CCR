using CCR.Util;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCR.Data
{
    public class CCRDataAccess
    {
        public CCRDataAccess()
        {
            
        }

        /// <summary>
        /// testConnection creates a test db to test sqlite driver
        /// operation.
        /// </summary>
        public void testConnection()
        {
            try
            {
                using (var connection = new SQLiteConnection(AppRes.testDb))
                {
                    connection.Open();
                    connection.Close();
                }

                string msg = "Info 7001: tstDB created";
                Logger.log(msg);
            }
            catch (Exception ex)
            {
                string msg = "Error 5001: issue testing connection..." + ex.Message;
                Logger.log(msg);
            }
            
        }

    }
}
