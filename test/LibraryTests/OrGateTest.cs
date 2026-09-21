using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.Exercise;

public class OrGateTest
{
    [Test]
    public void Output_WhenInputsAreTrue_ReturnTrue()
    {   
        ILogicvalue input1 = new Truevalue();
        ILogicvalue input2 = new Truevalue();
        OrGate objetotesteo = new OrGate(input1, input2);
        
        bool resultadocorrecto = true;
        Assert.That(objetotesteo.Output, Is.EqualTo(resultadocorrecto));
    }

    [Test]
    public void Output_WhenInputsAreTrueAndFalse_ReturnTrue()
    {   
        ILogicvalue input1 = new Truevalue();
        ILogicvalue input2 = new Falsevalue();
        OrGate objetotesteo = new OrGate(input1, input2);
        
        bool resultadocorrecto = true;
        Assert.That(objetotesteo.Output, Is.EqualTo(resultadocorrecto));
    }

    [Test]
    public void Output_WhenInputsAreFalseAndTrue_ReturnTrue()
    {   
        ILogicvalue input1 = new Falsevalue();
        ILogicvalue input2 = new Truevalue();
        OrGate objetotesteo = new OrGate(input1, input2);
        
        bool resultadocorrecto = true;
        Assert.That(objetotesteo.Output, Is.EqualTo(resultadocorrecto));
    }

    [Test]
    public void Output_WhenInputsAreFalseAndFalse_ReturnFalse()
    {   
        ILogicvalue input1 = new Falsevalue();
        ILogicvalue input2 = new Falsevalue();
        OrGate objetotesteo = new OrGate(input1, input2);
        
        bool resultadocorrecto = false;
        Assert.That(objetotesteo.Output, Is.EqualTo(resultadocorrecto));
    }
}
