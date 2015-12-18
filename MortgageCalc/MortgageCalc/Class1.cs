using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalc
{
    public partial class CalcManager
    {
        public CalcManager()
        {
            Init();
            // set these in init or dont have init

            firstEmpty    = 
            secondEmpty   = 
            thirdEmpty    =
            multipleEmpty = true;
        }
        public bool firstEmpty;
        public bool secondEmpty;
        public bool thirdEmpty;
        public bool multipleEmpty; // even necessary?
        //will i need a bool to know if more than one
        //box is empty or just run a check?
        //kiss get it working! refactor logic later
        //public List<string> allInputValues;
        public List<string> allOutputMortgageValues;
        public List<string> allOutputInterestValues;
        public List<string> allOutputPeriodValues;

        void Init()
        {
            allInputValues = new List<string> { };
            allOutputMortgageValues = new List<string> { };
            allOutputInterestValues = new List<string> { };
            allOutputPeriodValues = new List<string> { };
        }
    }
}
