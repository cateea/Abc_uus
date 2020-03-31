using Abc.Data.Common;
using Abc.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Quantity
{
    [TestClass]
    public class CommonTermTests : AbstractClassTests<CommonTermData, PeriodData>
    {
        private class TestClass : CommonTermData { }
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod] public void MasterIdTest()
        {
            isNullableProperty(()=>obj.MasterId, x=> obj.MasterId=x);
        }
    }
}
