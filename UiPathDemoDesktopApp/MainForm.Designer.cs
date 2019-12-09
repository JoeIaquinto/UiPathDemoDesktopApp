namespace UiPathDemoDesktopApp
{
    partial class MainForm
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
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.MaskedTextBox();
            this.cpwBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spamBox = new System.Windows.Forms.CheckBox();
            this.tosBox = new System.Windows.Forms.CheckBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.randomizer = new System.Windows.Forms.Button();
            this.dobPicker = new System.Windows.Forms.TextBox();
            this.easybutton = new System.Windows.Forms.RadioButton();
            this.mediumbutton = new System.Windows.Forms.RadioButton();
            this.hardbutton = new System.Windows.Forms.RadioButton();
            this.favNumBox = new System.Windows.Forms.TextBox();
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(115, 16);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(208, 23);
            this.fnameBox.TabIndex = 0;
            this.fnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(115, 45);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(208, 23);
            this.lnameBox.TabIndex = 0;
            this.lnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(-184, -66);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(115, 74);
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(208, 23);
            this.pwBox.TabIndex = 4;
            this.pwBox.UseSystemPasswordChar = true;
            // 
            // cpwBox
            // 
            this.cpwBox.Location = new System.Drawing.Point(115, 103);
            this.cpwBox.Name = "cpwBox";
            this.cpwBox.Size = new System.Drawing.Size(208, 23);
            this.cpwBox.TabIndex = 4;
            this.cpwBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Favorite Number";
            // 
            // spamBox
            // 
            this.spamBox.AutoSize = true;
            this.spamBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spamBox.Checked = true;
            this.spamBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spamBox.Location = new System.Drawing.Point(79, 190);
            this.spamBox.Name = "spamBox";
            this.spamBox.Size = new System.Drawing.Size(244, 19);
            this.spamBox.TabIndex = 10;
            this.spamBox.Text = "Would you like to subscribe to our spam?";
            this.spamBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.spamBox.UseVisualStyleBackColor = true;
            // 
            // tosBox
            // 
            this.tosBox.AutoSize = true;
            this.tosBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tosBox.Location = new System.Drawing.Point(110, 215);
            this.tosBox.Name = "tosBox";
            this.tosBox.Size = new System.Drawing.Size(213, 19);
            this.tosBox.TabIndex = 10;
            this.tosBox.Text = "Do you accept the terms of service?";
            this.tosBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tosBox.UseVisualStyleBackColor = true;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(248, 240);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 11;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // randomizer
            // 
            this.randomizer.ForeColor = System.Drawing.Color.Red;
            this.randomizer.Location = new System.Drawing.Point(15, 293);
            this.randomizer.Name = "randomizer";
            this.randomizer.Size = new System.Drawing.Size(85, 23);
            this.randomizer.TabIndex = 12;
            this.randomizer.Text = "Randomize!";
            this.randomizer.UseVisualStyleBackColor = true;
            this.randomizer.Click += new System.EventHandler(this.randomizer_Click);
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(115, 132);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(208, 23);
            this.dobPicker.TabIndex = 0;
            this.dobPicker.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // easybutton
            // 
            this.easybutton.AutoSize = true;
            this.easybutton.Location = new System.Drawing.Point(15, 215);
            this.easybutton.Name = "easybutton";
            this.easybutton.Size = new System.Drawing.Size(48, 19);
            this.easybutton.TabIndex = 13;
            this.easybutton.TabStop = true;
            this.easybutton.Text = "Easy";
            this.easybutton.UseVisualStyleBackColor = true;
            this.easybutton.CheckedChanged += new System.EventHandler(this.easybutton_CheckedChanged);

            // 
            // mediumbutton
            // 
            this.mediumbutton.AutoSize = true;
            this.mediumbutton.Location = new System.Drawing.Point(15, 240);
            this.mediumbutton.Name = "mediumbutton";
            this.mediumbutton.Size = new System.Drawing.Size(70, 19);
            this.mediumbutton.TabIndex = 13;
            this.mediumbutton.TabStop = true;
            this.mediumbutton.Text = "Medium";
            this.mediumbutton.UseVisualStyleBackColor = true;
            this.mediumbutton.CheckedChanged += new System.EventHandler(this.mediumbutton_CheckedChanged);
            // 
            // hardbutton
            // 
            this.hardbutton.AutoSize = true;
            this.hardbutton.Location = new System.Drawing.Point(15, 265);
            this.hardbutton.Name = "hardbutton";
            this.hardbutton.Size = new System.Drawing.Size(51, 19);
            this.hardbutton.TabIndex = 13;
            this.hardbutton.TabStop = true;
            this.hardbutton.Text = "Hard";
            this.hardbutton.UseVisualStyleBackColor = true;
            this.hardbutton.CheckedChanged += new System.EventHandler(this.hardbutton_CheckedChanged);
            // 
            // favNumBox
            // 
            this.favNumBox.Location = new System.Drawing.Point(115, 164);
            this.favNumBox.Name = "favNumBox";
            this.favNumBox.Size = new System.Drawing.Size(208, 23);
            this.favNumBox.TabIndex = 0;
            this.favNumBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 324);
            this.Controls.Add(this.easybutton);
            this.Controls.Add(this.randomizer);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.spamBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.cpwBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tosBox);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.mediumbutton);
            this.Controls.Add(this.hardbutton);
            this.Controls.Add(this.favNumBox);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);

        }

        #endregion

        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox pwBox;
        private System.Windows.Forms.MaskedTextBox cpwBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox spamBox;
        private System.Windows.Forms.CheckBox tosBox;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button randomizer;
        private System.Windows.Forms.TextBox dobPicker;
        private System.Windows.Forms.TextBox favNum;
        private System.Windows.Forms.RadioButton easybutton;
        private System.Windows.Forms.RadioButton mediumbutton;
        private System.Windows.Forms.RadioButton hardbutton;
        private System.Windows.Forms.TextBox favNumBox;
    }
}

