using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion
{
    public partial class frmExcursionLogin : Form
    {
        
        public frmExcursionLogin()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm do you want to Exit?", "Excursion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
                frmfirstpage ffp = new frmfirstpage();
                ffp.Show();
            }
            else
            {
                return;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(txtUsername.Text == "e" && txtPassword.Text == "")
            {
                frmTransaction transac = new frmTransaction();
                transac.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "m" && txtPassword.Text == "")
            {
                frmManagerForm manage = new frmManagerForm();
                manage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearText();
            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm do you want to Exit?", "Excursion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
