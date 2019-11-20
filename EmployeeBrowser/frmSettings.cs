using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeBrowser
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tBxConStr.Text != frmMain.Data.ConnectionString)
            { 
                FileStream fs1 = new FileStream("Settings.txt", FileMode.Create);
                StreamWriter wr = new StreamWriter(fs1);
                wr.WriteLine(tBxConStr.Text);
                wr.Close();
                frmMain.Data.ConnectionString = tBxConStr.Text;
                Application.Restart();
            }
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tBxConStr.Text = frmMain.Data.ConnectionString;
        }
    }
}
