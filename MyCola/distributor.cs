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
    public partial class distributor : Form
    {
        private static distributor singletone = null;
        public distributor()
        {
            InitializeComponent();
        }
        public static distributor Instance
        {
            get
            {
                if (distributor.singletone == null)
                {
                    distributor.singletone = new distributor();
                }
                return distributor.singletone;
            }
        }

        private void distributor_FormClosed(object sender, FormClosedEventArgs e)
        {
            distributor.singletone = null;
        }

        private void distributor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
