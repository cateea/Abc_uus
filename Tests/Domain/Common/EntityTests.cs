using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common {

    [TestClass] public class EntityTests : AbstractClassTests<Entity<MeasureDataData>, object> {

        private class testClass : Entity<MeasureDataData> {

            public testClass(MeasureDataData d = null) : base(d) { }

        }

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod] public void DataTest() {
            var d = GetRandom.Object<MeasureDataData>();
            Assert.AreNotSame(d, obj.Data);
            obj = new testClass(d);
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod] public void DataIsNullTest() {
            var d = GetRandom.Object<MeasureDataData>();
            Assert.IsNotNull(obj.Data);
            obj.Data = d;
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod] public void CanSetNullDataTest() {
            Assert.IsNotNull(obj.Data);
            obj.Data = null;
            Assert.IsNull(obj.Data);
        }

    }

}
