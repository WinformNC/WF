﻿namespace QuanLyThuVien
{
    partial class fTraTaiLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_DocGia = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MADG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDSTaiLieu = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dtgv_DocGia, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDSTaiLieu, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(298, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 64);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(289, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách độc giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtgv_DocGia
            // 
            this.dtgv_DocGia.AllowUserToAddRows = false;
            this.dtgv_DocGia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_DocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_DocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DocGia.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgv_DocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_DocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_DocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADG,
            this.TENDG});
            this.dtgv_DocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DocGia.DoubleBuffered = true;
            this.dtgv_DocGia.EnableHeadersVisualStyles = false;
            this.dtgv_DocGia.HeaderBgColor = System.Drawing.Color.White;
            this.dtgv_DocGia.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgv_DocGia.Location = new System.Drawing.Point(3, 72);
            this.dtgv_DocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_DocGia.Name = "dtgv_DocGia";
            this.dtgv_DocGia.ReadOnly = true;
            this.dtgv_DocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_DocGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_DocGia.RowTemplate.Height = 24;
            this.dtgv_DocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_DocGia.Size = new System.Drawing.Size(289, 628);
            this.dtgv_DocGia.TabIndex = 36;
            this.dtgv_DocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DocGia_CellClick);
            // 
            // MADG
            // 
            this.MADG.DataPropertyName = "MADG";
            this.MADG.HeaderText = "Mã độc giả";
            this.MADG.Name = "MADG";
            this.MADG.ReadOnly = true;
            // 
            // TENDG
            // 
            this.TENDG.DataPropertyName = "TENDG";
            this.TENDG.HeaderText = "Tên độc giả";
            this.TENDG.Name = "TENDG";
            this.TENDG.ReadOnly = true;
            // 
            // pnlDSTaiLieu
            // 
            this.pnlDSTaiLieu.AutoScroll = true;
            this.pnlDSTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDSTaiLieu.Location = new System.Drawing.Point(298, 73);
            this.pnlDSTaiLieu.Name = "pnlDSTaiLieu";
            this.pnlDSTaiLieu.Size = new System.Drawing.Size(684, 626);
            this.pnlDSTaiLieu.TabIndex = 37;
            // 
            // fTraTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 702);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTraTaiLieu";
            this.Text = "Trả tài liệu";
            this.Load += new System.EventHandler(this.fTraTaiLieu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgv_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDG;
        private System.Windows.Forms.FlowLayoutPanel pnlDSTaiLieu;


    }
}