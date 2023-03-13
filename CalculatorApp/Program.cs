using CalculatorBl.Bl;
using CalculatorBl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sVarSwitch = string.Empty;
            while (sVarSwitch != "e")
            {
                UiHelper.MainOptions();
                sVarSwitch = Console.ReadLine();
                switch (sVarSwitch)
                {
                    case "e":
                        sVarSwitch = "e";
                        break;
                    case "1":
                        Console.Clear();
                        UiHelper.NormalCalOptions();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }

            }

        }
    }
}
