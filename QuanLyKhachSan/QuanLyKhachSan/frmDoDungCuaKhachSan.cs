﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BangKhachSan;

namespace QuanLyKhachSan
{
    public partial class frmDoDungCuaKhachSan : Form
    {
        public frmDoDungCuaKhachSan()
        {
            InitializeComponent();
        }

        private void TxtMaDD_TextChanged(object sender, EventArgs e)
        {

        }
        BUS_DoDung dd = new BUS_DoDung();
        public void HienThi()
        {
            dgvDoDung.DataSource = dd.HienThiDoDung2();
        }
        private void dgvDoDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDD.Text = dgvDoDung.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDD.Text = dgvDoDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvDoDung.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonViTinh.Text = dgvDoDung.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaNhap.Text = dgvDoDung.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
