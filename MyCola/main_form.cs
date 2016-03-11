using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCola
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUser cUser = createUser.Instance;
            cUser.MdiParent = this;
            if (cUser.Visible == true)
            {
                cUser.Activate();
            }
            else
            {
                createUser.Instance.Show();
            }

        }

        private void distributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            distributor dist = distributor.Instance;
            dist.MdiParent = this;
            if (dist.Visible == true)
            {
                dist.Activate();
            }
            else {
                distributor.Instance.Show();
            }
        }

        private void privilagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            privilages pri = privilages.Instance;
            pri.MdiParent = this;
            if (pri.Visible == true)
            {
                pri.Activate();
            }
            else {
                privilages.Instance.Show();
            }
        }
    }
}
