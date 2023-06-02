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
    public partial class loadFrm : DevExpress.XtraEditors.XtraForm
    {
        public loadFrm()
        {
            InitializeComponent();
        }

        private void loadFrm_Load(object sender, EventArgs e)
        {
            InitTimer();
        }

        private void fLoad()
        {
            timer1.Stop();
            this.Hide();
            var loginF = new loginFrm();
            loginF.Closed += (s, args) => this.Close();
            loginF.Show();
        }


        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fLoad();
        }
    }
}
