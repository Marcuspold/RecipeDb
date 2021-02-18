using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RecipeDb
{
    public partial class CookBook : Form
    {
        string connectionString;
        SqlConnection connection;
        public CookBook()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RecipeDb.Properties.Settings.RecipeConnectionString"].ConnectionString;
        }

        private void CookBook_Load(object sender, EventArgs e)
        {
            PopulateRecipe();
            
        }
        private void PopulateRecipe()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                ListRecipe.DisplayMember = "Name";
                ListRecipe.ValueMember = "Id";
                ListRecipe.DataSource = recipeTable;
            }
        }
        private void PopulateIngredients()
        {
            string query = "SELECT Ingredient.Name FROM Ingredient JOIN RecipeIngredient ON Ingredient.Id = RecipeIngredient.IngredientId WHERE RecipeIngredient.RecipeId = @RecipeId";
            using(connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                //get recipe id from the ListRecipe ListBox
                command.Parameters.AddWithValue("@RecipeId", ListRecipe.SelectedValue);
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                ListIngredient.DisplayMember = "Name";
                ListIngredient.ValueMember = "Id";
                ListIngredient.DataSource = ingredientTable;
            }
        }

        private void ListRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredients();
        }
    }
}
