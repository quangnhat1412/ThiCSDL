using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_C21TH2_TranQuangNhat
{
    public partial class Form1 : Form
    {
        QLSVDbContext db = new QLSVDbContext();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu 
            KhoiTaoDuLieu();
            LienKetDieuKhien();
        }

        private void LienKetDieuKhien()
        {
            foreach(Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    ctl.DataBindings.Add("Text", bs, ctl.Name.Substring(3), true);
                else if (ctl is ComboBox)
                    ctl.DataBindings.Add("SelectedValue", bs, ctl.Name.Substring(3), true);
            }
        }

        private void KhoiTaoDuLieu()
        {
            bs.DataSource = db.SINHVIENs.ToList();

            // KHỏi tạo cbo
            cbomakh.DisplayMember = "TenKH";
            cbomakh.ValueMember = "MaKH";
            cbomakh.DataSource = db.KHOAs.ToList();
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            // khi ở mẩu tin đầu tiền thì hiện lên thông báo
            if(bs.Position == 0)
            {
                MessageBox.Show("Bạn đang ở mẩu tin đầu tiên.", "Thông báo");
            }
            else
            {
                bs.MovePrevious();
            }
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            if(bs.Position == db.SINHVIENs.Count() - 1)
            {
                MessageBox.Show("Bạn đang ở mẩu tin cuối cùng.", "Thông báo");
            }
            else
            {
                bs.MoveNext();
            }
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmasv.ReadOnly = false;
            bs.AddNew();
            cbomakh.SelectedIndex = 0;
            txtmasv.Focus();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Lấy đối tượng cần hủy => sử dụng single
            if(dlr == DialogResult.Yes)
            {
                SINHVIEN sv = db.SINHVIENs.SingleOrDefault(s => s.MaSV == txtmasv.Text);
                db.SINHVIENs.Remove(sv);

                // Hủy trong bs 
                bs.RemoveCurrent();

                // Cập nhật về CSDL
                db.SaveChanges();

                // trở về mẩu tin đầu tiên
                btndau.PerformClick();
            }
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if(txtmasv.Text.Length == 0 || txthoten.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin", "Thông báo");
                return;
            }
            if(txtmasv.ReadOnly) // sửa 
            {
                // lấy sinh viên cần sửa 
                SINHVIEN sv = db.SINHVIENs.SingleOrDefault(s => s.MaSV == txtmasv.Text);
                // Tiến hành sửa 
                sv.HoTen = txthoten.Text;
                sv.SoMon = int.Parse(txtsomon.Text);
                sv.MaKH = cbomakh.SelectedValue.ToString();
            }
            else
            {
                SINHVIEN sv = db.SINHVIENs.SingleOrDefault(s => s.MaSV == txtmasv.Text);
                if(sv != null)
                {
                    MessageBox.Show("Sinh viên đã tồn tại", "Thông báo");
                    return;
                }
                else
                {
                    db.SINHVIENs.Add(new SINHVIEN
                    {
                        MaSV = txtmasv.Text,
                        HoTen = txthoten.Text,
                        SoMon = int.Parse(txtsomon.Text),
                        MaKH = cbomakh.SelectedValue.ToString()
                    });
                    btndau.PerformClick();
                }
            }
            bs.EndEdit();
            db.SaveChanges();
            MessageBox.Show("Cập nhật thành công", "Thông báo");
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            txtmasv.ReadOnly = true;
        }

        private void txtmasv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu độ dài của văn bản trong TextBox là 3 và người dùng không phải là phím Backspace (8)
            if (txtmasv.Text.Length >= 3 && e.KeyChar != 8)
            {
                e.Handled = true; // Ngăn chặn sự kiện nhập
            }
        }

        private void btnthongtin_Click(object sender, EventArgs e)
        {
            Form2 dlg2 = new Form2();
            dlg2.maSV = txtmasv.Text;
            dlg2.ShowDialog();
        }
    }
}
