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
    public partial class Alt : Form
    {
        private readonly MainForm mainform;
        public Alt(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
        }
    }
}
