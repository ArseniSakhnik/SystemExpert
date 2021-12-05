using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemExpert.Entities;
using SystemExpert.Enums;
using SystemExpert.Services;

namespace SystemExpert
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            var genre = await GenreService.GetGenreByParent(GenreEnum.Поп);
            genre = await GenreService.GetGenreByParent(GenreEnum.Реп);
            genre = await GenreService.GetGenreByParent(GenreEnum.Рок);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}