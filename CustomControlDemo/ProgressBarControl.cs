using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControlDemo
{
    public class ProgressBarControl : Control
    {
        public ProgressBarControl()
        {
            this.BackColor = Color.White;
            //this.Size = new Size(200,100);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// 前景颜色
        /// </summary>
        private Color foreColor;
        [Description("进度条最大值"), Category("自定义")]
        public override Color ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; Refresh(); }
        }

        /// <summary>
        /// 字体颜色
        /// </summary>
        private Color fontColor;
        [Description("进度条显示字体颜色"), Category("自定义")]
        public Color FontColor
        {
            get { return fontColor; }
            set { fontColor = value; Refresh(); }
        }

        /// <summary>
        /// 当前值
        /// </summary>
        private int currentValue;

        [Description("进度条当前值"), Category("自定义")]
        public int CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; Refresh(); }
        }

        /// <summary>
        /// 最大值
        /// </summary>
        private int maxValue;
        [Browsable(true)]
        [Description("进度条最大值"), Category("自定义")]
        public int MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; Refresh(); }
        }

        public delegate void Btn(object sender, EventArgs e);
        private event Btn BtnClick;

        [Category("自定义事件")]
        private void Btn_Click(object sender, EventArgs e) 
        { 
            if(BtnClick!=null)
                BtnClick.Invoke(sender, e);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            float percent = CurrentValue / 100f;
            Rectangle rect = this.ClientRectangle;//获取客户端调用的实际宽度和高度,左上角位置为（0,0）
            rect.Width = (int)((float)rect.Width * percent);
            rect.Height = this.Height;
            g.FillRectangle(new SolidBrush(ForeColor), rect);
            g.DrawString(string.Format("{0}%", CurrentValue), new Font("宋体", 10),
                new SolidBrush(FontColor), new PointF(rect.X + ClientRectangle.Width / 2f - 10, rect.Y + ClientRectangle.Height / 2 - 5));
        }
    }
}
