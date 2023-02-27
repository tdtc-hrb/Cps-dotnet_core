using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cps_x35
{
    public class CpsConfig
    {
        public MysqlOracle MysqlOracle { get; set; }
    }

    public partial class MysqlOracle
    {
        public string ConnectionString { get; set; }
    }
}
