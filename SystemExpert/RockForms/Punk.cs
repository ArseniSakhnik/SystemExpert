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
    public partial class Punk : Form
    {
        private readonly MainForm mainform;
        public Punk(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
        }


        /// <summary>
        /// Закрываем форму и отображаем главную
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Punk_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }

}
