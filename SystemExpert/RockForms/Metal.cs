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
        private readonly MainForm mainform;
        public Metal(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
        }

        private void Metal_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
