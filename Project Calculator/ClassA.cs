using System;
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
        public String Num1 = "";
        public String Num2 = "";
        private String Memory = "";
        public float Value = 0;

        public bool IsOperationsPressed { get => isOperationsPressed; set => isOperationsPressed = value; }
        public string Operation { get => operation; set => operation = value; }
    }
}
