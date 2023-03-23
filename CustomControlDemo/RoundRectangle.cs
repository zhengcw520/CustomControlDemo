using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControlDemo
{
    public class RoundRectangle:Control
    {
        public RoundRectangle()
        {
            this.BackColor = Color.White;
            this.Size = new Size(200,80);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0,0,40,50);
            DrawExtension.FillRoundRectangle(g,rec,Color.Red,4);
        }
    }
}
