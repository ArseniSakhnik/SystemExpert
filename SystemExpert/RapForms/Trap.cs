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
    public partial class Trap : Form
    {
        private readonly MainForm mainform;
        public Trap(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
        }

        private void Trap_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
