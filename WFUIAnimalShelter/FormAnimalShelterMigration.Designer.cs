namespace WFUIAnimalShelter
{
    partial class FormAnimalShelterMigration
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
            this.buttonMigration = new System.Windows.Forms.Button();
            this.buttonShowAnimals = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFileLocalization = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonCreateTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMigration
            // 
            this.buttonMigration.Location = new System.Drawing.Point(482, 160);
            this.buttonMigration.Name = "buttonMigration";
            this.buttonMigration.Size = new System.Drawing.Size(162, 54);
            this.buttonMigration.TabIndex = 0;
            this.buttonMigration.Text = "Start data migration";
            this.buttonMigration.UseVisualStyleBackColor = true;
            this.buttonMigration.Click += new System.EventHandler(this.buttonMigration_Click);
            // 
            // buttonShowAnimals
            // 
            this.buttonShowAnimals.Location = new System.Drawing.Point(482, 242);
            this.buttonShowAnimals.Name = "buttonShowAnimals";
            this.buttonShowAnimals.Size = new System.Drawing.Size(162, 64);
            this.buttonShowAnimals.TabIndex = 1;
            this.buttonShowAnimals.Text = "Show animals";
            this.buttonShowAnimals.UseVisualStyleBackColor = true;
            this.buttonShowAnimals.Click += new System.EventHandler(this.buttonShowAnimals_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(216, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(359, 29);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Animal Shelter Data Migration";
            // 
            // labelFileLocalization
            // 
            this.labelFileLocalization.AutoSize = true;
            this.labelFileLocalization.Location = new System.Drawing.Point(358, 91);
            this.labelFileLocalization.Name = "labelFileLocalization";
            this.labelFileLocalization.Size = new System.Drawing.Size(108, 17);
            this.labelFileLocalization.TabIndex = 3;
            this.labelFileLocalization.Text = "File localization:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(482, 91);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(162, 22);
            this.textBoxPath.TabIndex = 4;
            this.textBoxPath.Text = "Specify file path here";
            this.textBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCreateTable
            // 
            this.buttonCreateTable.Location = new System.Drawing.Point(101, 91);
            this.buttonCreateTable.Name = "buttonCreateTable";
            this.buttonCreateTable.Size = new System.Drawing.Size(122, 65);
            this.buttonCreateTable.TabIndex = 5;
            this.buttonCreateTable.Text = "Create Table";
            this.buttonCreateTable.UseVisualStyleBackColor = true;
            this.buttonCreateTable.Click += new System.EventHandler(this.buttonCreateTable_Click);
            // 
            // FormAnimalShelterMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateTable);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelFileLocalization);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonShowAnimals);
            this.Controls.Add(this.buttonMigration);
            this.Name = "FormAnimalShelterMigration";
            this.Text = "Migration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMigration;
        private System.Windows.Forms.Button buttonShowAnimals;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFileLocalization;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonCreateTable;
    }
}