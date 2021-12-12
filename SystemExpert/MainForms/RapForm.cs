using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SystemExpert.RapForms;

namespace SystemExpert.MainForms
{
    public partial class RapForm : Form
    {
        public RapForm()
        {
            InitializeComponent();
            start_form();
        }

        /// <summary>
        /// Функция возвращает свойства элементов к начальному
        /// </summary>
        private void start_form()
        {
            //retry_button.Visible = false; //кнопка "начать сначала" невидима
            question1_groupBox.Visible = true;
            question2_groupBox.Visible = false;
        }

        private void question1_YES_Click(object sender, EventArgs e)
        {
            Regional regional = new Regional();
            regional.Show();
        }

        private void question1_NO_Click(object sender, EventArgs e)
        {
            question1_groupBox.Visible = false;
            question2_groupBox.Visible = true;
        }
        private void question2_YES_Click(object sender, EventArgs e)
        {
            HardCore hardcore = new HardCore();
            hardcore.Show();
        }

        private void question2_NO_Click(object sender, EventArgs e)
        {
            Trap trap = new Trap();
            trap.Show();
        }

    }
}
