using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Views.ucNhanVien;
using DoAnNet001.Core;
using DoAnNet001.Models;
using DoAnNet001.Views.ucSanPham;
using DoAnNet001.Views.ucNhaCungCap;
using DoAnNet001.Views.ucKhachHang;
using DoAnNet001.Views.ucDonHang;
using DoAnNet001.Views.ucNhapHang;

namespace DoAnNet001.Views.ucHeThong
{
    public partial class ucDangNhap : UserControl
    {
        ChangeForm change = new ChangeForm();
        public ucDangNhap()
        {
            InitializeComponent();
            phanquyen();
        }
        protected void phanquyen()
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen == 2)
            {
                //btnCaiDat.Enabled = false;
                //btnNhapHang.Enabled = false;
                btnNhanVien.Enabled = false;
                btn_ThongKe.Enabled = false;
                btnNhaCungCap.Enabled = false;
            }
            else if (phanquyen == 3)
            {
                btnNhanVien.Enabled = false;
                btnNhanVien.Enabled = false;
                btn_ThongKe.Enabled = false;
                btn_KhachHang.Enabled = false;
                btn_DonHang.Enabled = false;
            }

        }
        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
       
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //viết cho phần menu
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {

            SanPhamUC sanPham = new SanPhamUC();
            change.change(sanPham);
        }

        private void btnNhaCungCap_Click_1(object sender, EventArgs e)
        {
            HangCungCap_uc nhacc = new HangCungCap_uc();
            change.change(nhacc);
        }

        private void btn_KhachHang_Click_1(object sender, EventArgs e)
        {
            KhachHang_UC khachhang = new KhachHang_UC();
            change.change(khachhang);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ucCaiDat.CatDat_UC catDat_ = new ucCaiDat.CatDat_UC();
            change.change(catDat_);
        }

        private void btn_DonHang_Click_1(object sender, EventArgs e)
        {
            DonHang_UC DonHang = new DonHang_UC();
            change.change(DonHang);
        }

        private void btn_ThongKe_Click_1(object sender, EventArgs e)
        {
            ucThongKe.ThongKe_UC thongKe_ = new ucThongKe.ThongKe_UC();
            change.change(thongKe_);
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ucheThong dangnhap = new ucheThong();
                change.change(dangnhap);
            }
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            NhanVienUC nhanvien = new NhanVienUC();
            change.change(nhanvien);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            NhapHang_UC NhapHang = new NhapHang_UC();
            change.change(NhapHang);
        }
    }
}
