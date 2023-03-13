﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBl.Models;

namespace CalculatorBl.Bl
{
    public interface IBusinessLayer<t>
    {
        void Add(t table);
        void Sub(t table);
        void Mul(t table);
        void Div(t table);
    }
}
