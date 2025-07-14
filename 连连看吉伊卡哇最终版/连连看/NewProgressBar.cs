using Microsoft.DirectX.DirectSound;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 连连看
{
    public class NewProgressBar : ProgressBar
    {
        private Brush[] brushes = new Brush[] { Brushes.Red, Brushes.Yellow, Brushes.Orange, Brushes.Lime, };
        public NewProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            double rate = (double)Value / Maximum;
            rec.Width = (int)(rec.Width * rate) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            if (rate >= 0.75)
                e.Graphics.FillRectangle(Brushes.Lime, 2, 2, rec.Width, rec.Height);
            else if (rate >= 0.5)
                e.Graphics.FillRectangle(Brushes.Yellow, 2, 2, rec.Width, rec.Height);
            else if (rate >= 0.25)
                e.Graphics.FillRectangle(Brushes.Orange, 2, 2, rec.Width, rec.Height);
            else
                e.Graphics.FillRectangle(Brushes.Red, 2, 2, rec.Width, rec.Height);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
