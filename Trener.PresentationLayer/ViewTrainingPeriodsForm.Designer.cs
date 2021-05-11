
namespace Trener.PresentationLayer
{
    partial class ViewTrainingPeriodsForm
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
            this.listTrainingPeriods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveTrainingPeriod = new System.Windows.Forms.Button();
            this.btnEditTrainingPeriod = new System.Windows.Forms.Button();
            this.btnAddTrainingPeriod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTrainingPeriods
            // 
            this.listTrainingPeriods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listTrainingPeriods.FullRowSelect = true;
            this.listTrainingPeriods.HideSelection = false;
            this.listTrainingPeriods.Location = new System.Drawing.Point(16, 15);
            this.listTrainingPeriods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listTrainingPeriods.MultiSelect = false;
            this.listTrainingPeriods.Name = "listTrainingPeriods";
            this.listTrainingPeriods.Size = new System.Drawing.Size(1033, 446);
            this.listTrainingPeriods.TabIndex = 3;
            this.listTrainingPeriods.UseCompatibleStateImageBehavior = false;
            this.listTrainingPeriods.View = System.Windows.Forms.View.Details;
            this.listTrainingPeriods.SelectedIndexChanged += new System.EventHandler(this.listTrainingPeriods_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Šifra";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dan u tjednu";
            this.columnHeader2.Width = 275;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Početak";
            this.columnHeader3.Width = 197;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Završetak";
            this.columnHeader4.Width = 190;
            // 
            // btnRemoveTrainingPeriod
            // 
            this.btnRemoveTrainingPeriod.Enabled = false;
            this.btnRemoveTrainingPeriod.Location = new System.Drawing.Point(687, 484);
            this.btnRemoveTrainingPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveTrainingPeriod.Name = "btnRemoveTrainingPeriod";
            this.btnRemoveTrainingPeriod.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveTrainingPeriod.TabIndex = 12;
            this.btnRemoveTrainingPeriod.Text = "Obriši termin";
            this.btnRemoveTrainingPeriod.UseVisualStyleBackColor = true;
            this.btnRemoveTrainingPeriod.Click += new System.EventHandler(this.btnRemoveTrainingPeriod_Click);
            // 
            // btnEditTrainingPeriod
            // 
            this.btnEditTrainingPeriod.Enabled = false;
            this.btnEditTrainingPeriod.Location = new System.Drawing.Point(487, 484);
            this.btnEditTrainingPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditTrainingPeriod.Name = "btnEditTrainingPeriod";
            this.btnEditTrainingPeriod.Size = new System.Drawing.Size(192, 41);
            this.btnEditTrainingPeriod.TabIndex = 11;
            this.btnEditTrainingPeriod.Text = "Uredi termin";
            this.btnEditTrainingPeriod.UseVisualStyleBackColor = true;
            this.btnEditTrainingPeriod.Click += new System.EventHandler(this.btnEditTrainingPeriod_Click);
            // 
            // btnAddTrainingPeriod
            // 
            this.btnAddTrainingPeriod.Location = new System.Drawing.Point(175, 484);
            this.btnAddTrainingPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTrainingPeriod.Name = "btnAddTrainingPeriod";
            this.btnAddTrainingPeriod.Size = new System.Drawing.Size(192, 41);
            this.btnAddTrainingPeriod.TabIndex = 10;
            this.btnAddTrainingPeriod.Text = "Dodaj termin";
            this.btnAddTrainingPeriod.UseVisualStyleBackColor = true;
            this.btnAddTrainingPeriod.Click += new System.EventHandler(this.btnAddTrainingPeriod_Click);
            // 
            // ViewTrainingPeriodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveTrainingPeriod);
            this.Controls.Add(this.btnEditTrainingPeriod);
            this.Controls.Add(this.btnAddTrainingPeriod);
            this.Controls.Add(this.listTrainingPeriods);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewTrainingPeriodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termini";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTrainingPeriodsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTrainingPeriods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRemoveTrainingPeriod;
        private System.Windows.Forms.Button btnEditTrainingPeriod;
        private System.Windows.Forms.Button btnAddTrainingPeriod;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}