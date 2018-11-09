using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXOX
{
    public partial class frmGirisAyar : Form
    {
        public frmGirisAyar()
        {
            InitializeComponent();
        }

        private void btnOyunModu_Click(object sender, EventArgs e)
        {
            
            if (rdbPlayerVsPlayer.Checked)
            {
                this.Hide();
                frmPlayerVsPlayer frmPlayerVsPlayer = new frmPlayerVsPlayer();
                frmPlayerVsPlayer.StartPosition = FormStartPosition.CenterParent;  // frmPlayerVsPlayer .ShowDialog() olarak açılır
                frmPlayerVsPlayer.ShowDialog();
                this.Show();
            }
            else if(rdbPlayerVsComputer.Checked)
            {
                this.Hide();
                frmPlayerVsComputer frmPlayerVsComputer = new frmPlayerVsComputer();
                frmPlayerVsComputer.StartPosition = FormStartPosition.CenterParent;     // frmPlayerVsComputer .ShowDialog() olarak açılır
                frmPlayerVsComputer.ShowDialog();
                this.Show();
            }
            else if (rdbOnNetwork.Checked)
            {
                this.Hide();
                frmOnNetwork frmOnNetwork = new frmOnNetwork();
                frmOnNetwork.StartPosition = FormStartPosition.CenterParent;    // frmOnNetwork .ShowDialog() olarak açılır
                frmOnNetwork.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Oyun Modunu Seçin!");
            }
        }

        private void frmGirisAyar_Load(object sender, EventArgs e)
        {
            rdbPlayerVsPlayer.Checked = true;
        }
    }
}
