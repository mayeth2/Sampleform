using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Personnel
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string position;

        public string Position
        {
            get { return position; }
            set
            {
                position = value;

                SetGrossPay(position);

                //At this Point the Gross Pay has been updated
                //SetAllowances();
                SetLongPay(HireDate);
                SetDeductions();
                SetAllowances();
                SetTotalSalary();
                SetNetPay();
            }
        }


        public double GrossPay { get; private set; }

        private DateTime hireDate;

        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                hireDate = value;


                SetLongPay(hireDate);

            }
        }

        public double LongPay { get; private set; }

        public double GSIS { get; private set; }
        public double PhilHealthDeduction { get; private set; }
        public double Tax { get; private set; }
        public double TotalDeductions { get; private set; }

        public double TotalSalary { get; private set; }

        public double NetPay { get; private set; }

        public double HazardPay { get; private set; }
        public double ClothingAllowance { get; private set; }
        public double QuarterAllowance { get; private set; }
        public double LaundryAllowance { get; private set; }
        public double TotalAllowances { get; private set; }


        public Personnel(string firstName = "Juan Dela", string lastName = "Cruz", string position = "PO1")
        {
            //Default HireDate is when creating an instane of the object
            HireDate = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            Position = position;

        }

        //METHODS
        private void SetLongPay(DateTime hireDate)
        {
            int YearsOfService = DateTime.Now.Year - hireDate.Year;


            switch (Position)
            {

                case "PO1":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1483.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3115.00;
                        }
                        //Continue the Else If



                        break;
                    }

                case "PO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5605.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 7859.00;
                        }
                        else if (YearsOfService == 25)
                        {
                            LongPay = 8467.00;
                        }
                        //Continue the Else If



                        break;
                    }

                case "PO3":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1867.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3920.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 6178.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 8662.00;
                        }
                        else if (YearsOfService == 25)
                        {
                            LongPay = 9333.00;
                        }
                        //Continue the Else If



                        break;
                    }
                case "SPO1":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 2171.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 4559.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 7186.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 10076.00;
                        }
                        else if (YearsOfService == 25)
                        {
                            LongPay = 10856.00;
                        }
                        //Continue the Else If



                        break;
                    }
                case "SPO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 2351.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 4938.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 7783.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 10912.00;
                        }
                        else if (YearsOfService == 25)
                        {
                            LongPay = 11757.00;
                        }
                        //Continue the Else If

                        break;
                    }
                //default:
                //    break;
            }

        }

        private void SetGrossPay(string position)
        {

            switch (position)
            {
                case "PO1":
                    {
                        GrossPay = 14834.00;
                        break;
                    }

                case "PO2":
                    {
                        GrossPay = 16934.00;
                        break;
                    }

                case "PO3":
                    {
                        GrossPay = 18665.00;
                        break;
                    }
                case "SPO1":
                    {
                        GrossPay = 21711.00;
                        break;
                    }
                case "SPO2":
                    {
                        GrossPay = 23513.00;
                        break;
                    }
                case "SPO3":
                    {
                        GrossPay = 25394.00;
                        break;
                    }
                case "SPO4":
                    {
                        GrossPay = 27425.00;
                        break;
                    }

                default:
                    break;
            }
        }

        
        ////Getting the GrossPay where GrossPay is not a property, a user can set
        //public double GetGrossPay()
        //{
        //    return GrossPay;
        //}



        private void SetAllowances()
        {
            HazardPay = Allowances.GetHazardPay(GrossPay);
            ClothingAllowance = Allowances.GetClothingAllowance(GrossPay);
            LaundryAllowance = Allowances.GetLaundryAllowance(GrossPay);
            QuarterAllowance = Allowances.GetQuarterAllowance(GrossPay);
            TotalAllowances = ClothingAllowance + HazardPay + QuarterAllowance + LaundryAllowance;

        }

        //Getting Hazard Pay
        //public double GetHazardPay()
        //{
        //    hazardPay = Allowances.GetHazardPay(GrossPay);
        //    return hazardPay;
        //}

        ////Getting Clothing Allowance
        //public double GetClothingAllowance()
        //{
        //    clothingAllowance = Allowances.GetClothingAllowance(GrossPay);
        //    return clothingAllowance;
        //}

        ////Getting Quarter Allowance
        //public double GetQuarterAllowance()
        //{
        //    quarterAllowance = Allowances.GetQuarterAllowance(GrossPay);
        //    return quarterAllowance;
        //}

        //Getting Laundry Allowance
        //public double GetLaundryAllowance()
        //{
        //    laundryAllowance = Allowances.GetLaundryAllowance(grossPay);
        //    return laundryAllowance;
        //}

        private void SetDeductions()
        {
            GSIS = Deductions.GetGSIS(GrossPay);
            Tax = Deductions.GetTax(GrossPay);
            PhilHealthDeduction = Deductions.GetPhilHealth(GrossPay);
            TotalDeductions = Deductions.GetGSIS(GrossPay) + Deductions.GetTax(GrossPay) + Deductions.GetPhilHealth(GrossPay);
        }

       

        private void SetTotalSalary()
        {

            TotalSalary = GrossPay + LongPay + TotalAllowances;
            
        }

        private void SetNetPay()
        {

            NetPay = GrossPay + LongPay - TotalDeductions;

        }

        
    }
 }
    
