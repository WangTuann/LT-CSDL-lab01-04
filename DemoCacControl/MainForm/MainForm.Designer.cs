
using System;

namespace MainForm
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.flpFloor1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ttFloor = new System.Windows.Forms.ToolTip(this.components);
            this.lvTableList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgTable = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpFloor2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flpFloor3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbFloor = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpFloor1
            // 
            this.flpFloor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFloor1.Location = new System.Drawing.Point(3, 16);
            this.flpFloor1.Name = "flpFloor1";
            this.flpFloor1.Size = new System.Drawing.Size(333, 206);
            this.flpFloor1.TabIndex = 0;
            // 
            // lvTableList
            // 
            this.lvTableList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvTableList.CheckBoxes = true;
            this.lvTableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTableList.FullRowSelect = true;
            this.lvTableList.GridLines = true;
            this.lvTableList.HideSelection = false;
            this.lvTableList.LargeImageList = this.imgTable;
            this.lvTableList.Location = new System.Drawing.Point(430, 28);
            this.lvTableList.MultiSelect = false;
            this.lvTableList.Name = "lvTableList";
            this.lvTableList.Size = new System.Drawing.Size(261, 648);
            this.lvTableList.SmallImageList = this.imgTable;
            this.lvTableList.StateImageList = this.imgTable;
            this.lvTableList.TabIndex = 1;
            this.lvTableList.UseCompatibleStateImageBehavior = false;
            this.lvTableList.View = System.Windows.Forms.View.Details;
            this.lvTableList.SelectedIndexChanged += new System.EventHandler(this.lvTableList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã bàn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên bàn";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng thái";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tầng";
            this.columnHeader4.Width = 55;
            // 
            // imgTable
            // 
            this.imgTable.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTable.ImageStream")));
            this.imgTable.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTable.Images.SetKeyName(0, "table2.png");
            this.imgTable.Images.SetKeyName(1, "table1.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpFloor1);
            this.groupBox1.Location = new System.Drawing.Point(71, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tầng 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpFloor2);
            this.groupBox2.Location = new System.Drawing.Point(71, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tầng 2";
            // 
            // flpFloor2
            // 
            this.flpFloor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFloor2.Location = new System.Drawing.Point(3, 16);
            this.flpFloor2.Name = "flpFloor2";
            this.flpFloor2.Size = new System.Drawing.Size(333, 203);
            this.flpFloor2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flpFloor3);
            this.groupBox3.Location = new System.Drawing.Point(71, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 221);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tầng 3";
            // 
            // flpFloor3
            // 
            this.flpFloor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFloor3.Location = new System.Drawing.Point(3, 16);
            this.flpFloor3.Name = "flpFloor3";
            this.flpFloor3.Size = new System.Drawing.Size(333, 202);
            this.flpFloor3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã bàn";
            // 
            // txtTableID
            // 
            this.txtTableID.Location = new System.Drawing.Point(778, 38);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(176, 20);
            this.txtTableID.TabIndex = 6;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(778, 66);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Size = new System.Drawing.Size(176, 20);
            this.txtTableName.TabIndex = 8;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên bàn";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tầng";
            // 
            // cbbFloor
            // 
            this.cbbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFloor.FormattingEnabled = true;
            this.cbbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbFloor.Location = new System.Drawing.Point(778, 97);
            this.cbbFloor.Name = "cbbFloor";
            this.cbbFloor.Size = new System.Drawing.Size(176, 21);
            this.cbbFloor.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(728, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(921, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(828, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbFloor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvTableList);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFloor1;
        private System.Windows.Forms.ToolTip ttFloor;
        private System.Windows.Forms.ListView lvTableList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpFloor2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flpFloor3;
        public System.Windows.Forms.ImageList imgTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbFloor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

