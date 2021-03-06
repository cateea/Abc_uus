﻿using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Pages.Quantity {

    public abstract class MeasuresPage : BasePage<IMeasuresRepository, Measures, MeasureView, MeasureDataData> {

        protected internal MeasuresPage(IMeasuresRepository r = null): base(r) {
            PageTitle = "Measures";
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string getPageUrl() => "/Quantity/Measures";

        protected internal override Measures toObject(MeasureView view) {
            return MeasureViewFactory.Create(view);
        }

        protected internal override MeasureView toView(Measures obj) {
            return MeasureViewFactory.Create(obj);
        }

    }

}
