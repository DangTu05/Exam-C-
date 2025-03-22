namespace Test
{
    partial class Form2
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
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.Nghiem = new System.Windows.Forms.Label();
            this.KQ = new System.Windows.Forms.FlowLayoutPanel();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(117, 44);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownA.TabIndex = 0;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(335, 44);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownB.TabIndex = 1;
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(564, 46);
            this.numericUpDownC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownC.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.value2);
            this.panel1.Controls.Add(this.value1);
            this.panel1.Controls.Add(this.x2);
            this.panel1.Controls.Add(this.x1);
            this.panel1.Location = new System.Drawing.Point(489, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 107);
            this.panel1.TabIndex = 3;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(48, 63);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(100, 22);
            this.value2.TabIndex = 3;
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(47, 23);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(100, 22);
            this.value1.TabIndex = 2;
            this.value1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(14, 63);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(27, 16);
            this.x2.TabIndex = 1;
            this.x2.Text = "x2=";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(14, 26);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(27, 16);
            this.x1.TabIndex = 0;
            this.x1.Text = "x1=";
            // 
            // Nghiem
            // 
            this.Nghiem.AutoSize = true;
            this.Nghiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Nghiem.Location = new System.Drawing.Point(517, 155);
            this.Nghiem.Name = "Nghiem";
            this.Nghiem.Size = new System.Drawing.Size(54, 16);
            this.Nghiem.TabIndex = 4;
            this.Nghiem.Text = "Nghiệm";
            // 
            // KQ
            // 
            this.KQ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.KQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KQ.Location = new System.Drawing.Point(101, 165);
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(200, 107);
            this.KQ.TabIndex = 5;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(75, 46);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(15, 16);
            this.a.TabIndex = 6;
            this.a.Text = "a";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(286, 46);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(15, 16);
            this.b.TabIndex = 7;
            this.b.Text = "b";
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(517, 46);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(14, 16);
            this.c.TabIndex = 8;
            this.c.Text = "c";
            this.c.Click += new System.EventHandler(this.label2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(456, 373);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(161, 373);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 10;
            this.Run.Text = "Giải PT";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.Nghiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nghiem;
        private System.Windows.Forms.FlowLayoutPanel KQ;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Button Run;
    }
}