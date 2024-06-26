namespace QuanLyNhanSu.CT
{
    partial class CaLamViec
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.txtLoaiCa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.txtMaCLV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCaLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtLoaiCa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbTB);
            this.panel1.Controls.Add(this.txtMaCLV);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 330);
            this.panel1.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(102, 114);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(315, 21);
            this.txtMaNV.TabIndex = 11;
            // 
            // txtLoaiCa
            // 
            this.txtLoaiCa.Location = new System.Drawing.Point(102, 164);
            this.txtLoaiCa.Name = "txtLoaiCa";
            this.txtLoaiCa.Size = new System.Drawing.Size(315, 20);
            this.txtLoaiCa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "LoaiCa";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.Color.Red;
            this.lbTB.Location = new System.Drawing.Point(14, 285);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(44, 16);
            this.lbTB.TabIndex = 7;
            this.lbTB.Text = "label4";
            // 
            // txtMaCLV
            // 
            this.txtMaCLV.Location = new System.Drawing.Point(102, 65);
            this.txtMaCLV.Name = "txtMaCLV";
            this.txtMaCLV.Size = new System.Drawing.Size(315, 20);
            this.txtMaCLV.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCaLamViec,
            this.TenNV,
            this.LoaiCa,
            this.MaNhanVien});
            this.dataGridView1.Location = new System.Drawing.Point(459, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(428, 236);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaCaLamViec
            // 
            this.MaCaLamViec.DataPropertyName = "MaCaLamViec";
            this.MaCaLamViec.HeaderText = "Mã Ca Làm Việc";
            this.MaCaLamViec.Name = "MaCaLamViec";
            this.MaCaLamViec.ReadOnly = true;
            this.MaCaLamViec.Width = 120;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // LoaiCa
            // 
            this.LoaiCa.DataPropertyName = "LoaiCa";
            this.LoaiCa.HeaderText = "Loại Ca";
            this.LoaiCa.Name = "LoaiCa";
            this.LoaiCa.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "MaNV";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Visible = false;
            this.MaNhanVien.Width = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(314, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(215, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(116, 200);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Ca Làm Việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ca Làm Việc";
            // 
            // CaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CaLamViec";
            this.Size = new System.Drawing.Size(990, 502);
            this.Load += new System.EventHandler(this.CaLamViec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaCLV;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.TextBox txtLoaiCa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCaLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
    }
}
