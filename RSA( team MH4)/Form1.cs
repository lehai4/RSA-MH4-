using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA__team_MH4_
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void thuậtToánRSAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormRSA rsa = new FormRSA();
            rsa.ShowDialog();
        }

        private void thôngTinThànhViênNhómMH4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMember member = new FormMember();
            member.ShowDialog();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

       
    }
    }
