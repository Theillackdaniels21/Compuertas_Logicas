using System;

namespace Ucu.Poo.Exercise
{
    public class Gateoutput : ILogicvalue
    {
        private IGate gate;

        public Gateoutput(IGate gate)
        {
            this.gate = gate;
        }

        public bool Value
        {
            get
            {
                return gate.Output;
            }
        }
    }
}