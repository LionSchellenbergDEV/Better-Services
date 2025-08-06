using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    private int cornerRadius = 10;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90);
            path.AddArc(new Rectangle(this.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), 270, 90);
            path.AddArc(new Rectangle(this.Width - cornerRadius * 2, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90);

            this.Region = new Region(path);

            // Optional: Rahmen zeichnen
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}