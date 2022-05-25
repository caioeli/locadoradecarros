using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoradecarros.controller
{
    class conexaoBD
    {
        public static string conectar()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\caio.esilva10\source\repos\locadoradecarros\locadoradecarros\Database1.mdf; Integrated Security = True";
        }

    }
}
