namespace RecipeDb
{
    partial class CookBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Recipe = new System.Windows.Forms.Label();
            this.ListRecipe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListIngredient = new System.Windows.Forms.ListBox();
            this.Ingredients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Recipe
            // 
            this.Recipe.AutoSize = true;
            this.Recipe.Location = new System.Drawing.Point(100, 37);
            this.Recipe.Name = "Recipe";
            this.Recipe.Size = new System.Drawing.Size(41, 13);
            this.Recipe.TabIndex = 0;
            this.Recipe.Text = "Recipe";
            // 
            // ListRecipe
            // 
            this.ListRecipe.FormattingEnabled = true;
            this.ListRecipe.Location = new System.Drawing.Point(59, 94);
            this.ListRecipe.Name = "ListRecipe";
            this.ListRecipe.Size = new System.Drawing.Size(133, 147);
            this.ListRecipe.TabIndex = 1;
            this.ListRecipe.SelectedIndexChanged += new System.EventHandler(this.ListRecipe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // ListIngredient
            // 
            this.ListIngredient.FormattingEnabled = true;
            this.ListIngredient.Location = new System.Drawing.Point(384, 94);
            this.ListIngredient.Name = "ListIngredient";
            this.ListIngredient.Size = new System.Drawing.Size(124, 147);
            this.ListIngredient.TabIndex = 3;
            // 
            // Ingredients
            // 
            this.Ingredients.AutoSize = true;
            this.Ingredients.Location = new System.Drawing.Point(404, 46);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(59, 13);
            this.Ingredients.TabIndex = 4;
            this.Ingredients.Text = "Ingredients";
            // 
            // CookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 766);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.ListIngredient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListRecipe);
            this.Controls.Add(this.Recipe);
            this.Name = "CookBook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CookBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recipe;
        private System.Windows.Forms.ListBox ListRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListIngredient;
        private System.Windows.Forms.Label Ingredients;
    }
}

