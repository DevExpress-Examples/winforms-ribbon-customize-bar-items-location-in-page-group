using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Runtime.InteropServices;
using System.Drawing;

namespace CustomRibbonControl {
    public class RibbonControlDescendant : RibbonControl {
        private BarItemExtender _BarItemExtender;
        RibbonViewInfoDescendant viewInfo;

        public BarItemExtender BarItemExtender {
            get { return _BarItemExtender; }
            set {
                _BarItemExtender = value;
                if (value != null)
                    _BarItemExtender.LocationChanged += OnItemLocationChanged;
                this.Refresh();
            }
        }
        public RibbonControlDescendant()
            : base() {
        }
        void OnItemLocationChanged(object sender, EventArgs e) {
            this.Refresh();
        }
        protected override RibbonViewInfo CreateViewInfo() {
            viewInfo = new RibbonViewInfoDescendant(this);
            return (RibbonViewInfo)viewInfo;
        }
        protected override void Dispose(bool disposing) {
            if (disposing && _BarItemExtender != null)
                _BarItemExtender.LocationChanged -= OnItemLocationChanged;
            base.Dispose(disposing);
        }
        protected override void OnGroupAdded(RibbonPageGroup group) {
            base.OnGroupAdded(group);
            if (group.AllowMinimize)
                group.AllowMinimize = false;
        }

        protected override void OnGroupChanged(RibbonPageGroup pageGroup) {
            base.OnGroupChanged(pageGroup);
            if (pageGroup.AllowMinimize)
                pageGroup.AllowMinimize = false;
        }
    }
}
