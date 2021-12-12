using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemExpert.MainForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rock_button_Click(object sender, EventArgs e)
        {
            RockForm rock = new RockForm();
            rock.Show();
        }

        private void rap_button_Click(object sender, EventArgs e)
        {
            RapForm rap = new RapForm();
            rap.Show();
        }

        private void pop_button_Click(object sender, EventArgs e)
        {
            PopForm pop = new PopForm();
            pop.Show();
        }
    }
}
