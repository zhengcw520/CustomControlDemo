namespace TestControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarControl1 = new CustomControlDemo.ProgressBarControl();
            this.timer1 = new System.Windows.Forms.Timer();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.roundButton1 = new CustomControlDemo.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.BackColor = System.Drawing.Color.White;
            this.progressBarControl1.CurrentValue = 50;
            this.progressBarControl1.FontColor = System.Drawing.Color.Empty;
            this.progressBarControl1.Location = new System.Drawing.Point(86, 306);
            this.progressBarControl1.MaxValue = 100;
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(601, 34);
            this.progressBarControl1.TabIndex = 0;
            this.progressBarControl1.Text = "progressBarControl1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(86, 138);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(126, 24);
            this.textEdit1.TabIndex = 1;
            // 
            // roundButton1
            // 
            this.roundButton1.ControlState = CustomControlDemo.ControlState.Normal;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(86, 192);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Radius = 20;
            this.roundButton1.Size = new System.Drawing.Size(373, 39);
            this.roundButton1.TabIndex = 3;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 407);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.progressBarControl1);
            this.Name = "Form1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlDemo.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private CustomControlDemo.RoundButton roundButton1;

    }
}