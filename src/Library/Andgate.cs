using System;
using System.Xml;

namespace Ucu.Poo.Exercise
{
    public class AndGate : IGate
    {
        private ILogicvalue input1;
        private ILogicvalue input2;

        public AndGate(ILogicvalue input1, ILogicvalue input2)
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        public bool Output
        {
            get
                {return this.input1.Value && this.input2.Value;}
        }
    }
}