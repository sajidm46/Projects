using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Configuration;
using static WpfApp1.Model.ModelClasses;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count;

        public MainWindow()
        {
            InitializeComponent();



        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {


            UtilitiesWS.UtilitiesWSSoapClient utilitiesWS = new UtilitiesWS.UtilitiesWSSoapClient();
            string s = utilitiesWS.HelloWorld();
            double distance = utilitiesWS.GetDistanceCovered(50, 40, 4.55);
            decimal amunt = utilitiesWS.GetAmount("£ 23.50");

            List<double> rtnVATNET = utilitiesWS.CalculatePercentage(950, 20);



            string filePath = string.IsNullOrEmpty(ConfigurationManager.AppSettings["filepath"])
                ? "C:\"" : ConfigurationManager.AppSettings["filepath"];

            DirectoryInfo dInfo = new DirectoryInfo(filePath);
            FileInfo[] files = new FileInfo[] { };

            files = dInfo.GetFiles("*.resx");

            Stream stream;
            StreamReader streamReader = null;
            List<string> dictionaries = new List<string>();
            foreach (var item in files)
            {
                streamReader = new StreamReader(filePath + item.ToString());
                string line;
                string sline;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Contains("<data name") && !line.Contains("<value>") && !line.Contains("type"))
                    {
                        line=line.Trim();
                        sline = line.Substring(12, line.Length - 13 - (line.IndexOf(">") - line.IndexOf("\" xml")));
                        line = streamReader.ReadLine();
                        if (!line.Contains("<data name") && line.Contains("<value>"))
                        {
                            sline += "|" + line.Substring(11, line.IndexOf("</value") - 11);
                        }
                        dictionaries.Add(item + "|" + sline);
                        Insert(dictionaries[count]);
                        count++;

                    }
                }
            }

            List<Resx> r = Resx_ReadAll();

        }

        private decimal GetAmount2(string Amount)
        {
                const string allowed = "0123456789-.+";
                foreach (var chr in Amount)
                {
                    if (!allowed.Contains(chr)) Amount=Amount.Replace(chr.ToString(), String.Empty);
                }

                return Convert.ToDecimal(Amount);
        }

        public List<Resx> Resx_ReadAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ResxConnection"]))
            {
                return db.Query<Resx>
                ("Select * From Resx").ToList();
            }
        }

        public int Insert(string data)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ResxConnection"]))
            {
                string ResourseFile = data.Split('|')[0];
                string name = data.Split('|')[1];
                string value = data.Split('|')[2];

                string s = @"INSERT INTO [Translator].[dbo].[Resx]
                         ([ResourseFile],[name],[value])
                        VALUES
                        ( '" + ResourseFile + "', '" + name + "', '" + value + "')";
                //int inserted = db.Execute(s);
                return 0;
            }
        }

        public bool Existed(string data)
        {
            string ResourseFile = data.Split('|')[0];
            string name = data.Split('|')[1];
            string value = data.Split('|')[2];

            string check = "SELECT * FROM Resx WHERE ResourseFile] = '" + ResourseFile + "', name = '" + name + "', value + '" + value + "')";
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ResxConnection"]))
            {
                var o = db.Query<Resx>(check);
                return true;
            }


        }



    }
}
