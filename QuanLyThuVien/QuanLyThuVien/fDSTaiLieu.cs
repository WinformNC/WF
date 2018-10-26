﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using linQ;
enum CHUCNANG
{
    THEM, XOA, SUA
};
namespace QuanLyThuVien
{
    public partial class fDSTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;
        //SachBLL sachBLL = new SachBLL();
        //TheLoaiBLL theloaiBLL = new TheLoaiBLL();
        //ViTriBLL vitriBLL = new ViTriBLL();
        //TacGiaBLL tacgiaBLL = new TacGiaBLL();
        //NXBBLL nxbBLL = new NXBBLL();
        Conection conn = new Conection();
        string PathImg = "";

        public fDSTaiLieu()
        {
            InitializeComponent();
           // dtgvSach.DataSource = sachBLL.LoadSach();
            dtgvSach.DataSource = conn.loadSach();
        }

        private void loadCombobox()
        {
            cboNXB.DataSource = conn.loadNXB();
            cboNXB.ValueMember = "MANXB";
            cboNXB.DisplayMember = "TENNXB";

            cboTacGia.DataSource = conn.loadTacGia();
            cboTacGia.ValueMember = "MATACGIA";
            cboTacGia.DisplayMember = "TENTACGIA";

            cboTheLoai.DataSource = conn.loadTheLoai();
            cboTheLoai.ValueMember = "MATHELOAI";
            cboTheLoai.DisplayMember = "TENTHELOAI";

           cboViTri.DataSource = conn.loadViTri();
            cboViTri.ValueMember = "MAVITRI";
            cboViTri.DisplayMember = "MAVITRI";
        }

        private void loadDataGrid()
        {
            for (int i = 0; i < dtgvSach.Rows.Count; i++)
            {
                try
                {
                    string s = dtgvSach.Rows[i].Cells[17].Value.ToString();
                    dtgvSach.Rows[i].Cells[0].Value = Image.FromFile(dtgvSach["HINHANHSACH", i].Value.ToString());
                }
                catch
                {
                    dtgvSach.Rows[i].Cells[0].Value = Properties.Resources.Book_96px;
                }
            }
            //dtgvSach.Columns[1].SortMode = dtgvSach.Columns[2].SortMode = dtgvSach.Columns[3].SortMode = dtgvSach.Columns[4].SortMode = dtgvSach.Columns[5].SortMode = dtgvSach.Columns[6].SortMode = dtgvSach.Columns[7].SortMode = dtgvSach.Columns[8].SortMode = dtgvSach.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

            //dtgvSach.Columns[9].Visible = false;
        }

        private void fDSTaiLieu_Load(object sender, EventArgs e)
        {
            setBoolField(false);
            loadDataGrid();
            loadCombobox();
        }

        private void setBoolField(bool b)
        {
            btnLoadImage.Enabled = btnHuy.Enabled = btnLuu.Enabled = txtMa.Enabled = txtTen.Enabled = txtMoTa.Enabled = txtNamXB.Enabled = cboViTri.Enabled = cboTheLoai.Enabled = cboTacGia.Enabled = cboNXB.Enabled = b;
        }
        private void setBtn(bool b)
        {
            btnXoa.Enabled = btnSua.Enabled = b;
            setBoolField(b);
        }
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPEG|*.jpg|PNG|*.png";
            openfile.ShowDialog();
            if (openfile.FileName.Length != 0)
            {
                PathImg = openfile.FileName;
                picbxAnh.Image = Image.FromFile(PathImg);
            }
        }

      
        private void dtgvSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            PathImg = dtgvSach["HINHANHSACH", index].Value.ToString();
            picbxAnh.Load(PathImg);
           
            txtMa.Text = dtgvSach["MASACH", index].Value.ToString();
            txtTen.Text = dtgvSach["TENSACH", index].Value.ToString();
            cboTacGia.SelectedValue = dtgvSach["MATACGIA", index].Value.ToString();
            cboTheLoai.SelectedValue = dtgvSach["MATHELOAI", index].Value.ToString();
            cboNXB.SelectedValue = dtgvSach["MANXB", index].Value.ToString();
            cboViTri.SelectedValue = dtgvSach["MAVITRI", index].Value.ToString();
            txtMoTa.Text = dtgvSach["MOTA", index].Value.ToString();
            txtNamXB.Text = dtgvSach["NAMXB", index].Value.ToString();
            setBtn(true);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            setBoolField(true);
            txtMa.Focus();
            chucnang = CHUCNANG.THEM;
            them();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvSach.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa sách: " + dtgvSach.CurrentRow.Cells[2].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                xoa();
                dtgvSach.DataSource = conn.loadSach();
                loadDataGrid();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvSach.Rows.Count == 0)
            {
                return;
            }
            //DialogResult r = MessageBox.Show("Bạn có muốn sửa sách: " + dtgvSach.CurrentRow.Cells[2].Value.ToString(),
            //    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (r == DialogResult.Yes)
            //{
                sua();
                dtgvSach.DataSource = conn.loadSach();
                loadDataGrid();
                setBtn(false);
                btnLuu.Enabled = true;
            //}
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(conn.saveSach() == 1)
                MessageBox.Show("Lưu thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lưu thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            
        }
        // Chuc nang
        private void them()
        {
            if (conn.addSach(txtMa.Text, cboNXB.SelectedValue.ToString(), cboTheLoai.SelectedValue.ToString(), cboTacGia.SelectedValue.ToString(), cboViTri.SelectedValue.ToString(), txtTen.Text, txtNamXB.Text, PathImg, txtMoTa.Text, "1") == 1)
            {
                MessageBox.Show("Nhập thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            
                MessageBox.Show("Nhập không thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            if (conn.upSach(txtMa.Text, cboNXB.SelectedValue.ToString(), cboTheLoai.SelectedValue.ToString(), cboTacGia.SelectedValue.ToString(), cboViTri.SelectedValue.ToString(), txtTen.Text, txtNamXB.Text, PathImg, txtMoTa.Text, "1") == 1)
            {
                MessageBox.Show("Sửa thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Sửa không thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void xoa()
        {
            if (conn.delSach(txtMa.Text) == 1)
            {
                MessageBox.Show("Xóa thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Xóa không thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            loadDataGrid();
            loadCombobox();
            setBtn(false);
        }

      
    }
}