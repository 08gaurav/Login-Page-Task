using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    internal class BLLog
    {
        DL.DLLog objdal = new DL.DLLog();
        BE.BELog objbeLogin = new BE.BELog();
        public DataTable UserLogin(BE.BELog objbeLogin)
        {
            try
            {
                return objdal.LoginCredential(objbeLogin);
            }
            catch
            {
                throw;
            }
        }
    }
}
