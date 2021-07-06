﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Calculator
{
    class ClassA
    {
        private String operation = "";
        private Boolean isOperationsPressed = false;
        private String Num1 = "";
        private String Num2 = "";
        private String Memory = "";

        public bool IsOperationsPressed { get => isOperationsPressed; set => isOperationsPressed = value; }
        public string Operation { get => operation; set => operation = value; }
        public string Num1a { get => Num1; set => Num1 = value; }
        public string Num2a { get => Num2; set => Num2 = value; }
        public string Memory1 { get => Memory; set => Memory = value; }

        public void Add()
        {
            Num2a = (float.Parse(Num1a) + float.Parse(Num2a)).ToString();
        }

        public void Subtract()
        {
            Num2a = (float.Parse(Num1a) - float.Parse(Num2a)).ToString();
        }

        public void Multiply()
        {
            Num2a = (float.Parse(Num1a) * float.Parse(Num2a)).ToString();
        }

        public void Divide()
        {
            Num2a = (float.Parse(Num1a) / float.Parse(Num2a)).ToString();
        }

        public void Percent()
        {
            Num2a = (float.Parse(Num1a) * (float.Parse(Num2a)) / 100).ToString();
        }  
    }
}
