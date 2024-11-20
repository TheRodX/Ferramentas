using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnGerirColaboradores_Click(object sender, EventArgs e)
        {
            frmGerirColaboradores frm  = new frmGerirColaboradores();
            frm.ShowDialog();
        }

        private void btnGerirFerramentas_Click(object sender, EventArgs e)
        {
            frmGerirFerramentas frm = new frmGerirFerramentas();
            frm.ShowDialog();
        }

        private void btnGerirRequesicoes_Click(object sender, EventArgs e)
        {
            frmGerirRequesicoes frm = new frmGerirRequesicoes();
            frm.ShowDialog();
        }
    }
}
