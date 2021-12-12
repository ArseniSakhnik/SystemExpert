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
            string[] types = GetTypesForPunk();
            string[] genres = GetGenresForPunk();

            label1.Text = types[0];
            label2.Text = types[1];
            label3.Text = types[2];
            label4.Text = types[3];
            label5.Text = types[4];

            linkLabel1.Text = genres[0];
            linkLabel2.Text = genres[1];
            linkLabel3.Text = genres[2];
            linkLabel4.Text = genres[3];
            linkLabel5.Text = genres[4];
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
