using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_StudentClassroom
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void sınıflarıTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClassroom frm = new FormClassroom();
            frm.Show();
         
        }

        private void öğrencileriTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent frm = new FormStudent();
            frm.Show();
        }
    }
}
