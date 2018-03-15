namespace Spell_Roller_App_DandD
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
            this.txt_Choice1 = new System.Windows.Forms.TextBox();
            this.txt_Choice2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_Cantrips = new System.Windows.Forms.RadioButton();
            this.rdb_One = new System.Windows.Forms.RadioButton();
            this.rdb_Two = new System.Windows.Forms.RadioButton();
            this.rdb_Three = new System.Windows.Forms.RadioButton();
            this.rdb_Four = new System.Windows.Forms.RadioButton();
            this.rdb_Five = new System.Windows.Forms.RadioButton();
            this.rdb_Six = new System.Windows.Forms.RadioButton();
            this.rdb_Seven = new System.Windows.Forms.RadioButton();
            this.rdb_Eight = new System.Windows.Forms.RadioButton();
            this.rdb_Nine = new System.Windows.Forms.RadioButton();
            this.btn_Roll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Choice1
            // 
            this.txt_Choice1.Enabled = false;
            this.txt_Choice1.Location = new System.Drawing.Point(328, 46);
            this.txt_Choice1.Name = "txt_Choice1";
            this.txt_Choice1.Size = new System.Drawing.Size(297, 20);
            this.txt_Choice1.TabIndex = 0;
            // 
            // txt_Choice2
            // 
            this.txt_Choice2.Enabled = false;
            this.txt_Choice2.Location = new System.Drawing.Point(328, 89);
            this.txt_Choice2.Name = "txt_Choice2";
            this.txt_Choice2.Size = new System.Drawing.Size(296, 20);
            this.txt_Choice2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Choice";
            // 
            // rdb_Cantrips
            // 
            this.rdb_Cantrips.AutoSize = true;
            this.rdb_Cantrips.Location = new System.Drawing.Point(13, 47);
            this.rdb_Cantrips.Name = "rdb_Cantrips";
            this.rdb_Cantrips.Size = new System.Drawing.Size(63, 17);
            this.rdb_Cantrips.TabIndex = 4;
            this.rdb_Cantrips.TabStop = true;
            this.rdb_Cantrips.Text = "Cantrips";
            this.rdb_Cantrips.UseVisualStyleBackColor = true;
            this.rdb_Cantrips.CheckedChanged += new System.EventHandler(this.rdb_Cantrips_CheckedChanged);
            // 
            // rdb_One
            // 
            this.rdb_One.AutoSize = true;
            this.rdb_One.Location = new System.Drawing.Point(13, 71);
            this.rdb_One.Name = "rdb_One";
            this.rdb_One.Size = new System.Drawing.Size(73, 17);
            this.rdb_One.TabIndex = 5;
            this.rdb_One.TabStop = true;
            this.rdb_One.Text = "First Level";
            this.rdb_One.UseVisualStyleBackColor = true;
            this.rdb_One.CheckedChanged += new System.EventHandler(this.rdb_One_CheckedChanged);
            // 
            // rdb_Two
            // 
            this.rdb_Two.AutoSize = true;
            this.rdb_Two.Location = new System.Drawing.Point(13, 94);
            this.rdb_Two.Name = "rdb_Two";
            this.rdb_Two.Size = new System.Drawing.Size(91, 17);
            this.rdb_Two.TabIndex = 6;
            this.rdb_Two.TabStop = true;
            this.rdb_Two.Text = "Second Level";
            this.rdb_Two.UseVisualStyleBackColor = true;
            this.rdb_Two.CheckedChanged += new System.EventHandler(this.rdb_Two_CheckedChanged);
            // 
            // rdb_Three
            // 
            this.rdb_Three.AutoSize = true;
            this.rdb_Three.Location = new System.Drawing.Point(13, 118);
            this.rdb_Three.Name = "rdb_Three";
            this.rdb_Three.Size = new System.Drawing.Size(78, 17);
            this.rdb_Three.TabIndex = 7;
            this.rdb_Three.TabStop = true;
            this.rdb_Three.Text = "Third Level";
            this.rdb_Three.UseVisualStyleBackColor = true;
            this.rdb_Three.CheckedChanged += new System.EventHandler(this.rdb_Three_CheckedChanged);
            // 
            // rdb_Four
            // 
            this.rdb_Four.AutoSize = true;
            this.rdb_Four.Location = new System.Drawing.Point(13, 142);
            this.rdb_Four.Name = "rdb_Four";
            this.rdb_Four.Size = new System.Drawing.Size(84, 17);
            this.rdb_Four.TabIndex = 8;
            this.rdb_Four.TabStop = true;
            this.rdb_Four.Text = "Fourth Level";
            this.rdb_Four.UseVisualStyleBackColor = true;
            this.rdb_Four.CheckedChanged += new System.EventHandler(this.rdb_Four_CheckedChanged);
            // 
            // rdb_Five
            // 
            this.rdb_Five.AutoSize = true;
            this.rdb_Five.Location = new System.Drawing.Point(131, 47);
            this.rdb_Five.Name = "rdb_Five";
            this.rdb_Five.Size = new System.Drawing.Size(74, 17);
            this.rdb_Five.TabIndex = 9;
            this.rdb_Five.TabStop = true;
            this.rdb_Five.Text = "Fifth Level";
            this.rdb_Five.UseVisualStyleBackColor = true;
            this.rdb_Five.CheckedChanged += new System.EventHandler(this.rdb_Five_CheckedChanged);
            // 
            // rdb_Six
            // 
            this.rdb_Six.AutoSize = true;
            this.rdb_Six.Location = new System.Drawing.Point(131, 71);
            this.rdb_Six.Name = "rdb_Six";
            this.rdb_Six.Size = new System.Drawing.Size(77, 17);
            this.rdb_Six.TabIndex = 10;
            this.rdb_Six.TabStop = true;
            this.rdb_Six.Text = "Sixth Level";
            this.rdb_Six.UseVisualStyleBackColor = true;
            this.rdb_Six.CheckedChanged += new System.EventHandler(this.rdb_Six_CheckedChanged);
            // 
            // rdb_Seven
            // 
            this.rdb_Seven.AutoSize = true;
            this.rdb_Seven.Location = new System.Drawing.Point(131, 94);
            this.rdb_Seven.Name = "rdb_Seven";
            this.rdb_Seven.Size = new System.Drawing.Size(94, 17);
            this.rdb_Seven.TabIndex = 11;
            this.rdb_Seven.TabStop = true;
            this.rdb_Seven.Text = "Seventh Level";
            this.rdb_Seven.UseVisualStyleBackColor = true;
            this.rdb_Seven.CheckedChanged += new System.EventHandler(this.rdb_Seven_CheckedChanged);
            // 
            // rdb_Eight
            // 
            this.rdb_Eight.AutoSize = true;
            this.rdb_Eight.Location = new System.Drawing.Point(131, 118);
            this.rdb_Eight.Name = "rdb_Eight";
            this.rdb_Eight.Size = new System.Drawing.Size(84, 17);
            this.rdb_Eight.TabIndex = 12;
            this.rdb_Eight.TabStop = true;
            this.rdb_Eight.Text = "Eighth Level";
            this.rdb_Eight.UseVisualStyleBackColor = true;
            this.rdb_Eight.CheckedChanged += new System.EventHandler(this.rdb_Eight_CheckedChanged);
            // 
            // rdb_Nine
            // 
            this.rdb_Nine.AutoSize = true;
            this.rdb_Nine.Location = new System.Drawing.Point(131, 142);
            this.rdb_Nine.Name = "rdb_Nine";
            this.rdb_Nine.Size = new System.Drawing.Size(79, 17);
            this.rdb_Nine.TabIndex = 13;
            this.rdb_Nine.TabStop = true;
            this.rdb_Nine.Text = "Ninth Level";
            this.rdb_Nine.UseVisualStyleBackColor = true;
            this.rdb_Nine.CheckedChanged += new System.EventHandler(this.rdb_Nine_CheckedChanged);
            // 
            // btn_Roll
            // 
            this.btn_Roll.Location = new System.Drawing.Point(371, 125);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(193, 69);
            this.btn_Roll.TabIndex = 14;
            this.btn_Roll.Text = "Roll";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 233);
            this.Controls.Add(this.btn_Roll);
            this.Controls.Add(this.rdb_Nine);
            this.Controls.Add(this.rdb_Eight);
            this.Controls.Add(this.rdb_Seven);
            this.Controls.Add(this.rdb_Six);
            this.Controls.Add(this.rdb_Five);
            this.Controls.Add(this.rdb_Four);
            this.Controls.Add(this.rdb_Three);
            this.Controls.Add(this.rdb_Two);
            this.Controls.Add(this.rdb_One);
            this.Controls.Add(this.rdb_Cantrips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Choice2);
            this.Controls.Add(this.txt_Choice1);
            this.Name = "Form1";
            this.Text = "Spell Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Choice1;
        private System.Windows.Forms.TextBox txt_Choice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_Cantrips;
        private System.Windows.Forms.RadioButton rdb_One;
        private System.Windows.Forms.RadioButton rdb_Two;
        private System.Windows.Forms.RadioButton rdb_Three;
        private System.Windows.Forms.RadioButton rdb_Four;
        private System.Windows.Forms.RadioButton rdb_Five;
        private System.Windows.Forms.RadioButton rdb_Six;
        private System.Windows.Forms.RadioButton rdb_Seven;
        private System.Windows.Forms.RadioButton rdb_Eight;
        private System.Windows.Forms.RadioButton rdb_Nine;
        private System.Windows.Forms.Button btn_Roll;
    }
}

