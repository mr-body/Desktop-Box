using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace Desktop_Box.Classes
{
    public class conn
    {
        public static void conection()
        {
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
            SqlCeCommand cmd = new SqlCeCommand();
            SqlCeDataAdapter da = new SqlCeDataAdapter();
        }
    }
}
