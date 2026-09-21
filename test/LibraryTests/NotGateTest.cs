using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.Exercise;

public class NotGateTest
{
    [Test]
    public void Output_WhenInputAreTrue_ReturnFalse()
    {   
        ILogicvalue input1 = new Truevalue();
        NotGate objetotesteo = new NotGate(input1);
        
        bool resultadocorrecto = false;
        Assert.That(objetotesteo.Output, Is.EqualTo(resultadocorrecto));
    }

    [Test]
    public void Output_WhenInputAreFalse_ReturnTrue()
    {   
        ILogicvalue input1 = new Falsevalue();
        NotGate objetotesteo = new NotGate(input1);
        
        bool resultadocorrecto = true;
        Assert.That(objetotesteo.Output, Is.EqualTo(resultadocorrecto));
    }
}