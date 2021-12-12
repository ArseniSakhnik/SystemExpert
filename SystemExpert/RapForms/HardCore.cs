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
    public partial class HardCore : Form
    {
        private readonly MainForm mainform;
        public HardCore(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
        }

        private void HardCore_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
