using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniprojeto
{
    public partial class mdiPrincipal : Form
    {
        private int childFormNumber = 0;

        public mdiPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro frm= new frmCadastro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frm= new frmCategoria();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
