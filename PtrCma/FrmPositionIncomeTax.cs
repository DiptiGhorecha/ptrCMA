﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PtrCma
{
    public partial class FrmPositionIncomeTax : Form
    {
        public FrmPositionIncomeTax()
        {
            InitializeComponent();
        }


        private void FrmPositionIncomeTax_Load(object sender, EventArgs e)
        {
            Settings();
           

            FrmPositionIncomeTax frmIncome = new FrmPositionIncomeTax();
            frmIncome.MdiParent = this;
            frmIncome.StartPosition = FormStartPosition.CenterScreen;
            frmIncome.Show();
        }

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;

            foreach (Label lbl in Controls.OfType<Label>())
            {

                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;

            }

            lblTitle.BackColor = Global.lblbacktitle;
            lblTitle.ForeColor = Global.lblforetitle;

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FrmMDICma frmCma = new FrmMDICma();
                frmCma.Show();
            }
        }

      
    }
}
