using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SystemExpert.MainForms;

namespace SystemExpert.RapForms
{
    public partial class Regional : Form
    {
        private readonly MainForm mainform;
        public Regional(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
        }

        private void Regional_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
