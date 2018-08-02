using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class ModelClasses
    {
        public class Resx
        {
            public int ID { get; set; }
            public string ResourseFile { get; set; }
            public string name { get; set; }
            public string value { get; set; }
        }

        


    }
}
