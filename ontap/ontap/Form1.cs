using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ontap
{
    public partial class Form1 : Form
    {
        QuanLyNVEntities db = new QuanLyNVEntities();

        public Form1()
        {
            InitializeComponent();

            loaddata();

        }

       
        void loaddata()
        {
            listView1.Items.Clear();
            var dl = from c in db.NhanViens select new { 
                MANV = c.MaNhanVien , 
                HOTEN = c.HoTen,
                GIOITINH = c.GioiTinh,
                DIENTHOAI = c.SoDienThoai,
                NGAYVL = c.NgayVaoLam,
                DOANHSO = c.NhanVienBanHang.DoanhSo,
                 PCNL = c.NhanVienGiaoNhan.PhuCapNhienLieu
            };

            foreach (var nv in dl) {
                ListViewItem lv = new ListViewItem(nv.MANV);
                lv.SubItems.Add(nv.HOTEN);
                lv.SubItems.Add(nv.GIOITINH);
                lv.SubItems.Add(nv.DIENTHOAI);
                lv.SubItems.Add(nv.NGAYVL.Value.ToShortDateString());
                TimeSpan tn = DateTime.Now - nv.NGAYVL.Value;
                if (tn.TotalDays > 5 * 365)
                {
                    lv.BackColor = Color.Yellow;
                }
                lv.SubItems.Add(nv.DOANHSO.ToString());
                lv.SubItems.Add(nv.PCNL.ToString());

                listView1.Items.Add(lv);

            }

        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LB_PC_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_BH_CheckedChanged(object sender, EventArgs e)
        {
            LB_DS.Visible = true;
            TXT_DS.Visible = true;

            LB_PC.Visible = false;
            TXT_PC.Visible = false;
        }

        private void radioButton_GH_CheckedChanged(object sender, EventArgs e)
        {
            LB_DS.Visible = false;
            TXT_DS.Visible = false;

            LB_PC.Visible = true;
            TXT_PC.Visible = true;
        }

        void reset()
        {
            TXT_MNV.Clear();
            TXT_HT.Clear();
            TXT_DT.Clear();
            TXT_DS.Clear();
            TXT_PC.Clear();
            radioButton_NAM.Checked = true;
            date_NVL.Value = DateTime.Now;
            radioButton_BH.Checked = true;
        }

        
        private void button_THEM_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button_LUU_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TXT_MNV.Text)|| string.IsNullOrEmpty(TXT_DT.Text) || string.IsNullOrEmpty(TXT_HT.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống");
                return;
            }
            if (radioButton_BH.Checked)
            {
                if (string.IsNullOrEmpty(TXT_DS.Text))
                {
                    MessageBox.Show("Dữ liệu không được để trống");
                    return;
                }
            }
            if (radioButton_GH.Checked)
            {
                if (string.IsNullOrEmpty(TXT_PC.Text))
                {
                    MessageBox.Show("Dữ liệu không được để trống");
                    return;
                }
            }

            NhanVien nv = new NhanVien { 
                MaNhanVien = TXT_MNV.Text,
                HoTen = TXT_HT.Text,
                GioiTinh = radioButton_NAM.Checked ? "Nam":"Nữ",
                SoDienThoai = TXT_DT.Text,
                NgayVaoLam = date_NVL.Value,

            };
            db.NhanViens.Add(nv);
            if (radioButton_BH.Checked)
            {
                NhanVienBanHang nvbh = new NhanVienBanHang { 
                    MaNhanVien = nv.MaNhanVien,
                    DoanhSo = double.Parse( TXT_DS.Text)
                };
                db.NhanVienBanHangs.Add(nvbh);

            }
            if (radioButton_GH.Checked)
            {
                NhanVienGiaoNhan nvbh = new NhanVienGiaoNhan
                {
                    MaNhanVien = nv.MaNhanVien,
                    PhuCapNhienLieu= double.Parse(TXT_PC.Text)
                };
                db.NhanVienGiaoNhans.Add(nvbh);
            }

            int ktr = db.SaveChanges();          
            loaddata();
         }

        private void button_XOA_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Bạn có chắc muốn xoá không?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes) { 

                string manv = listView1.SelectedItems[0].SubItems[0].Text;
                NhanVien nv = db.NhanViens.FirstOrDefault(c => c.MaNhanVien == manv);
                    if (nv != null)
                    {
                        db.NhanViens.Remove(nv);
                        NhanVienBanHang nvbh = db.NhanVienBanHangs.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
                        if (nvbh != null)
                        {
                            db.NhanVienBanHangs.Remove(nvbh);
                        }

                        NhanVienGiaoNhan nvgn = db.NhanVienGiaoNhans.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
                        if (nvgn != null)
                        {
                            db.NhanVienGiaoNhans.Remove(nvgn);
                        }
                        db.SaveChanges();
                        loaddata();
                    }
                }
            }
            
        }


        

        private void button_SUA_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string manv = listView1.SelectedItems[0].SubItems[0].Text;
                NhanVien nv = db.NhanViens.FirstOrDefault(c => c.MaNhanVien == manv);
                if (nv != null)
                {
                    nv.MaNhanVien = TXT_MNV.Text;
                    nv.HoTen = TXT_HT.Text;
                    nv.GioiTinh = radioButton_NAM.Checked ? "Nam" : "Nữ";
                    nv.SoDienThoai = TXT_DT.Text;
                    nv.NgayVaoLam = date_NVL.Value;

                    if (radioButton_BH.Checked) {
                        NhanVienGiaoNhan nvgn = db.NhanVienGiaoNhans.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
                        NhanVienBanHang nvbh = db.NhanVienBanHangs.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
                        if (nvbh != null)
                        {
                            nvbh.DoanhSo = double.Parse( TXT_DS.Text);
                        }
                        else
                        {
                            nvbh = new NhanVienBanHang { 
                            MaNhanVien = nv.MaNhanVien,
                            DoanhSo = double.Parse(TXT_DS.Text)
                            };
                            db.NhanVienBanHangs.Add(nvbh);
                            db.NhanVienGiaoNhans.Remove(nvgn);
                        }
                    }
                    if (radioButton_GH.Checked)
                    {
                        NhanVienGiaoNhan nvgn = db.NhanVienGiaoNhans.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
                        NhanVienBanHang nvbh = db.NhanVienBanHangs.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
                        if (nvgn != null)
                        {
                            nvgn.PhuCapNhienLieu = double.Parse(TXT_PC.Text);
                        }
                        else
                        {
                            nvgn = new NhanVienGiaoNhan
                            { 
                                MaNhanVien = nv.MaNhanVien,
                                PhuCapNhienLieu = double.Parse(TXT_PC.Text)
                            };
                            db.NhanVienBanHangs.Remove(nvbh);
                            db.NhanVienGiaoNhans.Add(nvgn);
                        }
                    }
                }
                db.SaveChanges();
                loaddata();
                reset();
            }
        }  

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                TXT_MNV.Text = lv.SubItems[0].Text;
                TXT_HT.Text = lv.SubItems[1].Text;
                if(lv.SubItems[2].Text == "Nam")
                {
                    radioButton_NAM.Checked = true;
                }
                else if (lv.SubItems[2].Text == "Nữ")
                {
                    radioButton_NU.Checked = true;
                }
                TXT_DT.Text = lv.SubItems[3].Text;

                DateTime d;
                if(DateTime.TryParseExact(lv.SubItems[4].Text,"M/d/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out d))
                {
                    date_NVL.Value = d;
                }

                if (string.IsNullOrEmpty(lv.SubItems[5].Text))
                {
                    radioButton_GH.Checked = true;
                    TXT_PC.Text = lv.SubItems[6].Text;
                }
                if (string.IsNullOrEmpty(lv.SubItems[6].Text))
                {
                    radioButton_BH.Checked = true;
                    TXT_DS.Text = lv.SubItems[5].Text;
                }

            }
        }

        private void button_SAPXEP_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var dl = from c in db.NhanViens
                     orderby c.NgayVaoLam descending, c.HoTen ascending
                     select new
                     {
                         MANV = c.MaNhanVien,
                         HOTEN = c.HoTen,
                         GIOITINH = c.GioiTinh,
                         DIENTHOAI = c.SoDienThoai,
                         NGAYVL = c.NgayVaoLam,
                         DOANHSO = c.NhanVienBanHang.DoanhSo,
                         PCNL = c.NhanVienGiaoNhan.PhuCapNhienLieu
                     };

            foreach (var nv in dl)
            {
                ListViewItem lv = new ListViewItem(nv.MANV);
                lv.SubItems.Add(nv.HOTEN);
                lv.SubItems.Add(nv.GIOITINH);
                lv.SubItems.Add(nv.DIENTHOAI);
                
                lv.SubItems.Add(nv.NGAYVL.Value.ToShortDateString());
                TimeSpan tn = DateTime.Now - nv.NGAYVL.Value;
                if (tn.TotalDays > 5 * 365)
                {
                    lv.BackColor = Color.Yellow;
                }
                lv.SubItems.Add(nv.DOANHSO.ToString());
                lv.SubItems.Add(nv.PCNL.ToString());

                

                listView1.Items.Add(lv);

            }
        }

        private void button_THONGKE_Click(object sender, EventArgs e)
        {
            int nvbh = 0;
            int nvgn = 0;
            double tongchi_bh = 0, tongchi_gn= 0;
            double luongcoban = 7000000;

            var nvbhList = db.NhanVienBanHangs.ToList(); // Lấy danh sách nhân viên bán hàng
            foreach (var nv in nvbhList)
            {
                
                tongchi_bh += luongcoban + (nv.DoanhSo.Value * 10.0 * (1.0 / 10.0));
                nvbh++;
            }
            var nvgnList = db.NhanVienGiaoNhans.ToList(); // Lấy danh sách nhân viên giao nhận
            foreach (var nv in nvgnList)
            {
                tongchi_gn += luongcoban + nv.PhuCapNhienLieu.Value;
                nvgn++;
            }

            MessageBox.Show("Số lượng nhân viên bán hàng:" + nvbh + "\nSố lượng nhân viên giao nhận: " + nvgn+"\n Tổng lương chi cho nhân viên bán hàng:" + tongchi_bh+"\nTổng lương chi cho nhân viên giao nhận: "+tongchi_gn, "Thống kê");
        }
    }
} 

