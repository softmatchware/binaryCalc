namespace binary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            bool128 = new CheckBox();
            bool64 = new CheckBox();
            bool32 = new CheckBox();
            bool16 = new CheckBox();
            bool8 = new CheckBox();
            bool4 = new CheckBox();
            bool2 = new CheckBox();
            bool1 = new CheckBox();
            label9 = new Label();
            outputBits = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "128";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 9);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "64";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 9);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 2;
            label3.Text = "32";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 9);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "16";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 9);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 4;
            label5.Text = "8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 9);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 5;
            label6.Text = "4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 9);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 6;
            label7.Text = "2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 9);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 7;
            label8.Text = "1";
            // 
            // bool128
            // 
            bool128.AutoSize = true;
            bool128.Location = new Point(22, 27);
            bool128.Name = "bool128";
            bool128.Size = new Size(15, 14);
            bool128.TabIndex = 8;
            bool128.UseVisualStyleBackColor = true;
            bool128.CheckedChanged += bool128_CheckedChanged;
            // 
            // bool64
            // 
            bool64.AutoSize = true;
            bool64.Location = new Point(43, 27);
            bool64.Name = "bool64";
            bool64.Size = new Size(15, 14);
            bool64.TabIndex = 9;
            bool64.UseVisualStyleBackColor = true;
            bool64.CheckedChanged += bool64_CheckedChanged;
            // 
            // bool32
            // 
            bool32.AutoSize = true;
            bool32.Location = new Point(64, 27);
            bool32.Name = "bool32";
            bool32.Size = new Size(15, 14);
            bool32.TabIndex = 10;
            bool32.UseVisualStyleBackColor = true;
            bool32.CheckedChanged += bool32_CheckedChanged;
            // 
            // bool16
            // 
            bool16.AutoSize = true;
            bool16.Location = new Point(85, 27);
            bool16.Name = "bool16";
            bool16.Size = new Size(15, 14);
            bool16.TabIndex = 11;
            bool16.UseVisualStyleBackColor = true;
            bool16.CheckedChanged += bool16_CheckedChanged;
            // 
            // bool8
            // 
            bool8.AutoSize = true;
            bool8.Location = new Point(106, 27);
            bool8.Name = "bool8";
            bool8.Size = new Size(15, 14);
            bool8.TabIndex = 12;
            bool8.UseVisualStyleBackColor = true;
            bool8.CheckedChanged += bool8_CheckedChanged;
            // 
            // bool4
            // 
            bool4.AutoSize = true;
            bool4.Location = new Point(127, 27);
            bool4.Name = "bool4";
            bool4.Size = new Size(15, 14);
            bool4.TabIndex = 13;
            bool4.UseVisualStyleBackColor = true;
            bool4.CheckedChanged += bool4_CheckedChanged;
            // 
            // bool2
            // 
            bool2.AutoSize = true;
            bool2.Location = new Point(148, 27);
            bool2.Name = "bool2";
            bool2.Size = new Size(15, 14);
            bool2.TabIndex = 14;
            bool2.UseVisualStyleBackColor = true;
            bool2.CheckedChanged += bool2_CheckedChanged;
            // 
            // bool1
            // 
            bool1.AutoSize = true;
            bool1.Location = new Point(169, 27);
            bool1.Name = "bool1";
            bool1.Size = new Size(15, 14);
            bool1.TabIndex = 15;
            bool1.UseVisualStyleBackColor = true;
            bool1.CheckedChanged += bool1_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(188, 3);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 16;
            label9.Text = "output: ";
            // 
            // outputBits
            // 
            outputBits.BackColor = Color.LightCyan;
            outputBits.Cursor = Cursors.IBeam;
            outputBits.Location = new Point(188, 21);
            outputBits.MaxLength = 3;
            outputBits.Name = "outputBits";
            outputBits.ReadOnly = true;
            outputBits.Size = new Size(49, 23);
            outputBits.TabIndex = 17;
            outputBits.TextChanged += outputBits_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 56);
            Controls.Add(outputBits);
            Controls.Add(label9);
            Controls.Add(bool1);
            Controls.Add(bool2);
            Controls.Add(bool4);
            Controls.Add(bool8);
            Controls.Add(bool16);
            Controls.Add(bool32);
            Controls.Add(bool64);
            Controls.Add(bool128);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "binaryNumbers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox bool128;
        private CheckBox bool64;
        private CheckBox bool32;
        private CheckBox bool16;
        private CheckBox bool8;
        private CheckBox bool4;
        private CheckBox bool2;
        private CheckBox bool1;
        private Label label9;
        private TextBox outputBits;
    }
}
