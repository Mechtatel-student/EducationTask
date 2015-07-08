namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.OpDiv = new System.Windows.Forms.Button();
            this.OpMul = new System.Windows.Forms.Button();
            this.OpAdd = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.OpSub = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.ClearNumberMemory = new System.Windows.Forms.Button();
            this.WriteMemory = new System.Windows.Forms.Button();
            this.AddMemory = new System.Windows.Forms.Button();
            this.SubMemory = new System.Windows.Forms.Button();
            this.ShowNumberMemory = new System.Windows.Forms.Button();
            this.ArrayMemory = new System.Windows.Forms.GroupBox();
            this.nm1 = new System.Windows.Forms.RadioButton();
            this.nm2 = new System.Windows.Forms.RadioButton();
            this.nm3 = new System.Windows.Forms.RadioButton();
            this.nm4 = new System.Windows.Forms.RadioButton();
            this.nm5 = new System.Windows.Forms.RadioButton();
            this.ArrayMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(18, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(388, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(18, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(388, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Number1
            // 
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number1.Location = new System.Drawing.Point(154, 118);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(30, 29);
            this.Number1.TabIndex = 3;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number2.Location = new System.Drawing.Point(190, 118);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(30, 29);
            this.Number2.TabIndex = 4;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Number2_Click);
            // 
            // Number3
            // 
            this.Number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number3.Location = new System.Drawing.Point(226, 118);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(30, 29);
            this.Number3.TabIndex = 5;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Number3_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.Location = new System.Drawing.Point(118, 188);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(30, 29);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // OpDiv
            // 
            this.OpDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpDiv.Location = new System.Drawing.Point(54, 153);
            this.OpDiv.Name = "OpDiv";
            this.OpDiv.Size = new System.Drawing.Size(30, 29);
            this.OpDiv.TabIndex = 7;
            this.OpDiv.Text = "/";
            this.OpDiv.UseVisualStyleBackColor = true;
            this.OpDiv.Click += new System.EventHandler(this.OpDiv_Click);
            // 
            // OpMul
            // 
            this.OpMul.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpMul.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OpMul.Location = new System.Drawing.Point(18, 153);
            this.OpMul.Name = "OpMul";
            this.OpMul.Size = new System.Drawing.Size(30, 29);
            this.OpMul.TabIndex = 8;
            this.OpMul.TabStop = false;
            this.OpMul.Text = "*";
            this.OpMul.UseVisualStyleBackColor = true;
            this.OpMul.Click += new System.EventHandler(this.OpMul_Click);
            // 
            // OpAdd
            // 
            this.OpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OpAdd.Location = new System.Drawing.Point(19, 118);
            this.OpAdd.Name = "OpAdd";
            this.OpAdd.Size = new System.Drawing.Size(30, 29);
            this.OpAdd.TabIndex = 9;
            this.OpAdd.Text = "+";
            this.OpAdd.UseVisualStyleBackColor = true;
            this.OpAdd.Click += new System.EventHandler(this.OpAdd_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equal.Location = new System.Drawing.Point(18, 188);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(66, 29);
            this.Equal.TabIndex = 10;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(3, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(404, 20);
            this.textBox3.TabIndex = 11;
            // 
            // Number4
            // 
            this.Number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number4.Location = new System.Drawing.Point(154, 153);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(30, 29);
            this.Number4.TabIndex = 12;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // Number5
            // 
            this.Number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number5.Location = new System.Drawing.Point(190, 153);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(30, 29);
            this.Number5.TabIndex = 13;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Number5_Click);
            // 
            // Number6
            // 
            this.Number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number6.Location = new System.Drawing.Point(226, 153);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(30, 29);
            this.Number6.TabIndex = 14;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Number6_Click);
            // 
            // Number9
            // 
            this.Number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number9.Location = new System.Drawing.Point(226, 188);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(30, 29);
            this.Number9.TabIndex = 15;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Number9_Click);
            // 
            // Number8
            // 
            this.Number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number8.Location = new System.Drawing.Point(190, 188);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(30, 29);
            this.Number8.TabIndex = 16;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Number8_Click);
            // 
            // Number7
            // 
            this.Number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number7.Location = new System.Drawing.Point(154, 188);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(30, 29);
            this.Number7.TabIndex = 17;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Number7_Click);
            // 
            // Number0
            // 
            this.Number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number0.Location = new System.Drawing.Point(118, 118);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(30, 29);
            this.Number0.TabIndex = 18;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Number0_Click);
            // 
            // OpSub
            // 
            this.OpSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpSub.Location = new System.Drawing.Point(55, 118);
            this.OpSub.Name = "OpSub";
            this.OpSub.Size = new System.Drawing.Size(30, 29);
            this.OpSub.TabIndex = 19;
            this.OpSub.Text = "-";
            this.OpSub.UseVisualStyleBackColor = true;
            this.OpSub.Click += new System.EventHandler(this.OpSub_Click);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point.Location = new System.Drawing.Point(118, 153);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(30, 29);
            this.Point.TabIndex = 21;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // ClearNumberMemory
            // 
            this.ClearNumberMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearNumberMemory.Location = new System.Drawing.Point(330, 151);
            this.ClearNumberMemory.Name = "ClearNumberMemory";
            this.ClearNumberMemory.Size = new System.Drawing.Size(47, 29);
            this.ClearNumberMemory.TabIndex = 22;
            this.ClearNumberMemory.Text = "MC";
            this.ClearNumberMemory.UseVisualStyleBackColor = true;
            this.ClearNumberMemory.Click += new System.EventHandler(this.ClearNumberMemory_Click);
            // 
            // WriteMemory
            // 
            this.WriteMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteMemory.Location = new System.Drawing.Point(276, 116);
            this.WriteMemory.Name = "WriteMemory";
            this.WriteMemory.Size = new System.Drawing.Size(30, 29);
            this.WriteMemory.TabIndex = 23;
            this.WriteMemory.Text = "M";
            this.WriteMemory.UseVisualStyleBackColor = true;
            this.WriteMemory.Click += new System.EventHandler(this.WriteMemory_Click);
            // 
            // AddMemory
            // 
            this.AddMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMemory.Location = new System.Drawing.Point(312, 116);
            this.AddMemory.Name = "AddMemory";
            this.AddMemory.Size = new System.Drawing.Size(42, 29);
            this.AddMemory.TabIndex = 24;
            this.AddMemory.Text = "M+";
            this.AddMemory.UseVisualStyleBackColor = true;
            this.AddMemory.Click += new System.EventHandler(this.AddMemory_Click);
            // 
            // SubMemory
            // 
            this.SubMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubMemory.Location = new System.Drawing.Point(360, 116);
            this.SubMemory.Name = "SubMemory";
            this.SubMemory.Size = new System.Drawing.Size(42, 29);
            this.SubMemory.TabIndex = 25;
            this.SubMemory.Text = "M-";
            this.SubMemory.UseVisualStyleBackColor = true;
            this.SubMemory.Click += new System.EventHandler(this.SubMemory_Click);
            // 
            // ShowNumberMemory
            // 
            this.ShowNumberMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowNumberMemory.Location = new System.Drawing.Point(276, 151);
            this.ShowNumberMemory.Name = "ShowNumberMemory";
            this.ShowNumberMemory.Size = new System.Drawing.Size(48, 29);
            this.ShowNumberMemory.TabIndex = 26;
            this.ShowNumberMemory.Text = "MS";
            this.ShowNumberMemory.UseVisualStyleBackColor = true;
            this.ShowNumberMemory.Click += new System.EventHandler(this.ShowNumberMemory_Click);
            // 
            // ArrayMemory
            // 
            this.ArrayMemory.AutoSize = true;
            this.ArrayMemory.Controls.Add(this.nm5);
            this.ArrayMemory.Controls.Add(this.nm4);
            this.ArrayMemory.Controls.Add(this.nm3);
            this.ArrayMemory.Controls.Add(this.nm2);
            this.ArrayMemory.Controls.Add(this.nm1);
            this.ArrayMemory.Location = new System.Drawing.Point(423, 116);
            this.ArrayMemory.Name = "ArrayMemory";
            this.ArrayMemory.Size = new System.Drawing.Size(152, 123);
            this.ArrayMemory.TabIndex = 27;
            this.ArrayMemory.TabStop = false;
            // 
            // nm1
            // 
            this.nm1.AutoSize = true;
            this.nm1.Checked = true;
            this.nm1.Location = new System.Drawing.Point(6, 14);
            this.nm1.Name = "nm1";
            this.nm1.Size = new System.Drawing.Size(14, 13);
            this.nm1.TabIndex = 0;
            this.nm1.TabStop = true;
            this.nm1.UseVisualStyleBackColor = true;
            this.nm1.CheckedChanged += new System.EventHandler(this.nm1_CheckedChanged);
            // 
            // nm2
            // 
            this.nm2.AutoSize = true;
            this.nm2.Location = new System.Drawing.Point(6, 33);
            this.nm2.Name = "nm2";
            this.nm2.Size = new System.Drawing.Size(14, 13);
            this.nm2.TabIndex = 1;
            this.nm2.TabStop = true;
            this.nm2.UseVisualStyleBackColor = true;
            this.nm2.CheckedChanged += new System.EventHandler(this.nm2_CheckedChanged);
            // 
            // nm3
            // 
            this.nm3.AutoSize = true;
            this.nm3.Location = new System.Drawing.Point(6, 53);
            this.nm3.Name = "nm3";
            this.nm3.Size = new System.Drawing.Size(14, 13);
            this.nm3.TabIndex = 2;
            this.nm3.UseVisualStyleBackColor = true;
            this.nm3.CheckedChanged += new System.EventHandler(this.nm3_CheckedChanged_1);
            // 
            // nm4
            // 
            this.nm4.AutoSize = true;
            this.nm4.Location = new System.Drawing.Point(6, 72);
            this.nm4.Name = "nm4";
            this.nm4.Size = new System.Drawing.Size(14, 13);
            this.nm4.TabIndex = 3;
            this.nm4.UseVisualStyleBackColor = true;
            this.nm4.CheckedChanged += new System.EventHandler(this.nm4_CheckedChanged_1);
            // 
            // nm5
            // 
            this.nm5.AutoSize = true;
            this.nm5.Location = new System.Drawing.Point(6, 91);
            this.nm5.Name = "nm5";
            this.nm5.Size = new System.Drawing.Size(14, 13);
            this.nm5.TabIndex = 4;
            this.nm5.UseVisualStyleBackColor = true;
            this.nm5.CheckedChanged += new System.EventHandler(this.nm5_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(587, 261);
            this.Controls.Add(this.ArrayMemory);
            this.Controls.Add(this.ShowNumberMemory);
            this.Controls.Add(this.SubMemory);
            this.Controls.Add(this.AddMemory);
            this.Controls.Add(this.WriteMemory);
            this.Controls.Add(this.ClearNumberMemory);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.OpSub);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.OpAdd);
            this.Controls.Add(this.OpMul);
            this.Controls.Add(this.OpDiv);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ArrayMemory.ResumeLayout(false);
            this.ArrayMemory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button OpDiv;
        private System.Windows.Forms.Button OpMul;
        private System.Windows.Forms.Button OpAdd;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button OpSub;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button ClearNumberMemory;
        private System.Windows.Forms.Button WriteMemory;
        private System.Windows.Forms.Button AddMemory;
        private System.Windows.Forms.Button SubMemory;
        private System.Windows.Forms.Button ShowNumberMemory;
        private System.Windows.Forms.GroupBox ArrayMemory;
        private System.Windows.Forms.RadioButton nm5;
        private System.Windows.Forms.RadioButton nm4;
        private System.Windows.Forms.RadioButton nm3;
        private System.Windows.Forms.RadioButton nm2;
        private System.Windows.Forms.RadioButton nm1;
    }
}

