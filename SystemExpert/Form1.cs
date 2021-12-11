using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemExpert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start_form();
        }

        /// <summary>
        /// Функция возвращает свойства элементов к начальной
        /// </summary>
        private void start_form()
        {
            rock_button.Visible = true;
            rap_button.Visible = true;
            pop_button.Visible = true;
            rock_button.Enabled = true;
            rap_button.Enabled = true;
            pop_button.Enabled = true;
            retry_button.Visible = false; //кнопка "начать сначала" невидима
            rock_groupBox.Visible = false;
            rap_groupBox.Visible = false;
            pop_groupBox.Visible = false;
        }

        private void rock_button_Click(object sender, EventArgs e)
        {
            start_form();
            rock_button.Enabled = false; //нельзя снова выбрать рок
            retry_button.Visible = true;
            rock_groupBox.Visible = true; //показываем вопросы для РоКа
        }

        private void rap_button_Click(object sender, EventArgs e)
        {
            start_form();
            rap_button.Enabled = false; //нельзя снова выбрать рэп
            retry_button.Visible = true;
            rap_groupBox.Visible = true; //показываем вопросы для РэПа
        }

        private void pop_button_Click(object sender, EventArgs e)
        {
            start_form();
            pop_button.Enabled = false; //нельзя снова выбрать поп
            retry_button.Visible = true;
            pop_groupBox.Visible = true; //показываем вопросы для Жопы
        }


        /// <summary>
        /// Тупа вызываем start_form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retry_button_Click(object sender, EventArgs e)
        {
            start_form();
        }

        /// <summary>
        /// Радиокнопка "Да" для 1го вопроса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void question1True_CheckedChanged(object sender, EventArgs e)
        {
            metal_groupBox.Visible = true; //показываем групбокс для митола
        }

        /// <summary>
        /// Радиокнопка "Нет" для 1го вопроса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void question1False_CheckedChanged(object sender, EventArgs e)
        {
            question1.Visible = false; //скрываем первый вопрос
            question2.Visible = true; //показываем второй

            //скрываем два радиобокса для 1-го вопроса
            question1_True.Visible = false; 
            question1_False.Visible = false;

            //но показываем для 2-го
            question2_True.Visible = true;
            question2_False.Visible = true;
        }
    }
}