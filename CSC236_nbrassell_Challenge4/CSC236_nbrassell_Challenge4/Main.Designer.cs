namespace CSC236_nbrassell_Challenge4
{
    partial class frmMain
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
            this.lstEmployeeList = new System.Windows.Forms.ListBox();
            this.btnAddProdWorker = new System.Windows.Forms.Button();
            this.btnAddShiftSuper = new System.Windows.Forms.Button();
            this.btnAddTeamLead = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEmployeeList
            // 
            this.lstEmployeeList.FormattingEnabled = true;
            this.lstEmployeeList.Location = new System.Drawing.Point(12, 38);
            this.lstEmployeeList.Name = "lstEmployeeList";
            this.lstEmployeeList.Size = new System.Drawing.Size(237, 186);
            this.lstEmployeeList.TabIndex = 0;
            // 
            // btnAddProdWorker
            // 
            this.btnAddProdWorker.Location = new System.Drawing.Point(12, 230);
            this.btnAddProdWorker.Name = "btnAddProdWorker";
            this.btnAddProdWorker.Size = new System.Drawing.Size(75, 50);
            this.btnAddProdWorker.TabIndex = 1;
            this.btnAddProdWorker.Text = "Add Production Worker...";
            this.btnAddProdWorker.UseVisualStyleBackColor = true;
            this.btnAddProdWorker.Click += new System.EventHandler(this.BtnAddProdWorker_Click);
            // 
            // btnAddShiftSuper
            // 
            this.btnAddShiftSuper.Location = new System.Drawing.Point(93, 230);
            this.btnAddShiftSuper.Name = "btnAddShiftSuper";
            this.btnAddShiftSuper.Size = new System.Drawing.Size(75, 50);
            this.btnAddShiftSuper.TabIndex = 2;
            this.btnAddShiftSuper.Text = "Add Shift Supervisor...";
            this.btnAddShiftSuper.UseVisualStyleBackColor = true;
            this.btnAddShiftSuper.Click += new System.EventHandler(this.BtnAddShiftSuper_Click);
            // 
            // btnAddTeamLead
            // 
            this.btnAddTeamLead.Location = new System.Drawing.Point(174, 230);
            this.btnAddTeamLead.Name = "btnAddTeamLead";
            this.btnAddTeamLead.Size = new System.Drawing.Size(75, 50);
            this.btnAddTeamLead.TabIndex = 3;
            this.btnAddTeamLead.Text = "Add Team Leader...";
            this.btnAddTeamLead.UseVisualStyleBackColor = true;
            this.btnAddTeamLead.Click += new System.EventHandler(this.BtnAddTeamLead_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(255, 57);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(255, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddTeamLead);
            this.Controls.Add(this.btnAddShiftSuper);
            this.Controls.Add(this.btnAddProdWorker);
            this.Controls.Add(this.lstEmployeeList);
            this.Name = "frmMain";
            this.Text = "Employee List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployeeList;
        private System.Windows.Forms.Button btnAddProdWorker;
        private System.Windows.Forms.Button btnAddShiftSuper;
        private System.Windows.Forms.Button btnAddTeamLead;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

