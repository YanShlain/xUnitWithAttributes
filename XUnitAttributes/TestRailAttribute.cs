using System.Diagnostics;
using System.Reflection;
using Xunit.Sdk;

namespace XUnitAttributes
{
    public class TestRailAttribute : BeforeAfterTestAttribute
    {
        private int _testNumber;

        public TestRailAttribute(int testNum)
        {
            _testNumber = testNum;
        }

        public override void Before(MethodInfo methodUnderTest)
        {
            Trace.WriteLine(
                string.Format(
                    "Before : {0}.{1}",
                    methodUnderTest.DeclaringType.FullName,
                    methodUnderTest.Name));
        }

        public override void After(MethodInfo methodUnderTest)
        {
            Trace.WriteLine(
                string.Format(
                    "After : {0}.{1}",
                    methodUnderTest.DeclaringType.FullName,
                    methodUnderTest.Name));
        }
    }
}
