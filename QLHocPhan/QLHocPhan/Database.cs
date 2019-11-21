using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHocPhan
{
    static class Database
    {
        public static string DbContext()
        {
            string context = @"Data Source=DESKTOP-PRIGFUM;Initial Catalog=QLHocphan;Integrated Security=True";
            return context;
        }    
    }
}
