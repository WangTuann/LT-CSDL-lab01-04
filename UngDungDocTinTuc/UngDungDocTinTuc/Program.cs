using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungDocTinTuc.IO;
using UngDungDocTinTuc.Model;

namespace UngDungDocTinTuc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            INewRepository repository = new NewRepository();
            var manager = new NewFeedManager(repository);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(manager));
        }
    }
}
