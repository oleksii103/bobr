using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WinFormsApp2
{
    public static class dataBaseConection
    {
        static string conectionString = ConfigurationManager.ConnectionStrings["BalalaConection"].ConnectionString;
    }
}
