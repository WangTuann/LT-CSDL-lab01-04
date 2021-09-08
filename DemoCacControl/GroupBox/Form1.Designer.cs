
namespace GroupBox
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
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.gbGroup = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckB1 = new System.Windows.Forms.CheckBox();
            this.ckb2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbClass.SuspendLayout();
            this.gbGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClass
            // 
            this.gbClass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbClass.Controls.Add(this.ckb2);
            this.gbClass.Controls.Add(this.ckB1);
            this.gbClass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbClass.Location = new System.Drawing.Point(52, 25);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(216, 68);
            this.gbClass.TabIndex = 0;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "Lớp";
            // 
            // gbGroup
            // 
            this.gbGroup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbGroup.Controls.Add(this.radioButton2);
            this.gbGroup.Controls.Add(this.radioButton1);
            this.gbGroup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbGroup.Location = new System.Drawing.Point(52, 154);
            this.gbGroup.Name = "gbGroup";
            this.gbGroup.Size = new System.Drawing.Size(216, 78);
            this.gbGroup.TabIndex = 1;
            this.gbGroup.TabStop = false;
            this.gbGroup.Text = "Nhóm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(52, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 78);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Môn học";
            // 
            // ckB1
            // 
            this.ckB1.AutoSize = true;
            this.ckB1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckB1.Location = new System.Drawing.Point(6, 19);
            this.ckB1.Name = "ckB1";
            this.ckB1.Size = new System.Drawing.Size(59, 17);
            this.ckB1.TabIndex = 0;
            this.ckB1.Text = "CTK43";
            this.ckB1.UseVisualStyleBackColor = true;
            // 
            // ckb2
            // 
            this.ckb2.AutoSize = true;
            this.ckb2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckb2.Location = new System.Drawing.Point(6, 42);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(59, 17);
            this.ckb2.TabIndex = 1;
            this.ckb2.Text = "CTK42";
            this.ckb2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nhóm 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nhóm 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(135, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(311, 431);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbGroup);
            this.Controls.Add(this.gbClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.gbGroup.ResumeLayout(false);
            this.gbGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.CheckBox ckb2;
        private System.Windows.Forms.CheckBox ckB1;
        private System.Windows.Forms.GroupBox gbGroup;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

