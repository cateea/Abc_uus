using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity
{
    public sealed class Measures: Entity<MeasureDataData>
    {
        public Measures(): this(null) { }
        public Measures(MeasureDataData data) : base(data) { }
    }
}
