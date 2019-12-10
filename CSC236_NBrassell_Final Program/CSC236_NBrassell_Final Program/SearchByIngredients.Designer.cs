namespace CSC236_NBrassell_Final_Program
{
    partial class SearchByIngredients
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
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lstRecipies = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddIngr = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveIngr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredient:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredients:";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(15, 72);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(222, 329);
            this.lstIngredients.TabIndex = 2;
            // 
            // lstRecipies
            // 
            this.lstRecipies.FormattingEnabled = true;
            this.lstRecipies.Location = new System.Drawing.Point(324, 72);
            this.lstRecipies.Name = "lstRecipies";
            this.lstRecipies.Size = new System.Drawing.Size(194, 329);
            this.lstRecipies.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results:";
            // 
            // BtnAddIngr
            // 
            this.BtnAddIngr.Location = new System.Drawing.Point(243, 4);
            this.BtnAddIngr.Name = "BtnAddIngr";
            this.BtnAddIngr.Size = new System.Drawing.Size(76, 35);
            this.BtnAddIngr.TabIndex = 5;
            this.BtnAddIngr.Text = "Add Ingredient";
            this.BtnAddIngr.UseVisualStyleBackColor = true;
            this.BtnAddIngr.Click += new System.EventHandler(this.BtnAddIngr_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(243, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(244, 264);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(243, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(76, 9);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(161, 20);
            this.txtIngredient.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(*Only name of ingredient, not amount)";
            // 
            // btnRemoveIngr
            // 
            this.btnRemoveIngr.Location = new System.Drawing.Point(243, 72);
            this.btnRemoveIngr.Name = "btnRemoveIngr";
            this.btnRemoveIngr.Size = new System.Drawing.Size(75, 40);
            this.btnRemoveIngr.TabIndex = 11;
            this.btnRemoveIngr.Text = "Remove Ingredient";
            this.btnRemoveIngr.UseVisualStyleBackColor = true;
            this.btnRemoveIngr.Click += new System.EventHandler(this.BtnRemoveIngr_Click);
            // 
            // SearchByIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 432);
            this.Controls.Add(this.btnRemoveIngr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.BtnAddIngr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstRecipies);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchByIngredients";
            this.Text = "Search By Ingredients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.ListBox lstRecipies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddIngr;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveIngr;
    }
}