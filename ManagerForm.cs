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
    public partial class frmManagerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server = DESKTOP-VMK39V7\ROBADO;
                                                Initial Catalog = ExcursionSQL;
                                                Integrated Security = True;");
        SqlCommand cmd;
        SqlDataReader rdr;

        public frmManagerForm()
        {
            InitializeComponent();
        }
        private void LoadRecord()
        {
            dataRecord.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"select t.TransacID, t.Quantity, t.ProductName, t.Price, t.Date_Bought FROM ExTransaction t
                    left outer join ExRecord r
                    ON t.TransacID = r.TransacID", con);

            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                dataRecord.Rows.Add(rdr[0].ToString(),rdr[1].ToString(),rdr[2].ToString(),rdr[3].ToString(),rdr[4].ToString());
            }
            con.Close();
        }

        private void LoadComboSearch()
        {
            cmbSearchRecipe.Items.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT ProdName FROM Product", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbSearchRecipe.Items.Add(rdr[0].ToString());
            }
            con.Close();
        }
        private void LoadIngredients()
        {
            dataIngredients.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT IngredientID, IngredientName, SUM(Ingredient_Quantity) AS 'Ingredient Quantity', Ingredient_Unit FROM Ingredient GROUP BY IngredientID, IngredientName, Ingredient_Unit", con);
            
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                dataIngredients.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }
            con.Close();
        }

        
        private void LoadProducts()
        {
            cmbProdName.Items.Clear();
            dataProducts.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT ProdID ,ProdName, ProdType, ProdPrice from Product", con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                dataProducts.Rows.Add(rdr[0].ToString(),rdr[1].ToString(),rdr[2].ToString(), rdr[3].ToString());
            }
            con.Close();
        }

        private void LoadRecipe()
        {
            dataRecipe.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"select p.ProdName, i.IngredientName,SUM(r.Quantity_Needed) AS 'Quantity Needed' FROM Product p INNER JOIN 
                                   Recipe r ON p.ProdID = r.ProdID INNER JOIN 
                                   Ingredient i ON i.IngredientID = r.IngredientID GROUP BY p.ProdName, i.IngredientName ", con);
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                dataRecipe.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString());
            }
            con.Close();         
        }

        private void ClearData()
        {
            //Ingredient
            txtIngreName.Clear();
            txtIngredientQuantity.Clear();
            txtIngredientUnit.Clear();

            //Recipe
            
            
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //LoadIng();
            pnlPurchase.Hide();
            pnlAddingProduct.Hide();
            pnlAddIngredients.Hide();
            pnlProduct.Hide();
            panelHome.Hide();
            pnlRecord.Hide();
            pnlingredient.Show();
            pnlRecipe.Hide();
            btnUpdate.Enabled = false;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            pnlPurchase.Hide();
            pnlAddingProduct.Hide();
            pnlAddIngredients.Hide();
            pnlAddIngredients.Hide();
            pnlRecipe.Hide();
            pnlProduct.Hide();
            panelHome.Show();
            pnlRecord.Hide();
            pnlingredient.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            pnlPurchase.Hide();
            pnlRecipe.Hide();
            pnlAddingProduct.Hide();
            pnlAddIngredients.Hide();
            pnlAddIngredients.Hide();
            pnlProduct.Hide();
            pnlRecord.Show();
            pnlingredient.Hide();
            panelHome.Hide();
            LoadRecord();
        }
        
        private void frmManagerForm_Load(object sender, EventArgs e)
        {
            #region Comment
            //    con.Open();
        //    cmd = new SqlCommand(@"SELECT Ingredient_Quantity FROM Ingredient WHERE IngredientName = 'Cheese'", con);
        //    string result = cmd.ExecuteScalar().ToString();

        //    if (double.Parse(result) < 9)
        //    {
        //        MessageBox.Show(result);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Qty exceed 100");
        //    }
            //    con.Close();
            #endregion

            //txtQuantityNeed.Hide();
            //label9.Hide();
            //txtQuantityIngre.Hide();
            //label15.Hide();
            //txtUpdateIngredients.Hide();
            //txtIDofIngredient.Hide();
            pnlPurchase.Hide();
            LoadPurchaseForm();
            dataRecipeOfProduct.Hide();
            cmbSearchRecipe.Items.Add("Recipes");
            LoadIngredients();
            LoadComboSearch();
            pnlAddIngredients.Hide();
            pnlAddingProduct.Hide();
            label14.Hide();
            txtProdID.Hide();
            LoadRecipe();
            pnlProduct.Hide();
            pnlRecipe.Hide();
            LoadRecord();
            panelHome.Show();
            pnlRecord.Hide();
            pnlingredient.Hide();
            pnlAddingIngredient.Hide();
            txtIngreID.Hide();
            lblingreID.Hide();
        }

        private void LoadProd()
        {
            cmbProdName.Items.Clear();
            con.Open();

            cmd = new SqlCommand("SELECT ProdName FROM Product",con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbProdName.Items.Add(rdr[0].ToString());
            }

            con.Close();
        }
        
        public string prodID;
        private void GetProdID()
        {

            con.Open();
            cmd = new SqlCommand("SELECT ProdID FROM Product WHERE ProdName = '"+cmbProdName.Text+"'", con);
            rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                prodID = rdr[0].ToString();
            }
                con.Close();
        }

        private void LoadIngre()
        {
            
            cmbIngreName.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT IngredientName FROM Ingredient", con);
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                cmbIngreName.Items.Add(rdr[0].ToString());
            }
            con.Close();
        }

        public string IngredientID;
        private void GetIngredientID()
        {
           
            con.Open();
            cmd = new SqlCommand("SELECT IngredientID FROM Ingredient WHERE IngredientName = '"+cmbIngreName.Text+"'", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                IngredientID = rdr[0].ToString();
            }
            con.Close();
        }
        private void btnIngredientAdd_Click(object sender, EventArgs e)
        {
            if (txtIngreName.Text != "" || txtIngredientQuantity.Text != "" || txtIngredientUnit.Text != "")
            {
                    con.Open();
                    cmd = new SqlCommand(@"INSERT INTO Ingredient (IngredientName, Ingredient_Quantity, Ingredient_Unit) 
                                           VALUES 
                                           ('"+txtIngreName.Text +"','" + txtIngredientQuantity.Text + "','" + txtIngredientUnit.Text + "');", con);
                    //string result = cmd.ExecuteNonQuery().ToString();

                    //if (double.Parse(result) < 9)
                    //{
                    //    MessageBox.Show(result);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Qty exceed 100");
                    //}    
                    cmd.ExecuteNonQuery();
                    con.Close();

                    LoadIngredients();
                    MessageBox.Show("Ingredient Successfully Added!", "SUCCESS!");                         
            }
            else
            {
                MessageBox.Show("Please input all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearData();
        }

        private void pnlingredient_Paint(object sender, PaintEventArgs e)
        {
            txtIngreID.Enabled = false;
            
        }

        private void btnDoneAddingIngredients_Click(object sender, EventArgs e)
        {
            pnlAddingIngredient.Hide();
        }

        private void btnAddIngredientPanel_Click(object sender, EventArgs e)
        {
            pnlAddingIngredient.Show();
            txtIngreName.Focus();
        }

        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {
            frmExcursionLogin Login = new frmExcursionLogin();
            Login.Show();
            this.Hide();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            pnlRecord.Hide();
            pnlPurchase.Hide();
            LoadComboSearch();
            pnlingredient.Hide();
            LoadIngre();
            LoadProd();
            pnlAddingProduct.Hide();
            panelHome.Hide();
            pnlProduct.Hide();
            pnlRecipe.Show();
            pnlAddIngredients.Hide();
            lblRecipeID.Hide();
            txtRecipeID.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataRecord.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"select t.TransacID, t.Quantity, t.ProductName, t.Price, t.Date_Bought FROM ExTransaction t
                    left outer join ExRecord r
                    ON t.TransacID = r.TransacID WHERE t.Date_Bought LIKE '%" + dateTimePicker1.Text + "%';", con);
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                dataRecord.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();
            
        }

        private void pnlRecord_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            pnlAddIngredients.Show();
            pnlRecord.Hide();
            panelHome.Hide();
            pnlingredient.Hide();
        }

        private void pnlAddIngredients_Paint(object sender, PaintEventArgs e)
        {
            
            txtRecipeID.Enabled = false;
            
        }

        private void btnRecipeAddIngredients_Click(object sender, EventArgs e)
        {
            if (cmbProdName.Text == "" || cmbIngreName.Text == "" || txtQuantityNeeded.Text == "")
            {
                MessageBox.Show("Fill the missing blanks", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GetIngredientID();
                GetProdID();
                con.Open();

                cmd = new SqlCommand(@"INSERT INTO Recipe(ProdID, IngredientID, Quantity_Needed)
                                   VALUES
                                   ('" + prodID + "','" + IngredientID + "','" + txtQuantityNeeded.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product Added!","SUCCESS!");
                txtQuantityNeeded.Clear();
                cmbProdName.Text = "";
                cmbIngreName.Text = "";
                LoadRecipe();
                
                
            }
        }



        private void cmbIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {



            
        }

        private void ShowRecipeIngridients()
        {
            dataRecipeOfProduct.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT IngredientName, Quantity_Needed, Ingredient_Unit FROM Recipe inner join Product
            ON Recipe.ProdID = Product.ProdID Inner join Ingredient On Recipe.IngredientID = Ingredient.IngredientID WHERE ProdName = '"+cmbSearchRecipe.Text+"'",con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataRecipeOfProduct.Rows.Add(rdr[0].ToString(),rdr[1].ToString(),rdr[2].ToString());
            }

            con.Close();
        }
        private void cmbRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchRecipe.Text == "Recipes")
            {
                dataRecipe.Show();
                dataRecipeOfProduct.Hide();
            }
            else
            {
                dataRecipeOfProduct.Show();
                dataRecipe.Hide();
                ShowRecipeIngridients();

            }
        }
        #region Ingredients DropDown
        private void cmbIngredients_DropDown(object sender, EventArgs e)
        {

        }
        #endregion

        private void pnlRecipe_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnRecipeDoneIngredient_Click(object sender, EventArgs e)
        {
            pnlAddIngredients.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlPurchase.Hide();
            pnlAddIngredients.Hide();
            pnlAddIngredients.Hide();
            pnlProduct.Show();
            pnlRecipe.Hide();
            pnlingredient.Hide();
            pnlRecord.Hide();
            panelHome.Hide();
        }

        private void txtIngName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnADDProduct_Click(object sender, EventArgs e)
        {
            if(txtProdPrice.Text == "" || txtProdType.Text == "" || txtProdName.Text == "")
            {
                MessageBox.Show("Fill the missing blanks","ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO Product(ProdName, ProdType, ProdPrice) 
                                   VALUES
                                   ('"+txtProdName.Text+"','"+txtProdType.Text+"', '"+txtProdPrice.Text+"')", con);
            cmd.ExecuteNonQuery();
            
            con.Close();
            LoadProducts();
            LoadPurchaseForm();
            MessageBox.Show("Successfully Added!");
            txtProdID.Clear();
            txtProdName.Clear();
            txtProdPrice.Clear();
            txtProdType.Clear();

            }
        }

        private void pnlProduct_Paint(object sender, PaintEventArgs e)
        {
            LoadProducts();
        }

        private void cmbRecipename_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"select ProdName FROM Product p left outer JOIN Recipe r ON p.RecipeID = r.RecipeID", con);
            rdr = cmd.ExecuteReader();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAddingProduct.Show();
            btnUpdateProduct.Enabled = false;
        }

        private void btnDoneAddingProduct_Click(object sender, EventArgs e)
        {
            pnlAddingProduct.Hide();
        }

        private void dataProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count != 0)
            {
                txtProdID.Text = dataProducts.SelectedRows[0].Cells[0].Value.ToString();
                txtProdName.Text = dataProducts.SelectedRows[0].Cells[1].Value.ToString();
                txtProdType.Text = dataProducts.SelectedRows[0].Cells[2].Value.ToString();
                txtProdPrice.Text = dataProducts.SelectedRows[0].Cells[3].Value.ToString();

                btnUpdateProduct.Enabled = true;
                btnADDProduct.Enabled = false;
            }
           
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            dataProducts.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"UPDATE Product SET ProdName = '"+txtProdName.Text+"', ProdType = '"+txtProdType.Text
              +"', ProdPrice = '"+txtProdPrice.Text+"' WHERE ProdID = '"+txtProdID.Text+"';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Updated!","SUCCESS!");
            LoadProducts();

            
            txtProdID.Clear();
            txtProdName.Clear();
            txtProdPrice.Clear();
            txtProdType.Clear();
            btnADDProduct.Enabled = true;
            btnUpdateProduct.Enabled = false;
        }

        private void pnlAddingProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbProdName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataIngredients_SelectionChanged(object sender, EventArgs e)
        {

            if (dataIngredients.SelectedRows.Count != 0)
            {
                txtIngreID.Text = dataIngredients.SelectedRows[0].Cells[0].Value.ToString();
                txtIngreName.Text = dataIngredients.SelectedRows[0].Cells[1].Value.ToString();
                txtIngredientQuantity.Text = dataIngredients.SelectedRows[0].Cells[2].Value.ToString();
                txtIngredientUnit.Text = dataIngredients.SelectedRows[0].Cells[3].Value.ToString();
                btnIngredientAdd.Enabled = false;
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"UPDATE Ingredient SET IngredientName = '" + txtIngreName.Text + 
                                   "', Ingredient_Quantity = '" + txtIngredientQuantity.Text + 
                                   "', Ingredient_Unit = '" + txtIngredientUnit.Text + 
                                   "' WHERE IngredientID = '" + txtIngreID.Text + "' ;", con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadIngredients();
            MessageBox.Show("Update Successful", "Success");
            txtIngreID.Clear();
            txtIngreName.Clear();
            txtIngredientQuantity.Clear();
            txtIngredientUnit.Clear();
            btnIngredientAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            pnlRecipe.Hide();
            pnlRecord.Hide();
            panelHome.Hide();
            pnlProduct.Hide();
            pnlingredient.Hide();          
            pnlPurchase.Show();
            LoadPurchaseForm();
        }
        private void LoadPurchaseForm()
        {
            dataPurchase.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"select p.ProdID, p.ProdName, r.Quantity_Needed,
                                   i.IngredientID, i.IngredientName, i.Ingredient_Quantity, i.Ingredient_Unit
                                   FROM Ingredient i INNER JOIN Recipe r ON i.IngredientID = r.IngredientID 
                                   INNER JOIN Product p ON p.ProdID = r.ProdID", con);
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                dataPurchase.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString());
            }
            con.Close();
        }
        private void btnPurchaseItem_Click(object sender, EventArgs e)
        {
            //if (dataPurchase.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Please Select Order");
            //}
            //else
            //{
                if (txtNumberOfItem.Text == "")
                {
                    MessageBox.Show("Please Input OrderERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    txtQuantityNeed.Text = ((from DataGridViewRow row in dataPurchase.Rows
                                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString());
                    txtQuantityIngre.Text = (from DataGridViewRow row in dataPurchase.Rows
                                             where row.Cells[5].FormattedValue.ToString() != string.Empty
                                             select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    double NumberOfItemPurchase = Convert.ToDouble(txtNumberOfItem.Text);

                    double QuantityNeed = Convert.ToDouble(txtQuantityNeed.Text);
                    double IngredientNeed = Convert.ToDouble(txtQuantityIngre.Text);

                    double Totalneed = QuantityNeed * NumberOfItemPurchase;
                    double ReducedIngredient = IngredientNeed - Totalneed;


                    txtUpdateIngredients.Text = Convert.ToString(ReducedIngredient);

                    //if (dataPurchase.SelectedRows.Count != 0 && txtNumberOfItem.Text != "")
                    //{



                        //if (Totalneed > IngredientNeed)
                        //{
                        //    MessageBox.Show("Not enough ingredients\n" + dataPurchase.SelectedRows[0].Cells[5].Value +
                        //                     "" + dataPurchase.SelectedRows[0].Cells[6].Value +
                        //                     " of " + dataPurchase.SelectedRows[0].Cells[4].Value + " Left in your Stocks");
                        //    txtQuantityIngre.Clear();
                        //    txtQuantityNeed.Clear();
                        //    txtNumberOfItem.Clear();
                        //    txtUpdateIngredients.Clear();
                        //    txtIDofIngredient.Clear();

                        //}
                        //else
                        //{
                    con.Open();
                            cmd = new SqlCommand(@"UPDATE Ingredient SET Ingredient_Quantity = '" + txtUpdateIngredients.Text +
                                                   "' WHERE IngredientID = '" + txtIDofIngredient.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            LoadIngredients();
                            MessageBox.Show("Purchase Success!");
                            txtQuantityIngre.Clear();
                            txtQuantityNeed.Clear();
                            txtNumberOfItem.Clear();
                            txtUpdateIngredients.Clear();
                            txtIDofIngredient.Clear();
                            LoadPurchaseForm();
                        //}
                    //}
                }
            //}
        }

        private void dataPurchase_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataPurchase.SelectedRows.Count != 0)
            //{
            //    txtQuantityNeed.Text = dataPurchase.SelectedRows[0].Cells[2].Value.ToString();
            //    txtQuantityIngre.Text = dataPurchase.SelectedRows[0].Cells[5].Value.ToString();
            //    txtIDofIngredient.Text = dataPurchase.SelectedRows[0].Cells[3].Value.ToString();
            //}
        }

        private void pnlPurchase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIDofIngredient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearchForProduct_Click(object sender, EventArgs e)
        {
            dataPurchase.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"select p.ProdID, p.ProdName, r.Quantity_Needed, i.IngredientID, i.IngredientName, i.Ingredient_Quantity, Ingredient_Unit
                                   FROM Ingredient i INNER JOIN Recipe r ON i.IngredientID = r.IngredientID 
                                   INNER JOIN Product p ON p.ProdID = r.ProdID  WHERE p.ProdName LIKE '%"+txtSearchForProduct.Text+"%';", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataPurchase.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString());
            }
            con.Close();
            
        }

        private void dataPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPurchaseForm();
            txtSearchForProduct.Clear();
        }
    }
}
