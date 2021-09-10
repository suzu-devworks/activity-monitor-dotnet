using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityMonitor.WinApp.Views
{
    [Docking(DockingBehavior.AutoDock)]
    public partial class GraphView : UserControl
    {
        public GraphView()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.ResizeRedraw, true);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.DesignMode)
            {
                using var brush = new SolidBrush(Color.AliceBlue);
                e.Graphics.FillRectangle(brush, e.ClipRectangle);

                ControlPaint.DrawStringDisabled(e.Graphics, "文字", this.Font, this.ForeColor, e.ClipRectangle, null);

                //ControlPaint.DrawCheckBox(e.Graphics, e.ClipRectangle, ButtonState.Checked);
            }

            if (this.Focused)
            {
                ControlPaint.DrawFocusRectangle(e.Graphics, e.ClipRectangle);
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            this.Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            this.Invalidate();
        }

        private void DrawForcusRectangle(PaintEventArgs e)
        {
            if (this.Focused)
            {
                Rectangle rc = this.ClientRectangle;
                rc.Width -= 1;
                rc.Height -= 1;
                using (Pen p = new Pen(Color.GreenYellow, 3.0f))
                {
                    e.Graphics.DrawRectangle(p, rc);
                }
            }
            return;
        }
    }
}
