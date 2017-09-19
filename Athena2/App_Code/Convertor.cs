using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Athena2.App_Code
{
    class Convertor
    {

        public string MyPath
        {
            get { return MyPath; }
            set
            {
                if (File.Exists(value)) { MyPath = value; } else { return; }

            }


        }
    }
}
