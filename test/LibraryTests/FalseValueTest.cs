using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.Exercise;

public class FalseValueTest
{
    [Test]
    public void FalseValue()
    {   
        Falsevalue objetotesteo = new Falsevalue();

        bool resultadocorrecto = false;
        Assert.That(objetotesteo.Value, Is.EqualTo(resultadocorrecto));
    }
}
