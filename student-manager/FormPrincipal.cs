using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_manager
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastratEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsInserirEstudante inserirEstudante = new FormsInserirEstudante();
            inserirEstudante.Show(this);
        }

        private void gerenciarEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
