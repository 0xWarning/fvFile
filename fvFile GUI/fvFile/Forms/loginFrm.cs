using fvFile.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fvFile.Forms
{
    public partial class loginFrm : DevExpress.XtraEditors.XtraForm
    {
        private AuthAPI AAPI = new AuthAPI();

        public loginFrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (AAPI.Login(logEmailEdit.Text, logPassEdit.Text))
            {
                this.Hide();
                var mainF = new mainFrm();
                mainF.Closed += (s, args) => this.Close();
                mainF.Show();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AAPI.Register(regNameEdit.Text, regEmailEdit.Text, regPassEdit.Text);
        }
    }
}
