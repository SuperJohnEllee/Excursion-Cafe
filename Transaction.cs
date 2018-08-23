using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Excursion
{
    public partial class frmTransaction : Form
    {
        SqlConnection con = new SqlConnection(@"Server = DESKTOP-VMK39V7\ROBADO;
                                                Initial Catalog = ExcursionSQL;
                                                Integrated Security = True;");
        SqlCommand cmd;
        SqlDataReader rdr;

        private void LoadTransaction()
        {
            con.Open();
            cmd = new SqlCommand(@"SELECT TransacID, Quantity, ProductName, Price, Date_Bought FROM ExTransaction;", con);
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                dataTransaction.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();
        }
        //private void LoadDeducting()
        //{
        //    int ingredientStock = 0;
        //    int NewingredientStock = 0;

        //    for (int i = 0; i < dataTransaction.Rows.Count; i++)
        //    {
        //        ingredientStock = 0;
        //        NewingredientStock = 0;

        //        con.Open();
        //        cmd = new SqlCommand(@"SELECT Quantity_Needed, RecipeID FROM Recipe WHERE RecipeN = '"++"'", con);

        //        con.Close();
        //    }
        //        con.Open();
        //    cmd = new SqlCommand(@"SELECT MINUS(Ingredient_Quantity) FROM Ingredient", con);
        //    rdr = cmd.ExecuteReader();
        //    con.Close();
        //}
        private void LoadProductForTransaction()
        {
            //con.Open();
            //cmd = new SqlCommand(@"SELECT ProdID, ProdName, PQuantity ", con);
            //con.Close();
        }

        public int[] Pieces = new int[10];
        public string[] ProdName = new string[10];
        public double[] Prices = new double[10];
        double Total;
        double Seniortotal;

        public frmTransaction()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmExcursionLogin login = new frmExcursionLogin();
            login.Show(); 
            this.Hide();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {         
            
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {

        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            txtCafeAuLait.Enabled = false;
            txtAnimalFries.Enabled = false;
            txtCapuchinnamon.Enabled = false;
            txtCheezyCarbonara.Enabled = false;
            txtCocoa.Enabled = false;
            txtNachos.Enabled = false;
            txtPotatoMarbles.Enabled = false;
            txtTunaPresto.Enabled = false;
            txtcash.Enabled = false;
            txttotal.Enabled = false;
            txtchange.Enabled = false;
            cmbpayment.Items.Add(" ");
            cmbpayment.Items.Add("Regular");
            cmbpayment.Items.Add("Senior");
            
        }

        private void chkCafeAuLait_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafeAuLait.Checked == true)
            {              
                txtCafeAuLait.Enabled = true;
                txtCafeAuLait.Focus();
                ProdName[1] = "Cafe Au Lait";
                Pieces[1] = Convert.ToInt32(txtCafeAuLait.Text);
                Prices[1] = 10.00;
            }
            else
            {
                txtCafeAuLait.Enabled = false;
                txtCafeAuLait.Text = "0";
                ProdName[1] = "";
                Pieces[1] = Convert.ToInt32(txtCafeAuLait.Text);           
            }
        }


        private void chkCocoa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCocoa.Checked == true)
            {
                txtCocoa.Enabled = true;
                txtCocoa.Focus();
                ProdName[2] = "Cocoa";
                Pieces[2] = Convert.ToInt32(txtCocoa.Text);
                Prices[2] = 20.00;
            } 
            else
            {
                txtCocoa.Enabled = false;
                txtCocoa.Text = "0";
                ProdName[2] = "";
                Pieces[2] = Convert.ToInt32(txtCocoa.Text);
            }
        }

        private void chkCapuchino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapuchinnamon.Checked == true)
            {
                txtCapuchinnamon.Enabled = true;
                txtCapuchinnamon.Focus();
                ProdName[3] = "Capuchinnamon";
                Pieces[3] = Convert.ToInt32(txtCapuchinnamon.Text);
                Prices[3] = 30.00;
            }
            else
            {
                txtCapuchinnamon.Enabled = false;
                txtCapuchinnamon.Text = "0";
                ProdName[3] = "";
                Pieces[3] = Convert.ToInt32(txtCapuchinnamon.Text);
            }
        }

        private void chkAnimalFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnimalFries.Checked == true)
            {
                txtAnimalFries.Enabled = true;
                txtAnimalFries.Focus();
                ProdName[4] = "Animal Fries";
                Pieces[4] = Convert.ToInt32(txtAnimalFries.Text);
                Prices[4] = 40.00;
            }
            else
            {
                txtAnimalFries.Enabled = false;
                txtAnimalFries.Text = "0";
                ProdName[4] = "";
                Pieces[4] = Convert.ToInt32(txtAnimalFries.Text);
            }
        }

        private void chkNachos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNachos.Checked == true)
            {
                txtNachos.Enabled = true;
                txtNachos.Focus();
                ProdName[5] = "Nachos";
                Pieces[5] = Convert.ToInt32(txtNachos.Text);
                Prices[5] = 50.00;
            }
            else
            {
                txtNachos.Enabled = false;
                txtNachos.Text = "0";
                ProdName[5] = "";
                Pieces[5] = Convert.ToInt32(txtNachos.Text);
            }
        }

        private void chkPotatoMarbles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPotatoMarbles.Checked == true)
            {
                txtPotatoMarbles.Enabled = true;
                txtPotatoMarbles.Focus();
                ProdName[6] = "Potato Marbles";
                Pieces[6] = Convert.ToInt32(txtPotatoMarbles.Text);
                Prices[6] = 60.00;
            }
            else
            {
                txtPotatoMarbles.Enabled = false;
                txtPotatoMarbles.Text = "0";
                ProdName[6] = "";
                Pieces[6] = Convert.ToInt32(txtPotatoMarbles.Text);
            }
        }

        private void chkCheezyCarbo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheezyCarbo.Checked == true)
            {
                txtCheezyCarbonara.Enabled = true;
                txtCheezyCarbonara.Focus();
                ProdName[7] = "Cheezy Carbonara";
                Pieces[7] = Convert.ToInt32(txtCheezyCarbonara.Text);
                Prices[7] = 70.00;
            }
            else
            {
                txtCheezyCarbonara.Enabled = false;
                txtCheezyCarbonara.Text = "0";
                ProdName[7] = "";
                Pieces[7] = Convert.ToInt32(txtCheezyCarbonara.Text);
            }
        }

        private void chkTunaPresto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTunaPresto.Checked == true)
            {
                txtTunaPresto.Enabled = true;
                txtTunaPresto.Focus();
                ProdName[8] = "Tuna Presto";
                Pieces[8] = Convert.ToInt32(txtTunaPresto.Text);
                Prices[8] = 80.00;
            }
            else
            {
                txtCheezyCarbonara.Enabled = false;
                txtTunaPresto.Text = "0";
                ProdName[8] = "";
                Pieces[8] = Convert.ToInt32(txtTunaPresto.Text);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBackTransaction_Click(object sender, EventArgs e)
        {
            frmExcursionLogin Login = new frmExcursionLogin();
            Login.Show();
            this.Hide();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {


            int ID = 1;
            for(int i = 1; i <= 10; i++)
            {
               try
               {
                   if (Pieces[i] != 0 && ProdName[i] != "")
                   {
                    dataTransaction.Rows.Add(ID, Pieces[i], ProdName[i], (Pieces[i] * Prices[i]), DateTime.Now.ToLongDateString());                   
                   }
               }
               catch
               {

               }

                #region Comment
                /*try
                {

                    ProdName[i] = "";
                    Pieces[i] = 0;

                }
                catch
                { 
                
                }*/
                #endregion
            }
            //ResetCheckBoxes();
        }

        private void txtCafeAuLait_TextChanged(object sender, EventArgs e)
        {
            if (txtCafeAuLait.Text != "0" || txtCafeAuLait.Text != "")
            {
                try
                {
                    Pieces[1] = Convert.ToInt32(txtCafeAuLait.Text);
                }
                catch
                { 
                
                }
            }
            else
            {
                Pieces[1] = 0;
            }
        }

        private void txtCocoa_TextChanged(object sender, EventArgs e)
        {
            if (txtCocoa.Text != "0" || txtCocoa.Text != "")
            {
                try
                {
                    Pieces[2] = Convert.ToInt32(txtCocoa.Text);
                }
                catch
                { 
                
                }
            }
            else
            {
                Pieces[2] = 0;
            }
        }

        private void txtCapuchinnamon_TextChanged(object sender, EventArgs e)
        {
            if (txtCapuchinnamon.Text != "0" || txtCapuchinnamon.Text != "")
            {
                try
                {
                    Pieces[3] = Convert.ToInt32(txtCapuchinnamon.Text);
                }
                catch
                { 
                
                }
            }
            else
            {
                Pieces[3] = 0;
            }
        }

        private void txtAnimalFries_TextChanged(object sender, EventArgs e)
        {
            if (txtAnimalFries.Text != "0" || txtAnimalFries.Text != "")
            {
                try
                {
                    Pieces[4] = Convert.ToInt32(txtAnimalFries.Text);
                }
                catch
                {
                    
                }
            }
            else
            {
                Pieces[4] = 0;
            }
        }

        private void txtNachos_TextChanged(object sender, EventArgs e)
        {
            if (txtNachos.Text != "0" || txtNachos.Text != "")
            {
                try
                {
                    Pieces[5] = Convert.ToInt32(txtNachos.Text);
                }
                catch
                { 
                
                }
            }
            else
            {
                Pieces[5] = 0;
            }
        }

        private void txtPotatoMarbles_TextChanged(object sender, EventArgs e)
        {
            if (txtPotatoMarbles.Text != "0" || txtPotatoMarbles.Text != "")
            {
                try
                {
                    Pieces[6] = Convert.ToInt32(txtPotatoMarbles.Text);
                }
                catch
                { 
                
                }
            }
            else
            {
                Pieces[6] = 0;
            }
        }

        private void txtCheezyCarbonara_TextChanged(object sender, EventArgs e)
        {
            if (txtCheezyCarbonara.Text != "0" || txtCheezyCarbonara.Text != "")
            {
                try
                {
                    Pieces[7] = Convert.ToInt32(txtCheezyCarbonara.Text);
                }
                catch
                { 
                
                }
            }
            else
            {
                Pieces[7] = 0;
            }
        }

        private void txtTunaPresto_TextChanged(object sender, EventArgs e)
        {
            if (txtTunaPresto.Text != "0" || txtTunaPresto.Text != "")
            {
                try
                {
                    Pieces[8] = Convert.ToInt32(txtTunaPresto.Text);
                }
                catch
                { 
                
                }
            }
            else
            {
                Pieces[8] = 0;
            }
        }

        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Text = "0";
                        else
                            func(control.Controls);
                };
            func(Controls);
        }
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataTransaction.Rows.Remove(dataTransaction.SelectedRows[0]);                  
        }
        private void btnRecordToRecordFrm_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
            con.Open();

            for (int j = 0; j < dataTransaction.Rows.Count; j++)
            {
                cmd = new SqlCommand(@"INSERT INTO ExTransaction (Quantity, ProductName, Price, Date_Bought)
                                       VALUES ('" + dataTransaction.Rows[j].Cells[1].Value.ToString() +
                                               "','" + dataTransaction.Rows[j].Cells[2].Value.ToString() + 
                                               "','" + dataTransaction.Rows[j].Cells[3].Value.ToString() + 
                                               "','" + dataTransaction.Rows[j].Cells[4].Value.ToString() + "');", con);
                
                cmd.ExecuteNonQuery();
            }




            //cmd = new SqlCommand(@"");
            con.Close();
            dataTransaction.Rows.Clear();
            cmbpayment.Text = " ";
            txtcash.Enabled = false;
            MessageBox.Show("Recorded Success");
            
        }

        double Change;
        double Cash;
        private void btnTotal_Click(object sender, EventArgs e)
        {


                if (txtcash.Text == "" || txtcash.Text == "0")
                {
                    MessageBox.Show("Please input cash amount");
                }
                if (MessageBox.Show("Confirm Oders?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cmbpayment.Text == "Regular" || cmbpayment.Text == "Senior")
                    {
                        Cash = Convert.ToInt32(txtcash.Text);
                        Change = Cash - Total;
                        txtchange.Text = Convert.ToString(Change);
                        txtchange.Text = string.Format("\u20B1{0}", Change);
                    }
                    if (cmbpayment.Text == "Senior")
                    {
                        Cash = Convert.ToInt32(txtcash.Text);
                        Change = Cash - Seniortotal;
                        txtchange.Text = Change.ToString();
                        txtchange.Text = string.Format("\u20B1{0}", Change);
                    }
                }
                else
                {
                    return;
                }
        }

        private void cmbpayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbpayment.Text == "Regular")
            {
                #region Comment
                /*if(dataTransaction.Rows[0].Cells[3].Value.ToString() == "0")
                {
                Total = (Convert.ToInt32(dataTransaction.Rows[0].Cells[3].Value.ToString()) + Convert.ToInt32(dataTransaction.Rows[1].Cells[3].Value.ToString()));
                }
                else
                {
                    dataTransaction.Rows[0].Cells[3].Value = 0;
                }*/
                #endregion

                Total = (Pieces[1] * Prices[1]) + (Pieces[2] * Prices[2]) +
                        (Pieces[3] * Prices[3]) + (Pieces[4] * Prices[4]) +
                        (Pieces[5] * Prices[5]) + (Pieces[6] * Prices[6]) +
                        (Pieces[7] * Prices[7]) + (Pieces[8] * Prices[8]);
                txttotal.Text = Convert.ToString(Total);
                txttotal.Text = string.Format("\u20B1{0}", Total);
                txtcash.Enabled = true;
                txtcash.Focus();
            }      

            if(cmbpayment.Text == " ")
            {

                txttotal.Text = "0";
                
            }
            if (cmbpayment.Text == "Senior")
            {
                Total = (Pieces[1] * Convert.ToInt32(Prices[1])) + (Pieces[2] * Convert.ToInt32(Prices[2])) +
                     (Pieces[3] * Convert.ToInt32(Prices[3])) + (Pieces[4] * Convert.ToInt32(Prices[4])) +
                     (Pieces[5] * Convert.ToInt32(Prices[5])) + (Pieces[6] * Convert.ToInt32(Prices[6])) +
                     (Pieces[7] * Convert.ToInt32(Prices[7])) + (Pieces[8] * Convert.ToInt32(Prices[8]));
                
                Seniortotal = Total - (.20 * Total);
                txttotal.Text = Seniortotal.ToString(); 
                txttotal.Text = Convert.ToString(Seniortotal);
                txttotal.Text = string.Format("\u20B1{0}", Seniortotal);
                txtcash.Enabled = true;
                txtcash.Focus();
            }
        }


    }
}
