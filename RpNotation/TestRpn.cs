using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace RpNotation
{
  [TestFixture]
  class TestRpn
  {
    RpnCalc Rpn = new RpnCalc();
    [Test]
    public void AddTwoNumbers()
    {
      
      Assert.AreEqual("5", Rpn.RpnCal("3 2 +"));
    }

    [Test]
    public void SubTwoNumbers()
    {

      Assert.AreEqual("20", Rpn.RpnCal("40 20 -"));
    }
    [Test]
    public void DivideNumbers()
    {
      Assert.AreEqual("6", Rpn.RpnCal("30 5 /"));
    }

    [Test]
    public void MultiplyNumbers()
    {
      Assert.AreEqual("12", Rpn.RpnCal("4 3 *"));
    }

    [Test]
    public void Complex()
    {
      Assert.AreEqual("14", Rpn.RpnCal("5 1 2 + 4 * + 3 -"));
    }

    [Test]
    public void InvalidExpression()
    {
      Assert.AreEqual("Invalid Expression", Rpn.RpnCal("2 + 2"));
    }

    [Test]
    public void OutOfRange()
    {
      Assert.AreEqual("Out of range exception", Rpn.RpnCal("98284920922 1 2 + 4 * + 3 -"));
    }
  }
}
