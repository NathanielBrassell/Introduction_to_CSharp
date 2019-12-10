namespace CSC236_NBrassell_Final_Program
{
    partial class AddRecipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.btnRemoveIngr = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxDringPair = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instructions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "(*Only name of ingredient, not amount)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(506, 10);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(184, 20);
            this.txtIngredient.TabIndex = 5;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(13, 74);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstructions.Size = new System.Drawing.Size(292, 355);
            this.txtInstructions.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "List of Ingredients:";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(506, 77);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(184, 355);
            this.lstIngredients.TabIndex = 8;
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.Location = new System.Drawing.Point(696, 11);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(75, 35);
            this.btnAddIngr.TabIndex = 9;
            this.btnAddIngr.Text = "Add Ingredient";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.BtnAddIngr_Click);
            // 
            // btnRemoveIngr
            // 
            this.btnRemoveIngr.Location = new System.Drawing.Point(696, 195);
            this.btnRemoveIngr.Name = "btnRemoveIngr";
            this.btnRemoveIngr.Size = new System.Drawing.Size(75, 34);
            this.btnRemoveIngr.TabIndex = 10;
            this.btnRemoveIngr.Text = "Remove Ingredient";
            this.btnRemoveIngr.UseVisualStyleBackColor = true;
            this.btnRemoveIngr.Click += new System.EventHandler(this.BtnRemoveIngr_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddRecipe.Location = new System.Drawing.Point(696, 319);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 55);
            this.btnAddRecipe.TabIndex = 11;
            this.btnAddRecipe.Text = "Add to Recipe Book";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.BtnAddRecipe_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(696, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditRecipe.Location = new System.Drawing.Point(696, 258);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(75, 55);
            this.btnEditRecipe.TabIndex = 13;
            this.btnEditRecipe.Text = "Edit Recipe";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.BtnEditRecipe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Drink Pair:";
            // 
            // cmbxDringPair
            // 
            this.cmbxDringPair.FormattingEnabled = true;
            this.cmbxDringPair.Items.AddRange(new object[] {
            "Coffee",
            "Tea",
            "Juice",
            "Wine",
            "Champagne",
            "Beer"});
            this.cmbxDringPair.Location = new System.Drawing.Point(340, 77);
            this.cmbxDringPair.Name = "cmbxDringPair";
            this.cmbxDringPair.Size = new System.Drawing.Size(121, 21);
            this.cmbxDringPair.TabIndex = 15;
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 443);
            this.Controls.Add(this.cmbxDringPair);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnRemoveIngr);
            this.Controls.Add(this.btnAddIngr);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRecipe";
            this.Text = "Add Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.Button btnRemoveIngr;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxDringPair;
    }
}