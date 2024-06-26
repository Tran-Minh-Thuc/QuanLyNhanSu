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
    public partial class ButToan : UserControl
    {
        public ButToan()
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
            nvs = cl.LaySoDuDauKi("0");
            List<string> sddkArray = new List<string>();
            foreach (DataRow row in nvs.Rows)
            {
                string index = $"{row["MaSoDuDauKi"].ToString()}";
                sddkArray.Add(index);
            }
            nvs.Clear();
            dt = cl.LayButToan("0");
            dataGridView1.DataSource = dt;
            btnLuu.Enabled = false;
            txtMaButToan.Text = null;
            txtMaSoDuDauKi.Items.Clear();
            txtMaSoDuDauKi.Items.AddRange(sddkArray.ToArray());
            txtTaiKhoanCo.Text = null;
            txtTaiKhoanNo.Text = null;
            txtTongTien.Text = null;
            txtNgayChungTu.Text = null;
            txtDienGiai.Text = null;
            lbTB.Text = null;
        }
        private void CaLamViec_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaButToan.Text = null;
            txtMaSoDuDauKi.Text = null;
            txtTaiKhoanCo.Text = null;
            txtTaiKhoanNo.Text = null;
            txtTongTien.Text = null;
            txtNgayChungTu.Text = null;
            txtDienGiai.Text = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int mabt = int.Parse(txtMaButToan.Text);
            int masodudauki = int.Parse(txtMaSoDuDauKi.Text);
            string ngaychungtu = txtNgayChungTu.Text;
            string taikhoanco = txtTaiKhoanCo.Text;
            string taikhoanno = txtTaiKhoanNo.Text;
            string diengiai = txtDienGiai.Text;
            int tongtien = int.Parse(txtTongTien.Text);

            if (!string.IsNullOrEmpty(txtMaButToan.Text) && !string.IsNullOrEmpty(txtMaSoDuDauKi.Text))
            {
                SqlDataReader savedSuccessfully = cl.ThemButToan(mabt, masodudauki, ngaychungtu, taikhoanco, taikhoanno, diengiai, tongtien);

                if (savedSuccessfully != null)
                {
                    lbTB.Text = "Đã lưu!!";
                    load();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    txtTongTien.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giá trị cho MaButToan và MaSoDuDauKi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mabt = int.Parse(txtMaButToan.Text);
            int masodudauki = int.Parse(txtMaSoDuDauKi.Text);
            string ngaychungtu = txtNgayChungTu.Text;
            string taikhoanco = txtTaiKhoanCo.Text;
            string taikhoanno = txtTaiKhoanNo.Text;
            string diengiai = txtDienGiai.Text;
            int tongtien = int.Parse(txtTongTien.Text);

            if (!string.IsNullOrEmpty(txtMaButToan.Text) && !string.IsNullOrEmpty(txtMaSoDuDauKi.Text) && !string.IsNullOrEmpty(txtTongTien.Text))
            {
                SqlDataReader savedSuccessfully = cl.CapNhatButToan(mabt, masodudauki, ngaychungtu, taikhoanco, taikhoanno, diengiai, tongtien);

                if (savedSuccessfully != null)
                {
                    lbTB.Text = "Đã lưu!!";
                    load();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    txtTongTien.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị cho MaButToan, MaSoDuDauKi và TongTien.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int mabt = int.Parse(txtMaButToan.Text);
                if (!string.IsNullOrEmpty(txtMaButToan.Text))
                {
                    if (MessageBox.Show("Bạn thật sự muốn xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        SqlDataReader dr = cl.XoaButToan(mabt);
                        lbTB.Text = "Đã xóa!!";
                        load();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaButToan.Text = dataGridView1.CurrentRow.Cells["MaButToan"].Value.ToString(); ;
            txtMaSoDuDauKi.Text = dataGridView1.CurrentRow.Cells["MaSoDuDauKi"].Value.ToString(); ;
            txtTaiKhoanCo.Text = dataGridView1.CurrentRow.Cells["TaiKhoanCo"].Value.ToString(); ;
            txtTaiKhoanNo.Text = dataGridView1.CurrentRow.Cells["TaiKhoanNo"].Value.ToString(); ;
            txtTongTien.Text = dataGridView1.CurrentRow.Cells["TongTien"].Value.ToString(); ;
            txtNgayChungTu.Text = dataGridView1.CurrentRow.Cells["NgayChungTu"].Value.ToString(); ;
            txtDienGiai.Text = dataGridView1.CurrentRow.Cells["DienGiai"].Value.ToString(); ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
