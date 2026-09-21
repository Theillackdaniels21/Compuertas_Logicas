using System;

namespace Ucu.Poo.Exercise
{
    public class NotGate : IGate
    {
        private ILogicvalue input1;

        public NotGate(ILogicvalue input1)
        {
            this.input1 = input1;
        }

        public bool Output
        {
            get
                {return !this.input1.Value;}
        }
    }
}