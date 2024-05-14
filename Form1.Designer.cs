namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_a = new System.Windows.Forms.TextBox();
            this.textbox_b = new System.Windows.Forms.TextBox();
            this.textbox_c = new System.Windows.Forms.TextBox();
            this.nud_a = new System.Windows.Forms.NumericUpDown();
            this.nud_b = new System.Windows.Forms.NumericUpDown();
            this.nud_c = new System.Windows.Forms.NumericUpDown();
            this.trackbar_a = new System.Windows.Forms.TrackBar();
            this.trackbar_b = new System.Windows.Forms.TrackBar();
            this.trackbar_c = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_c)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_a
            // 
            this.textbox_a.Location = new System.Drawing.Point(46, 188);
            this.textbox_a.Name = "textbox_a";
            this.textbox_a.Size = new System.Drawing.Size(215, 26);
            this.textbox_a.TabIndex = 0;
            this.textbox_a.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.textbox_a.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textbox_b_MouseDown);
            // 
            // textbox_b
            // 
            this.textbox_b.Location = new System.Drawing.Point(397, 188);
            this.textbox_b.Name = "textbox_b";
            this.textbox_b.Size = new System.Drawing.Size(215, 26);
            this.textbox_b.TabIndex = 1;
            this.textbox_b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.textbox_b.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textbox_b_MouseDown);
            // 
            // textbox_c
            // 
            this.textbox_c.Location = new System.Drawing.Point(714, 188);
            this.textbox_c.Name = "textbox_c";
            this.textbox_c.Size = new System.Drawing.Size(215, 26);
            this.textbox_c.TabIndex = 2;
            this.textbox_c.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.textbox_c.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textbox_b_MouseDown);
            // 
            // nud_a
            // 
            this.nud_a.Location = new System.Drawing.Point(46, 269);
            this.nud_a.Name = "nud_a";
            this.nud_a.ReadOnly = true;
            this.nud_a.Size = new System.Drawing.Size(215, 26);
            this.nud_a.TabIndex = 3;
            this.nud_a.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nud_b
            // 
            this.nud_b.Location = new System.Drawing.Point(397, 269);
            this.nud_b.Name = "nud_b";
            this.nud_b.ReadOnly = true;
            this.nud_b.Size = new System.Drawing.Size(215, 26);
            this.nud_b.TabIndex = 4;
            this.nud_b.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nud_c
            // 
            this.nud_c.Location = new System.Drawing.Point(714, 269);
            this.nud_c.Name = "nud_c";
            this.nud_c.ReadOnly = true;
            this.nud_c.Size = new System.Drawing.Size(215, 26);
            this.nud_c.TabIndex = 5;
            this.nud_c.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // trackbar_a
            // 
            this.trackbar_a.Location = new System.Drawing.Point(46, 360);
            this.trackbar_a.Maximum = 100;
            this.trackbar_a.Name = "trackbar_a";
            this.trackbar_a.Size = new System.Drawing.Size(215, 69);
            this.trackbar_a.TabIndex = 6;
            this.trackbar_a.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // trackbar_b
            // 
            this.trackbar_b.Location = new System.Drawing.Point(397, 360);
            this.trackbar_b.Maximum = 100;
            this.trackbar_b.Name = "trackbar_b";
            this.trackbar_b.Size = new System.Drawing.Size(215, 69);
            this.trackbar_b.TabIndex = 7;
            this.trackbar_b.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // trackbar_c
            // 
            this.trackbar_c.Location = new System.Drawing.Point(714, 360);
            this.trackbar_c.Maximum = 100;
            this.trackbar_c.Name = "trackbar_c";
            this.trackbar_c.Size = new System.Drawing.Size(215, 69);
            this.trackbar_c.TabIndex = 8;
            this.trackbar_c.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(213, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 100);
            this.label1.TabIndex = 9;
            this.label1.Text = "A <= B <= C\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackbar_c);
            this.Controls.Add(this.trackbar_b);
            this.Controls.Add(this.trackbar_a);
            this.Controls.Add(this.nud_c);
            this.Controls.Add(this.nud_b);
            this.Controls.Add(this.nud_a);
            this.Controls.Add(this.textbox_c);
            this.Controls.Add(this.textbox_b);
            this.Controls.Add(this.textbox_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_a;
        private System.Windows.Forms.TextBox textbox_b;
        private System.Windows.Forms.TextBox textbox_c;
        private System.Windows.Forms.NumericUpDown nud_a;
        private System.Windows.Forms.NumericUpDown nud_b;
        private System.Windows.Forms.NumericUpDown nud_c;
        private System.Windows.Forms.TrackBar trackbar_a;
        private System.Windows.Forms.TrackBar trackbar_b;
        private System.Windows.Forms.TrackBar trackbar_c;
        private System.Windows.Forms.Label label1;
    }
}

