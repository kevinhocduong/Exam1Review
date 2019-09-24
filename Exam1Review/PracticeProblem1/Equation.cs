﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem1
{
    class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        public Equation()
        {
            Left = 0.0;
            Right = 0.0;
        }

        public Equation (double left, double right)
        {
            this.Left = left;
            this.Right = right;
        }

        public double Add()
        {
            return Left + Right;
        }

        public double Subtract()
        {
            return Left - Right;
        }

        public double Multiply()
        {
            return Left * Right; 
        }

        public double LeftToThePower (int power)
        {
            return Math.Pow(Left, power);
        }

        public double RightToThePower (int power)
        {
            return Math.Pow(Right, power);
        }
    }
}
