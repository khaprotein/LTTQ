using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3_lttq
{
    public partial class Form1 : Form
    {

        QuanlyDoanhthuphimEntities db = new QuanlyDoanhthuphimEntities();
        public Form1()
        {
            InitializeComponent();
            loaddata();
        }

        public void loaddata()
        {
            listView1.Items.Clear();


            var dl = from c in db.Phims select new {
                Madon = c.madon,
                Tenphim = c.tenphim,
                Quocgia = c.quocgia,
                Theloai = c.theloai,
                Ngaycongchieu = c.NCC,
                Dotuoi = c.dotuoi,
                Dinhdang = (c.phim2d != null) ? c.phim2d.tendon : c.phim3d.tendon,
                PTDB = c.phim3d.PTDB,
                PTGD = c.phim2d.PTGD
            };


            foreach (var f in dl)
            {
                ListViewItem lv = new ListViewItem(f.Madon);

                lv.SubItems.Add(f.Tenphim);
                lv.SubItems.Add(f.Quocgia);
                lv.SubItems.Add(f.Theloai);
                lv.SubItems.Add(f.Ngaycongchieu.Value.ToShortDateString());

                lv.SubItems.Add(f.Dotuoi.ToString());
                lv.SubItems.Add(f.Dinhdang);
                lv.SubItems.Add(f.PTDB.ToString());
                lv.SubItems.Add(f.PTGD.ToString());
                TimeSpan dd = dateTime_CC.Value - DateTime.Now;
                if (dd.TotalDays < 7)
                {
                    lv.BackColor = Color.Yellow;
                }

                listView1.Items.Add(lv);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
            int p3d = 0, p2d = 0;
            double ve2d = 110.000, ve3d = 210.000;

            var dl2 = from c in db.phim2d select c; 
            foreach( var pim2d in dl2)
            {
                p2d++;
                ve2d += pim2d.PTGD.Value;
            }

            var dl3 = from c in db.phim3d select c;
            foreach (var pim3d in dl3)
            {
                p3d++;
                ve3d += pim3d.PTDB.Value;
            }

            MessageBox.Show("Số lượng phim 2D: " + p2d +
                "\n Số lượng phim 3D: " + p3d + 
                "\n Tổng doanh thu của phim 2D: " + ve2d +
                "\n Tổng doanh thu phim 3D: " + ve3d);

        }


        private void button_add_Click(object sender, EventArgs e)
        {
            txt_Madon.Clear();
            txt_DTQD.Clear();
            txtQG.Clear();
            txtTenPhim.Clear();
            txt_PTDB.Clear();
            txt_PTGD.Clear();

            rpt_2d.Checked = true;
            rpt_tinhcam.Checked = true;

            dateTime_CC.Value = DateTime.Now;

            txt_Madon.Focus();
        }

        private void rpt_2d_CheckedChanged(object sender, EventArgs e)
        {
            label_PT.Visible = false;
            label_GD.Visible = true;

            txt_PTDB.Visible = false;
            txt_PTGD.Visible = true;
        }

        private void rpt_3d_CheckedChanged(object sender, EventArgs e)
        {
            label_PT.Visible = true;
            label_GD.Visible = false;

            txt_PTDB.Visible = true;
            txt_PTGD.Visible = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Madon.Text) || string.IsNullOrEmpty(txtTenPhim.Text) || string.IsNullOrEmpty(txtQG.Text) || string.IsNullOrEmpty(txt_DTQD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (rpt_2d.Checked)
            {
                if (string.IsNullOrEmpty(txt_PTGD.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
               
            }
            if (rpt_3d.Checked)
            {
                if (string.IsNullOrEmpty(txt_PTDB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
               
            }

            Phim p = new Phim
            {
                madon = txt_Madon.Text,
                tenphim = txtTenPhim.Text,
                quocgia = txtQG.Text,
                theloai = rbt_hanhdong.Checked ? "Hành động" : "Tình cảm",
                NCC = dateTime_CC.Value,
                dotuoi = int.Parse(txt_DTQD.Text),

            };
            db.Phims.Add(p);

            if (rpt_2d.Checked)
            {
                phim2d p2d = new phim2d
                {
                    madon = p.madon,
                    tendon = "2D",
                    PTGD = double.Parse(txt_PTGD.Text)
                };
                db.phim2d.Add(p2d);
            }
            if (rpt_3d.Checked)
            {
                phim3d p3d = new phim3d
                {
                    madon = p.madon,
                    tendon = "3D",
                    PTDB = double.Parse(txt_PTDB.Text)
                };
                db.phim3d.Add(p3d);
            }

            db.SaveChanges();
            loaddata();
        }
    

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                
                if(MessageBox.Show("Bạn có muốn xoá hay không!", "", MessageBoxButtons.YesNo)==DialogResult.Yes) { 
                string Madon = listView1.SelectedItems[0].SubItems[0].Text;

                Phim p = db.Phims.FirstOrDefault(c => c.madon == Madon);
                if (p != null)
                {
                    db.Phims.Remove(p);
                    phim2d p2d = db.phim2d.FirstOrDefault(c => c.madon == p.madon);
                    if (p2d != null)
                    {
                        db.phim2d.Remove(p2d);
                    }
                    phim3d p3d = db.phim3d.FirstOrDefault(c => c.madon == p.madon);
                    if (p3d != null)
                    {
                        db.phim3d.Remove(p3d);
                    }
                    db.SaveChanges();
                    loaddata();
                }
                }
            }
            else {
                MessageBox.Show("Vui lòng chọn 1 dòng để xoá");
                return;
             }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                txt_Madon.Text = lv.SubItems[0].Text;
                txtTenPhim.Text = lv.SubItems[1].Text;
                txtQG.Text = lv.SubItems[2].Text;
                if(lv.SubItems[3].Text == "Hành động")
                {
                    rbt_hanhdong.Checked = true;
                }
                if(lv.SubItems[3].Text == "Tình cảm")
                {
                    rpt_tinhcam.Checked = true;
                }

                DateTime d;
                if(DateTime.TryParseExact(lv.SubItems[4].Text,"M/d/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out d))
                {
                    dateTime_CC.Value = d;
                }

                txt_DTQD.Text = lv.SubItems[5].Text;

                if (string.IsNullOrEmpty(lv.SubItems[7].Text))
                {
                    rpt_3d.Checked = true;
                    txt_PTDB.Text = lv.SubItems[8].Text;
                }
                if (string.IsNullOrEmpty(lv.SubItems[8].Text))
                {
                    rpt_2d.Checked = true;
                    txt_PTGD.Text = lv.SubItems[7].Text;
                }
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string Madon = listView1.SelectedItems[0].SubItems[0].Text;

                Phim p = db.Phims.FirstOrDefault(c => c.madon == Madon);

                p.madon = txt_Madon.Text;
                p.tenphim = txtTenPhim.Text;
                p.quocgia = txtQG.Text;
                p.theloai = rbt_hanhdong.Checked ? "Hành động" : "Tình cảm";
                p.NCC = dateTime_CC.Value;
                p.dotuoi = int.Parse(txt_DTQD.Text);

                if (rpt_2d.Checked)
                {   
                    phim2d p2d = db.phim2d.FirstOrDefault(c => c.madon == p.madon);
                    if (p2d != null)
                    {
                        p2d.PTGD = double.Parse(txt_PTGD.Text);
                    }
                    else
                    {
                        phim3d p3d = db.phim3d.FirstOrDefault(c => c.madon == p.madon);
                        db.phim3d.Remove(p3d);
                        p2d = new phim2d { 
                            madon = p.madon,
                            tendon ="2D",
                            PTGD = double.Parse(txt_PTGD.Text)
                        };
                        db.phim2d.Add(p2d);

                    }
                }
                if (rpt_3d.Checked)
                {
                    phim3d p3d = db.phim3d.FirstOrDefault(c => c.madon == p.madon);

                    if (p3d != null)
                    {
                        p3d.PTDB = double.Parse(txt_PTDB.Text);
                    }
                    else
                    {
                        phim2d p2d = db.phim2d.FirstOrDefault(c => c.madon == p.madon);
                        db.phim2d.Remove(p2d);
                        p3d = new phim3d
                        {
                            madon = p.madon,
                            tendon = "3D",
                            PTDB = double.Parse(txt_PTDB.Text)
                        };
                        db.phim3d.Add(p3d);

                    }
                }
                db.SaveChanges();
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xoá");
            }
        }

        private void button_sapxep_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var ds = from c in db.Phims orderby c.NCC ascending, c.dotuoi descending select new {
                Madon = c.madon,
                Tenphim = c.tenphim,
                Quocgia = c.quocgia,
                Theloai = c.theloai,
                Ngaycongchieu = c.NCC,
                Dotuoi = c.dotuoi,
                Dinhdang = (c.phim2d != null) ? c.phim2d.tendon : c.phim3d.tendon,
                PTDB = c.phim3d.PTDB,
                PTGD = c.phim2d.PTGD
            };

            foreach (var f in ds)
            {
                ListViewItem lv = new ListViewItem(f.Madon);

                lv.SubItems.Add(f.Tenphim);
                lv.SubItems.Add(f.Quocgia);
                lv.SubItems.Add(f.Theloai);
                lv.SubItems.Add(f.Ngaycongchieu.Value.ToShortDateString());

                lv.SubItems.Add(f.Dotuoi.ToString());
                lv.SubItems.Add(f.Dinhdang);
                lv.SubItems.Add(f.PTDB.ToString());
                lv.SubItems.Add(f.PTGD.ToString());
                TimeSpan dd = dateTime_CC.Value - DateTime.Now;
                if (dd.TotalDays < 7)
                {
                    lv.BackColor = Color.Yellow;
                }

                listView1.Items.Add(lv);
            }
        }
    }
}
