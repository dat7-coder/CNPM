﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.View;

namespace QLCuaHang.View
{
    public partial class FormMain : Form
    {
        string MaNV = "", MatKhau = "";

        public FormMain()
        {
            InitializeComponent();   
        }

        public FormMain(string MaNV, string MatKhau)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;

            if (!MaNV.Contains("QL")) {
                mnuDanhMuc.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien frmNhanVien = new FormNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            FormQLKhachHang frmKhachHang = new FormQLKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            f.ShowDialog();
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
