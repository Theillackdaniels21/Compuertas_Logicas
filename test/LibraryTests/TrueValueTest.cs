using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.Exercise;

public class TrueValueTest
{
    [Test]
    public void ValueTrue()
    {   
        Truevalue objetotesteo = new Truevalue();

        bool resultadocorrecto = true;
        Assert.That(objetotesteo.Value, Is.EqualTo(resultadocorrecto));
    }
}
