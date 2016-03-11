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
    public partial class privilages : Form
    {
        private static privilages singletone = null;
        public privilages()
        {
            InitializeComponent();
        }
        public static privilages Instance
        {
            get
            {
                if (privilages.singletone == null)
                {
                    privilages.singletone = new privilages();
                }
                return privilages.singletone;
            }
        }

        private void privilages_FormClosed(object sender, FormClosedEventArgs e)
        {
            privilages.singletone = null;
        }

    }
}
