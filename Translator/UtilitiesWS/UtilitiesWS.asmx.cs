using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UtilitiesWS
{
    /// <summary>
    /// Summary description for UtilitiesWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UtilitiesWS : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// Pass Gross Amount and percentage charged... This function will return Net Price and VAT charged
        /// </summary>
        /// <param name="GrossAmount"></param>
        /// <param name="percentage"></param>
        /// <returns></returns>
        [WebMethod]
        public List<double> CalculatePercentage(double GrossAmount, double percentage)
        {

            double Tpercentage = 1 + percentage / 100;
            List<double> Net_calculateVAT = new List<double>();


            Net_calculateVAT.Add(Math.Round(GrossAmount - GrossAmount / Tpercentage, 2));
            Net_calculateVAT.Add(Math.Round(GrossAmount / Tpercentage, 2));

            return Net_calculateVAT;

        }

        [WebMethod]
        public decimal GetAmount(string Amount)
        {
            const string allowed = "0123456789-.+";
            foreach (var chr in Amount)
            {
                if (!allowed.Contains(chr)) Amount = Amount.Replace(chr.ToString(), String.Empty);
            }

            return Convert.ToDecimal(Amount);
            
        }

        /// <summary>
        /// Pass Fuel Bought in Litres, Car Consumtption Miles/Gallon, and N f Litres in a Gallon
        /// </summary>
        /// <param name="FuelBought_Litres"></param>
        /// <param name="FuelConsumtion_MilesPerGallon"></param>
        /// <param name="LitresInGallon"></param>
        /// <returns></returns>
        [WebMethod]
        public double GetDistanceCovered(double FuelBought_Litres, double FuelConsumtion_MilesPerGallon, double LitresInGallon = 4.55)
        {
            double d = (FuelConsumtion_MilesPerGallon / LitresInGallon) * FuelBought_Litres;
            return d;
        }
    }
}
