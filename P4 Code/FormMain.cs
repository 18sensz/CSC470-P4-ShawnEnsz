using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FormLogin loginForm = new FormLogin();
            DialogResult result = loginForm.ShowDialog();
            while(!loginForm.authenticatedUser.isAuthenticated && result == DialogResult.OK)
            {

            }

            if(result != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Text = "Main- No Project Selected";
            }
        }
    }
}
