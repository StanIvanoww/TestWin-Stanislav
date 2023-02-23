namespace TestWin_Stanislav
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.autortxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameofbooktxtbtn = new System.Windows.Forms.TextBox();
            this.spravradiobtn = new System.Windows.Forms.RadioButton();
            this.nauchradiobtn = new System.Windows.Forms.RadioButton();
            this.hydradiobtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.softcheckbtn = new System.Windows.Forms.CheckBox();
            this.hardcheckbx = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.izdcombobx = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookShop";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(232, 337);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(139, 51);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Въведи автор";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // autortxtbox
            // 
            this.autortxtbox.Location = new System.Drawing.Point(20, 41);
            this.autortxtbox.Name = "autortxtbox";
            this.autortxtbox.Size = new System.Drawing.Size(131, 22);
            this.autortxtbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Въведи името на книгата";
            // 
            // nameofbooktxtbtn
            // 
            this.nameofbooktxtbtn.Location = new System.Drawing.Point(20, 95);
            this.nameofbooktxtbtn.Name = "nameofbooktxtbtn";
            this.nameofbooktxtbtn.Size = new System.Drawing.Size(135, 22);
            this.nameofbooktxtbtn.TabIndex = 6;
            // 
            // spravradiobtn
            // 
            this.spravradiobtn.AutoSize = true;
            this.spravradiobtn.Location = new System.Drawing.Point(14, 28);
            this.spravradiobtn.Name = "spravradiobtn";
            this.spravradiobtn.Size = new System.Drawing.Size(101, 20);
            this.spravradiobtn.TabIndex = 7;
            this.spravradiobtn.TabStop = true;
            this.spravradiobtn.Text = "Справочна";
            this.spravradiobtn.UseVisualStyleBackColor = true;
            // 
            // nauchradiobtn
            // 
            this.nauchradiobtn.AutoSize = true;
            this.nauchradiobtn.Location = new System.Drawing.Point(14, 62);
            this.nauchradiobtn.Name = "nauchradiobtn";
            this.nauchradiobtn.Size = new System.Drawing.Size(153, 20);
            this.nauchradiobtn.TabIndex = 8;
            this.nauchradiobtn.TabStop = true;
            this.nauchradiobtn.Text = "Научно-популярна";
            this.nauchradiobtn.UseVisualStyleBackColor = true;
            // 
            // hydradiobtn
            // 
            this.hydradiobtn.AutoSize = true;
            this.hydradiobtn.Location = new System.Drawing.Point(14, 97);
            this.hydradiobtn.Name = "hydradiobtn";
            this.hydradiobtn.Size = new System.Drawing.Size(123, 20);
            this.hydradiobtn.TabIndex = 9;
            this.hydradiobtn.TabStop = true;
            this.hydradiobtn.Text = "Художествена";
            this.hydradiobtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Жанр";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hydradiobtn);
            this.groupBox1.Controls.Add(this.nauchradiobtn);
            this.groupBox1.Controls.Add(this.spravradiobtn);
            this.groupBox1.Location = new System.Drawing.Point(330, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameofbooktxtbtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.autortxtbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(96, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 138);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // softcheckbtn
            // 
            this.softcheckbtn.AutoSize = true;
            this.softcheckbtn.Location = new System.Drawing.Point(14, 20);
            this.softcheckbtn.Name = "softcheckbtn";
            this.softcheckbtn.Size = new System.Drawing.Size(113, 20);
            this.softcheckbtn.TabIndex = 13;
            this.softcheckbtn.Text = "Мека корица";
            this.softcheckbtn.UseVisualStyleBackColor = true;
            // 
            // hardcheckbx
            // 
            this.hardcheckbx.AutoSize = true;
            this.hardcheckbx.Location = new System.Drawing.Point(14, 46);
            this.hardcheckbx.Name = "hardcheckbx";
            this.hardcheckbx.Size = new System.Drawing.Size(129, 20);
            this.hardcheckbx.TabIndex = 14;
            this.hardcheckbx.Text = "Твърда корица";
            this.hardcheckbx.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Вид корица";
            // 
            // izdcombobx
            // 
            this.izdcombobx.FormattingEnabled = true;
            this.izdcombobx.Items.AddRange(new object[] {
            "Просвета",
            "СофияЕт",
            "Витоша",
            "Зевс",
            "Архимет"});
            this.izdcombobx.Location = new System.Drawing.Point(96, 232);
            this.izdcombobx.Name = "izdcombobx";
            this.izdcombobx.Size = new System.Drawing.Size(198, 24);
            this.izdcombobx.TabIndex = 16;
            this.izdcombobx.Text = "Издателство";
            this.izdcombobx.SelectedIndexChanged += new System.EventHandler(this.izdcombobx_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.hardcheckbx);
            this.groupBox3.Controls.Add(this.softcheckbtn);
            this.groupBox3.Location = new System.Drawing.Point(330, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 79);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.izdcombobx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox autortxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameofbooktxtbtn;
        private System.Windows.Forms.RadioButton spravradiobtn;
        private System.Windows.Forms.RadioButton nauchradiobtn;
        private System.Windows.Forms.RadioButton hydradiobtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox softcheckbtn;
        private System.Windows.Forms.CheckBox hardcheckbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox izdcombobx;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

