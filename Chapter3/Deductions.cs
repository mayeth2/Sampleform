using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Deductions
    {
        
        //Static Classes, use static Methods
        
        public static double GetTotalDeductions(double GrossPay)
        {
            double TotalDeductions = GetGSIS(GrossPay) + GetTax(GrossPay);

            return TotalDeductions;
        }



        public static double GetGSIS(double GrossPay)
        {
            //EDIT
            double GSIS = GrossPay * .012;

            return GSIS;
        }


        //public static double GetPhilHealth(double GrossPay)
        //{
        //    //DO Logic for PhilHealth

        //    return 100;
        //}


        public static double GetTax(double GrossPay)
        {

            return 100;

        }
      
        public static double GetPhilHealth(double GrossPay)
        {
            double PhilHealthDeduction = 0;
            if (GrossPay >= 14000 && GrossPay < 15000)
            {
                PhilHealthDeduction = 162.50;
            }
            else if (GrossPay >= 15000 && GrossPay < 16000)
            {
                PhilHealthDeduction = 175.00;
            }
            else if (GrossPay >= 16000 && GrossPay < 17000)
            {
                PhilHealthDeduction = 187.50;
            }
            else if (GrossPay >= 17000 && GrossPay < 18000)
            {
                PhilHealthDeduction = 200.00;
            }
            else if (GrossPay >= 18000 && GrossPay < 19000)
            {
                PhilHealthDeduction = 212.50;
            }
            else if (GrossPay >= 19000 && GrossPay < 20000)
            {
                PhilHealthDeduction = 225.00;
            }
            else if (GrossPay >= 20000 && GrossPay < 21000)
            {
                PhilHealthDeduction = 237.50;
            }
            else if (GrossPay >= 21000 && GrossPay < 22000)
            {
                PhilHealthDeduction = 250.00;
            }
            else if (GrossPay >= 22000 && GrossPay < 23000)
            {
                PhilHealthDeduction = 262.50;
            }

            return PhilHealthDeduction;


        }

       


        //internal static double GetPhilHealth(double grossPay)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
