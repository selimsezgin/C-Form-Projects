using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteElmak
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("Kullanıcı adı: admin \nŞifre: admin087", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Run(new Form1());
        }
    }
}
