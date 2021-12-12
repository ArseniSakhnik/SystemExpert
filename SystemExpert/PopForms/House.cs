using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SystemExpert.MainForms;

namespace SystemExpert.PopForms
{
    public partial class House : Form
    {
        private readonly MainForm mainform;
        public House(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
        }

        private void House_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
