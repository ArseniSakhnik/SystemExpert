using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SystemExpert.MainForms;

namespace SystemExpert
{
    public partial class Metal : Form
    {
        public Metal(MainForm mainform)
        {
            InitializeComponent();
            //mainform.Show();
        }

        private void Metal_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
