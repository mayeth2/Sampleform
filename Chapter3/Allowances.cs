using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public static class Allowances
    {
       

        public static double GetTotalAllowances(double GrossPay)
        {
            double TotalAllowances = (GetHazardPay(GrossPay) + GetClothingAllowance(GrossPay) + GetQuarterAllowance(GrossPay) + GetLaundryAllowance(GrossPay)); 

            return TotalAllowances;
        }

                       
        //Getting Hazard Pay
        public static double GetHazardPay(double GrossPay)
        {
            double HazardPay = 240;
            return HazardPay;
        }

        //Getting Clothing Allowance
        public static double GetClothingAllowance(double GrossPay)
        {
            double ClothingAllowance = 200;
            return ClothingAllowance;
            
        }

        //Getting Quarter Allowance
        

        public static double GetQuarterAllowance(double GrossPay)
        {
                double QuarterAllowance = 0;

                if (GrossPay >= 14834 && GrossPay <= 16934)
                {
                       QuarterAllowance = 400;
                }
                else if (GrossPay >= 18665 && GrossPay <= 21711)      
                {
                        QuarterAllowance = 450;
                       
                }
                else if (GrossPay >= 23513 && GrossPay <= 25394)      
                {
                        QuarterAllowance = 500;
                }
                return QuarterAllowance;
            
        }

        public static double GetLaundryAllowance(double GrossPay)
        {
            double LaundryAllowance = 0;
            if (GrossPay >=14834 && GrossPay <=27425)
            {
                return 30;
            }
            else if (GrossPay >=32341)
            {
                return 60;
            }

            return LaundryAllowance;
        }
        
                   
    }
}
