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
    public partial class frmTusBilgileri : Form
    {
        public frmTusBilgileri()
        {
            InitializeComponent();
        }

        private void btnOyunaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
