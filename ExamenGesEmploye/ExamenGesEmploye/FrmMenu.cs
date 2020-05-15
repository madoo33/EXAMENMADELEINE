using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGesEmploye
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        Form1 f1;
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearchild();
            
                f1 = new Form1();
                f1.MdiParent = this;
                f1.Show(); 
        }
        FrmEmploye f2;
        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearchild();
        
                f2 = new FrmEmploye();
                f2.MdiParent = this;
                f2.Show();
 
        }
        private void clearchild(){
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            }
    }
}
