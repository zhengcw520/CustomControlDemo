using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace CustomControlDemo
{
    public class DrawExtension
    {
        /// <summary> 
        /// C# GDI+ 绘制圆角实心矩形 
        /// </summary> 
        /// <param name="g">Graphics 对象</param> 
        /// <param name="rectangle">要填充的矩形</param> 
        /// <param name="backColor">填充背景色</param> 
        /// <param name="r">圆角半径</param> 
        public static void FillRoundRectangle(Graphics g, Rectangle rectangle, Color backColor, int r)
        {
            rectangle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width - 1, rectangle.Height - 1);
            Brush b = new SolidBrush(backColor);
            g.FillPath(b, GetRoundRectangle(rectangle, r));
        }

        /// <summary> 
        /// 根据普通矩形得到圆角矩形的路径 
        /// </summary> 
        /// <param name="rectangle">原始矩形</param> 
        /// <param name="r">半径</param> 
        /// <returns>图形路径</returns> 
        private static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int l = 2 * r;
            // 把圆角矩形分成八段直线、弧的组合，依次加到路径中 
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);

            gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);

            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);

            gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
            return gp;
        }
    }
}
