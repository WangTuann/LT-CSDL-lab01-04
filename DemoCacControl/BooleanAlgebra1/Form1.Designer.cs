﻿
namespace BooleanAlgebra1
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
            this.lblOperation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOperand1 = new System.Windows.Forms.CheckBox();
            this.chkOperand2 = new System.Windows.Forms.CheckBox();
            this.chkResult = new System.Windows.Forms.CheckBox();
            this.btnNewOperation = new System.Windows.Forms.Button();
            this.btnCheckOperation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(312, 46);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(75, 37);
            this.lblOperation.TabIndex = 1;
            this.lblOperation.Text = "A^B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "B";
            // 
            // chkOperand1
            // 
            this.chkOperand1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOperand1.AutoSize = true;
            this.chkOperand1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkOperand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOperand1.Location = new System.Drawing.Point(12, 86);
            this.chkOperand1.Name = "chkOperand1";
            this.chkOperand1.Size = new System.Drawing.Size(83, 39);
            this.chkOperand1.TabIndex = 4;
            this.chkOperand1.Text = "False";
            this.chkOperand1.UseVisualStyleBackColor = true;
            this.chkOperand1.CheckedChanged += new System.EventHandler(this.chkOperand1_CheckedChanged);
            // 
            // chkOperand2
            // 
            this.chkOperand2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOperand2.AutoSize = true;
            this.chkOperand2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkOperand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOperand2.Location = new System.Drawing.Point(169, 86);
            this.chkOperand2.Name = "chkOperand2";
            this.chkOperand2.Size = new System.Drawing.Size(83, 39);
            this.chkOperand2.TabIndex = 5;
            this.chkOperand2.Text = "False";
            this.chkOperand2.UseVisualStyleBackColor = true;
            this.chkOperand2.CheckedChanged += new System.EventHandler(this.chkOperand2_CheckedChanged);
            // 
            // chkResult
            // 
            this.chkResult.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkResult.AutoSize = true;
            this.chkResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResult.Location = new System.Drawing.Point(316, 86);
            this.chkResult.Name = "chkResult";
            this.chkResult.Size = new System.Drawing.Size(83, 39);
            this.chkResult.TabIndex = 6;
            this.chkResult.Text = "False";
            this.chkResult.UseVisualStyleBackColor = true;
            this.chkResult.CheckedChanged += new System.EventHandler(this.chkResult_CheckedChanged);
            // 
            // btnNewOperation
            // 
            this.btnNewOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOperation.Location = new System.Drawing.Point(12, 150);
            this.btnNewOperation.Name = "btnNewOperation";
            this.btnNewOperation.Size = new System.Drawing.Size(240, 42);
            this.btnNewOperation.TabIndex = 7;
            this.btnNewOperation.Text = "New Operation";
            this.btnNewOperation.UseVisualStyleBackColor = true;
            this.btnNewOperation.Click += new System.EventHandler(this.btnNewOperation_Click);
            // 
            // btnCheckOperation
            // 
            this.btnCheckOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOperation.Location = new System.Drawing.Point(316, 150);
            this.btnCheckOperation.Name = "btnCheckOperation";
            this.btnCheckOperation.Size = new System.Drawing.Size(83, 42);
            this.btnCheckOperation.TabIndex = 8;
            this.btnCheckOperation.Text = "Check";
            this.btnCheckOperation.UseVisualStyleBackColor = true;
            this.btnCheckOperation.Click += new System.EventHandler(this.btnCheckOperation_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(387, 42);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckOperation);
            this.Controls.Add(this.btnNewOperation);
            this.Controls.Add(this.chkResult);
            this.Controls.Add(this.chkOperand2);
            this.Controls.Add(this.chkOperand1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOperand1;
        private System.Windows.Forms.CheckBox chkOperand2;
        private System.Windows.Forms.CheckBox chkResult;
        private System.Windows.Forms.Button btnNewOperation;
        private System.Windows.Forms.Button btnCheckOperation;
        private System.Windows.Forms.Button btnClose;
    }
}

