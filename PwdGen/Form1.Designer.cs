namespace PwdGen
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
            this.numChars = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numPasswords = new System.Windows.Forms.NumericUpDown();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbSpecials = new System.Windows.Forms.CheckBox();
            this.cbDissimilar = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPasswords = new System.Windows.Forms.TextBox();
            this.llCopyToClipboard = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numChars
            // 
            this.numChars.Location = new System.Drawing.Point(277, 170);
            this.numChars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numChars.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numChars.Name = "numChars";
            this.numChars.Size = new System.Drawing.Size(156, 31);
            this.numChars.TabIndex = 0;
            this.numChars.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(40, 570);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(390, 50);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password lenght";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Letters (lowercase)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Letters (uppercase)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Punctuations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Remove ambigous";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number of passwords";
            // 
            // numPasswords
            // 
            this.numPasswords.Location = new System.Drawing.Point(277, 118);
            this.numPasswords.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPasswords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasswords.Name = "numPasswords";
            this.numPasswords.Size = new System.Drawing.Size(156, 31);
            this.numPasswords.TabIndex = 9;
            this.numPasswords.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbLowercase
            // 
            this.cbLowercase.AutoSize = true;
            this.cbLowercase.Checked = true;
            this.cbLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLowercase.Location = new System.Drawing.Point(250, 39);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.Size = new System.Drawing.Size(114, 29);
            this.cbLowercase.TabIndex = 10;
            this.cbLowercase.Text = "(abcdef...)";
            this.cbLowercase.UseVisualStyleBackColor = true;
            // 
            // cbUppercase
            // 
            this.cbUppercase.AutoSize = true;
            this.cbUppercase.Checked = true;
            this.cbUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUppercase.Location = new System.Drawing.Point(250, 80);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.Size = new System.Drawing.Size(124, 29);
            this.cbUppercase.TabIndex = 11;
            this.cbUppercase.Text = "(ABCDEF...)";
            this.cbUppercase.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Checked = true;
            this.cbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumbers.Location = new System.Drawing.Point(250, 120);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(120, 29);
            this.cbNumbers.TabIndex = 12;
            this.cbNumbers.Text = "(123456...)";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbSpecials
            // 
            this.cbSpecials.AutoSize = true;
            this.cbSpecials.Location = new System.Drawing.Point(250, 158);
            this.cbSpecials.Name = "cbSpecials";
            this.cbSpecials.Size = new System.Drawing.Size(93, 29);
            this.cbSpecials.TabIndex = 13;
            this.cbSpecials.Text = "(*,.;!?...)";
            this.cbSpecials.UseVisualStyleBackColor = true;
            // 
            // cbDissimilar
            // 
            this.cbDissimilar.AutoSize = true;
            this.cbDissimilar.Location = new System.Drawing.Point(250, 39);
            this.cbDissimilar.Name = "cbDissimilar";
            this.cbDissimilar.Size = new System.Drawing.Size(79, 29);
            this.cbDissimilar.TabIndex = 14;
            this.cbDissimilar.Text = "(1Il...)";
            this.cbDissimilar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 38);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password Generator";
            // 
            // tbPasswords
            // 
            this.tbPasswords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPasswords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPasswords.Location = new System.Drawing.Point(477, 118);
            this.tbPasswords.Multiline = true;
            this.tbPasswords.Name = "tbPasswords";
            this.tbPasswords.ReadOnly = true;
            this.tbPasswords.Size = new System.Drawing.Size(553, 502);
            this.tbPasswords.TabIndex = 16;
            // 
            // llCopyToClipboard
            // 
            this.llCopyToClipboard.AutoSize = true;
            this.llCopyToClipboard.Location = new System.Drawing.Point(674, 80);
            this.llCopyToClipboard.Name = "llCopyToClipboard";
            this.llCopyToClipboard.Size = new System.Drawing.Size(153, 25);
            this.llCopyToClipboard.TabIndex = 17;
            this.llCopyToClipboard.TabStop = true;
            this.llCopyToClipboard.Text = "copy to clipboard";
            this.llCopyToClipboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCopyToClipboard_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbLowercase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbSpecials);
            this.groupBox1.Controls.Add(this.cbUppercase);
            this.groupBox1.Controls.Add(this.cbNumbers);
            this.groupBox1.Location = new System.Drawing.Point(37, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 206);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character groups";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbDissimilar);
            this.groupBox2.Location = new System.Drawing.Point(37, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 82);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llCopyToClipboard);
            this.Controls.Add(this.tbPasswords);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numPasswords);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.numChars);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numChars;
        private Button btnGenerate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numPasswords;
        private CheckBox cbLowercase;
        private CheckBox cbUppercase;
        private CheckBox cbNumbers;
        private CheckBox cbSpecials;
        private CheckBox cbDissimilar;
        private Label label8;
        private TextBox tbPasswords;
        private LinkLabel llCopyToClipboard;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}