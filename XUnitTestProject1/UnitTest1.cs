using System;
using System.Diagnostics;
using Xunit;
using XUnitAttributes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact, TestRail(123)]
        public void Test1()
        {
            Trace.WriteLine("**** Test1 invoked. ****");
        }
    }
}
