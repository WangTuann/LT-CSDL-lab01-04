
namespace Demo_ComboBox
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
            this.lbname = new System.Windows.Forms.Label();
            this.cbbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(22, 61);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(82, 13);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Chọn ngoại ngữ";
            // 
            // cbbNgoaiNgu
            // 
            this.cbbNgoaiNgu.FormattingEnabled = true;
            this.cbbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Nga",
            "Tiếng Pháp",
            "Tiếng Hàn"});
            this.cbbNgoaiNgu.Location = new System.Drawing.Point(119, 58);
            this.cbbNgoaiNgu.Name = "cbbNgoaiNgu";
            this.cbbNgoaiNgu.Size = new System.Drawing.Size(153, 21);
            this.cbbNgoaiNgu.TabIndex = 1;
            this.cbbNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cbbNgoaiNgu_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cbbNgoaiNgu);
            this.Controls.Add(this.lbname);
            this.Name = "Form1";
            this.Text = "Demo ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.ComboBox cbbNgoaiNgu;
    }
}

