using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaGameWithEvents.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Start());

            }
            catch (ArgumentException ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Please choose hero", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
