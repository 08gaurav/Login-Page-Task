using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    internal class SqlDBHelper
    {
        public string ConnectionString()
        {
            return ConfigurationManager.AppSettings["con"].ToString();
        }
    }
}
