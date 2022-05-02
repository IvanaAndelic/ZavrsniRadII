using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgebraicExpressionInterpreter;

namespace UnitTests
{
    [TestClass]
    public class TestSumExpression
    {
        [TestMethod]
        public void SumExpressionInterpretForTwoConstantsReturnsTheirSum()
        {
            Constant left = new Constant("23");
            Constant right = new Constant("2");
            SumExpression sum = new SumExpression(left, right);

            Context context = new Context(3);
            Assert.AreEqual(25, sum.Interpret(context));
        }

        [TestMethod]
        public void SumExpressionInterpretForConstantsAndVariableReturnsTheirSum()
        {
            IExpression left = new VariableX();
            IExpression right = new Constant("2");
            SumExpression sum = new SumExpression(left, right);

            Context context = new Context(3);
            Assert.AreEqual(5, sum.Interpret(context));

        }

        [TestMethod]
        public void SumExpressionInterpretForTwoVariablesReturnsTheirSum()
        {
            IExpression left = new VariableX();
            IExpression right = new VariableX();
            SumExpression sum = new SumExpression(left, right);

            Context context = new Context(4);
            Assert.AreEqual(8, sum.Interpret(context));
        }

    }
}
