using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private string currentStringValue;
        private string nextStringValue;
        private bool operatorUsedBool = false;
        private bool addOperatorBool = false;
        private bool subOperatorBool = false;
        private bool mulOperatorBool = false;
        private bool divOperatorBool = false;
        private bool nonEqualsSolveBool = false;
        private bool successiveOperatorBool = false;
        private double solution;

        public bool NonEqualsSolveBool
        {
            get{
                return nonEqualsSolveBool;
            }
            set
            {
                nonEqualsSolveBool = value;
            }
        }
        public bool OperatorUsedBool
        {
            set
            {
                operatorUsedBool = value;
            }
            get
            {
                return operatorUsedBool;
            }
        }
        public bool AddOperatorBool
        {
            set
            {
                addOperatorBool = value;
            }
            get
            {
                return addOperatorBool;
            }
        }
        public bool SuccessiveOperatorBool
        {
            set
            {
                successiveOperatorBool = value;
            }
            get
            {
                return successiveOperatorBool;
            }
        }
        public bool SubOperatorBool
        {
            set
            {
                subOperatorBool = value;
            }
            get
            {
                return subOperatorBool;
            }
        }
        public bool MulOperatorBool
        {
            set
            {
                mulOperatorBool = value;
            }
            get
            {
                return mulOperatorBool;
            }
        }
        public bool DivOperatorBool
        {
            set
            {
                divOperatorBool = value;
            }
            get
            {
                return divOperatorBool;
            }
        }
        public string CurrentStringValue
        {
            get
            {
                return currentStringValue;
            }
            set
            {
                currentStringValue = value;
            }
        }
        public string NextStringValue
        {
            get
            {
                return nextStringValue;
            }
            set
            {
                nextStringValue = value;
            }
        }
        public double Solution
        {
            get
            {
                return solution;
            }
            set
            {
                solution = value;
            }
        }

        //logic for adding numbers to text box. 
        public void numberAdd()
        {
            if (NonEqualsSolveBool != true)
            {
                SuccessiveOperatorBool = false;
            }
            else
            {
                NonEqualsSolveBool = false;
                SuccessiveOperatorBool = false;
            }
        }
        //logic for clear.
        public void clear()
        {
            OperatorUsedBool = false;
            AddOperatorBool = false;
            SubOperatorBool = false;
            MulOperatorBool = false;
            DivOperatorBool = false;
            NonEqualsSolveBool = false;
        }

        public double solve()
        {

            if (nextStringValue != "")
            {
                if (AddOperatorBool == true)
                {
                    solution = Convert.ToDouble(CurrentStringValue) + Convert.ToDouble(nextStringValue);
                }
                else if (SubOperatorBool == true)
                {
                    solution = Convert.ToDouble(CurrentStringValue) - Convert.ToDouble(nextStringValue);
                }
                else if (MulOperatorBool == true)
                {
                    solution = Convert.ToDouble(CurrentStringValue) * Convert.ToDouble(nextStringValue);
                }
                else if (DivOperatorBool == true)
                {
                    solution = Convert.ToDouble(CurrentStringValue) / Convert.ToDouble(nextStringValue);
                }
            }
            else
            {
                solution = Convert.ToDouble(CurrentStringValue);
            }
            return solution;
        }
    }
}
