using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyNhanSu.CT
{
    public partial class CaLamViec : UserControl
    {
        public CaLamViec()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        DataTable nvs = new DataTable();
        private void load()
        {
            dt.Clear();
            nvs = cl.pcLayNhanVien("0");
            List<string> nvsArray = new List<string>();
            foreach (DataRow row in nvs.Rows)
            {
                // Xây dựng chuỗi từ dữ liệu của từng dòng và thêm vào mảng
                string index = $"{row["TenNV"].ToString()} ({row["MaNhanvien"].ToString()})";
                nvsArray.Add(index);
            }
            nvs.Clear();
            dt = cl.LayCaLamViec("0");
            dataGridView1.DataSource = dt;
            btnLuu.Enabled = false;
            txtMaNV.Text = null;
            txtLoaiCa.Text = null;
            lbTB.Text = null;
            txtMaNV.Items.Clear();
            txtMaNV.Items.AddRange(nvsArray.ToArray());
        }
        private void CaLamViec_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaCLV.Text = null;
            txtMaNV.Text = null;
            txtLoaiCa.Text = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string selectedMaCLV = txtMaCLV.Text;
            string selectedMaNV = ExtractMaNVFromText(txtMaNV.Text);  
            string selectedLoaiCa = txtLoaiCa.Text;
            if (!string.IsNullOrEmpty(selectedMaCLV) && !string.IsNullOrEmpty(selectedMaNV))
            {
                SqlDataReader savedSuccessfully = cl.ThemCaLamViec(selectedMaCLV, selectedMaNV, selectedLoaiCa);

                if (savedSuccessfully != null)
                {
                    lbTB.Text = "Đã lưu!!";
                    load();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    txtLoaiCa.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giá trị cho MaCLV và MaNV.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string selectedMaCLV = txtMaCLV.Text;
            string selectedMaNV = ExtractMaNVFromText(txtMaNV.Text);
            string selectedLoaiCa = txtLoaiCa.Text;
            if (!string.IsNullOrEmpty(selectedMaCLV) && !string.IsNullOrEmpty(selectedMaNV) && !string.IsNullOrEmpty(selectedLoaiCa))
            {
                SqlDataReader savedSuccessfully = cl.CapNhatCaLamViec(selectedMaCLV, selectedMaNV, selectedLoaiCa);

                if (savedSuccessfully != null)
                {
                    lbTB.Text = "Đã lưu!!";
                    load();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    txtLoaiCa.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giá trị cho MaCLV và MaNV.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedMaCLV = txtMaCLV.Text;
                if (!string.IsNullOrEmpty(selectedMaCLV))
                {
                    if (MessageBox.Show("Bạn thật sự muốn xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        dr = cl.XoaCaLamViec(selectedMaCLV);
                        lbTB.Text = "Đã xóa!!";
                        load();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng chuyển hết nhân viên đang giữ chức vụ hiện tại trước khi xóa");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCLV.Text = dataGridView1.CurrentRow.Cells["MaCaLamViec"].Value.ToString();
            txtMaNV.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString() + " (" + dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString() + ")";
            txtLoaiCa.Text = dataGridView1.CurrentRow.Cells["LoaiCa"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string ExtractMaNVFromText(string text)
        {
            // Example: Extract MaNV from formatted string "TenNV (MaNhanvien)"
            // Find the index of the first '(' and the last ')' to get the substring in between
            int startIndex = text.IndexOf('(') + 1;
            int length = text.IndexOf(')') - startIndex;

            if (startIndex > 0 && length > 0)
            {
                return text.Substring(startIndex, length);
            }
            return string.Empty;
        }
    }
}
