using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace test
{
    public partial class XtraUserControl1 : System.Windows.Forms.UserControl
    {

        public object DataSource { set; get; }

        public XtraUserControl1()
        {
            InitializeComponent();
        }
        public void SetObject(object obj)
        {
            DataSource = obj;
            RefreshData();
        }
        public void RefreshData()
        {
            int height = 18;
            propertyGridControl1.SelectedObject = DataSource;
            propertyGridControl2.SelectedObject = DataSource;
            propertyGridControl3.SelectedObject = DataSource;
            for (int i = 0; i < propertyGridControl1.Rows[0].ChildRows.Count; i++)
            {
                if (i % 3 == 0)
                {
                    propertyGridControl2.Rows[0].ChildRows[i].Visible = false;
                    propertyGridControl3.Rows[0].ChildRows[i].Visible = false;
                }
                else if (i % 3 == 1)
                {
                    propertyGridControl1.Rows[0].ChildRows[i].Visible = false;
                    propertyGridControl3.Rows[0].ChildRows[i].Visible = false;
                }
                else
                {
                    propertyGridControl1.Rows[0].ChildRows[i].Visible = false;
                    propertyGridControl2.Rows[0].ChildRows[i].Visible = false;
                }
                propertyGridControl1.Rows[0].ChildRows[i].Height = height;
                propertyGridControl2.Rows[0].ChildRows[i].Height = height;
                propertyGridControl3.Rows[0].ChildRows[i].Height = height;
            }
            //高度调整            
            this.Height = propertyGridControl1.Rows[0].ChildRows.VisibleRowsCount * height + 20;
            propertyGridControl1.BestFit();
            propertyGridControl2.BestFit();
            propertyGridControl3.BestFit();
        }
        //单元格底部画一条线
        private void propertyGridControl_CustomDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e)
        {
            Point sp = new Point(e.Bounds.X, e.Bounds.Y + e.Bounds.Height - 1);
            Point ep = new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height - 1);
            e.Graphics.DrawLine(new Pen(Color.Black), sp, ep);
            e.Appearance.DrawString(e.Cache, " " + e.CellText, e.Bounds);
            e.Handled = true;
        }

        private void propertyGridControl_CustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e)
        {
            e.Appearance.BackColor = Color.White;
        }

        private void XtraUserControl1_Resize(object sender, EventArgs e)
        {
            propertyGridControl1.BestFit();
            propertyGridControl2.BestFit();
            propertyGridControl3.BestFit();
        }
    }
}
