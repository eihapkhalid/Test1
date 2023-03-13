using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBl;
using CalculatorBl.Bl;
using CalculatorBl.Models;


namespace CalculatorApp
{
    public class UiHelper
    {
        public static void MainOptions() 
        {
            Console.WriteLine("*** wlc to cal app :\n");
            Console.WriteLine("press e to exit  :\n");
            Console.WriteLine("press 1 to normal cal :\n");
            Console.WriteLine("press 2 to sin cal  :\n");
            Console.WriteLine("press 3 to proff cal  :\n");
        }

        #region NormalCalOptions
        public static void NormalCalOptions()
        {
            string sVarSwitch = string.Empty;
            while (sVarSwitch != "b")
            {
                Console.WriteLine("press b to back  :\n");
                Console.WriteLine("press 1 to add number  :\n");
                Console.WriteLine("press 2 to sub number  :\n");
                Console.WriteLine("press 3 to mul number  :\n");
                Console.WriteLine("press 4 to div number  :\n");

                sVarSwitch = Console.ReadLine();
                ClsNormalCalBl oClsNormalCalBl = new ClsNormalCalBl();

                switch (sVarSwitch)
                {
                    case "b":
                        Console.Clear();
                        sVarSwitch = "b";
                        break;
                    case "1":
                        Console.Clear();
                        NormalCalModel ONormalCalAddModel = new NormalCalModel();
                        oClsNormalCalBl.Add(ONormalCalAddModel);
                        break;
                    case "2":
                        Console.Clear();
                        NormalCalModel ONormalCalSubModel = new NormalCalModel();
                        oClsNormalCalBl.Sub(ONormalCalSubModel);
                        break;
                    case "3":
                        Console.Clear();
                        NormalCalModel ONormalCalMulModel = new NormalCalModel();
                        oClsNormalCalBl.Mul(ONormalCalMulModel);
                        break;
                    case "4":
                        Console.Clear();
                        NormalCalModel ONormalCalDivModel = new NormalCalModel();
                        oClsNormalCalBl.Div(ONormalCalDivModel);
                        break;
                }

            }
        }
        #endregion

        #region SinCalOptions
        public static void SinCalOptions()
        {
            string sVarSwitch = string.Empty;
            while (sVarSwitch != "b")
            {
                Console.WriteLine("press b to back  :\n");
                Console.WriteLine("press 1 to sin number  :\n");
                Console.WriteLine("press 2 to cos number  :\n");
                Console.WriteLine("press 3 to tan number  :\n");

                sVarSwitch = Console.ReadLine();
                ClsSincCalBl oClsSincCalBl = new ClsSincCalBl();

                switch (sVarSwitch)
                {
                    case "b":
                        Console.Clear();
                        sVarSwitch = "b";
                        break;
                    case "1":
                        Console.Clear();
                        SincCalModel oSinSincCalModel = new SincCalModel();
                        oClsSincCalBl.Sin(oSinSincCalModel);
                        break;
                    case "2":
                        Console.Clear();
                        SincCalModel oSinCosCalModel = new SincCalModel();
                        oClsSincCalBl.Cos(oSinCosCalModel);
                        break;
                    case "3":
                        Console.Clear();
                        SincCalModel oSinTanCalModel = new SincCalModel();
                        oClsSincCalBl.tan(oSinTanCalModel);
                        break;

                }

            }
        } 
        #endregion
    }
}
