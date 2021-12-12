using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SystemExpert.PopForms;

namespace SystemExpert.MainForms
{
    public partial class PopForm : Form
    {
        public PopForm()
        {
            InitializeComponent();
            start_form();
        }

        private void start_form()
        {
            //retry_button.Visible = false; //кнопка "начать сначала" невидима
            question1_groupBox.Visible = true;
            question2_groupBox.Visible = false;
        }

        private void question1_YES_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            disco.Show();
        }

        private void question1_NO_Click(object sender, EventArgs e)
        {
            question1_groupBox.Visible = false;
            question2_groupBox.Visible = true;
        }

        private void question2_YES_Click(object sender, EventArgs e)
        {
            House house = new House();
            house.Show();
        }

        private void question2_NO_Click(object sender, EventArgs e)
        {
            Trance trance = new Trance();
            trance.Show();
        }
    }
}
