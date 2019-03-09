﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public abstract class Shape
    {
        public abstract double calculateBoundary(double d);

        public abstract double calculateArea(double d);
    }
}
