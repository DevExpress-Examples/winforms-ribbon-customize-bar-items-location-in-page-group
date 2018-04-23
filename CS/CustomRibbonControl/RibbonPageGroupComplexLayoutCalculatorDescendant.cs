using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraBars;
using System.Windows.Forms;

namespace CustomRibbonControl {
    public class RibbonPageGroupComplexLayoutCalculatorDescendant : RibbonPageGroupComplexLayoutCalculator {
        int offsetY;
        int offsetX;
        List<int> widthList = new List<int>();

        public RibbonPageGroupComplexLayoutCalculatorDescendant(IRibbonGroupInfo groupInfo)
            : base(groupInfo) {
        }

        protected override void InsertItemCore(RibbonPageGroupLayoutCalculator.GroupColumnLayoutInfo info) {
            base.InsertItemCore(info);
            BarItemExtender barItemExtender = ((RibbonControlDescendant)GroupInfo.ViewInfo.Ribbon).BarItemExtender;
            if (barItemExtender != null) {
                if (info.ItemInfo.Item is BarItemLink) {
                    Point Location = barItemExtender.GetLocation((BarItem)((BarItemLink)info.ItemInfo.Item).Item);
                    offsetX = Location.X;
                    offsetY = Location.Y;
                    widthList.Add(offsetX + info.ItemInfo.Bounds.Width);
                    if (offsetY > info.ContentBounds.Height)
                        offsetY = info.ContentBounds.Height - info.ItemInfo.Bounds.Height;
                    info.ItemInfo.Bounds = new Rectangle(new Point(info.ContentBounds.X + offsetX, info.ContentBounds.Y + offsetY), info.ItemInfo.Bounds.Size);
                    info.MaxColumnWidth = widthList.Max();
                }
            }
        }
        protected override int UpdateGroupLayout(Rectangle contentBounds) {
            GroupColumnLayoutInfo info = new GroupColumnLayoutInfo();
            info.Location = contentBounds.Location;
            info.ContentBounds = contentBounds;
            GroupInfo.ContentBounds = contentBounds;
            info.MaxColumnWidth = 0;
            info.ColumnItemCount = 0;
            for (info.Position = 0; info.Position < GroupInfo.Items.Count; ) {
                info.ItemInfo = GroupInfo.Items[info.Position];
                InsertItem(info);
                info.Position++;
            }
            if (GroupInfo.ViewInfo.Ribbon.AutoSizeItems) AutoSizeItems(info);
            RelayoutItemsInColumn();
            int width = info.Location.X + info.MaxColumnWidth - info.ContentBounds.Left;
            return width;
        }
        protected override void RelayoutItemsInColumn() {
        }
    }
}
