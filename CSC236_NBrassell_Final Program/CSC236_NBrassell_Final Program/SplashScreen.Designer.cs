namespace CSC236_NBrassell_Final_Program
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoTextDataSet1 = new CSC236_NBrassell_Final_Program.LogoTextDataSet1();
            this.splashScreenTextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splashScreenTextTableAdapter = new CSC236_NBrassell_Final_Program.LogoTextDataSet1TableAdapters.SplashScreenTextTableAdapter();
            this.tableAdapterManager = new CSC236_NBrassell_Final_Program.LogoTextDataSet1TableAdapters.TableAdapterManager();
            this.programNameLabel1 = new System.Windows.Forms.Label();
            this.nameAndTitleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenTextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 257);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // logoTextDataSet1
            // 
            this.logoTextDataSet1.DataSetName = "LogoTextDataSet1";
            this.logoTextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splashScreenTextBindingSource
            // 
            this.splashScreenTextBindingSource.DataMember = "SplashScreenText";
            this.splashScreenTextBindingSource.DataSource = this.logoTextDataSet1;
            // 
            // splashScreenTextTableAdapter
            // 
            this.splashScreenTextTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SplashScreenTextTableAdapter = this.splashScreenTextTableAdapter;
            this.tableAdapterManager.UpdateOrder = CSC236_NBrassell_Final_Program.LogoTextDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // programNameLabel1
            // 
            this.programNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splashScreenTextBindingSource, "ProgramName", true));
            this.programNameLabel1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameLabel1.Location = new System.Drawing.Point(12, 9);
            this.programNameLabel1.Name = "programNameLabel1";
            this.programNameLabel1.Size = new System.Drawing.Size(413, 59);
            this.programNameLabel1.TabIndex = 5;
            this.programNameLabel1.Text = "label3";
            // 
            // nameAndTitleLabel1
            // 
            this.nameAndTitleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splashScreenTextBindingSource, "NameAndTitle", true));
            this.nameAndTitleLabel1.Location = new System.Drawing.Point(128, 227);
            this.nameAndTitleLabel1.Name = "nameAndTitleLabel1";
            this.nameAndTitleLabel1.Size = new System.Drawing.Size(159, 23);
            this.nameAndTitleLabel1.TabIndex = 6;
            this.nameAndTitleLabel1.Text = "label1";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 308);
            this.ControlBox = false;
            this.Controls.Add(this.nameAndTitleLabel1);
            this.Controls.Add(this.programNameLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenTextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LogoTextDataSet1 logoTextDataSet1;
        private System.Windows.Forms.BindingSource splashScreenTextBindingSource;
        private LogoTextDataSet1TableAdapters.SplashScreenTextTableAdapter splashScreenTextTableAdapter;
        private LogoTextDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label programNameLabel1;
        private System.Windows.Forms.Label nameAndTitleLabel1;
    }
}