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
    public partial class createUser : Form
    {
        private static createUser singleton = null;
        public createUser()
        {
            InitializeComponent();
        }

        public static createUser Instance
        {
            get
            {
                if (createUser.singleton == null)
                {
                    createUser.singleton = new createUser();
                }
                return createUser.singleton;
            }
        }
    }
}
