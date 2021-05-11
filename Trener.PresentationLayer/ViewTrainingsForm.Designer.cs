
namespace Trener.PresentationLayer
{
    partial class ViewTrainingsForm
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
            this.listTrainings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveTraining = new System.Windows.Forms.Button();
            this.btnEditTraining = new System.Windows.Forms.Button();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTrainings
            // 
            this.listTrainings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listTrainings.FullRowSelect = true;
            this.listTrainings.HideSelection = false;
            this.listTrainings.Location = new System.Drawing.Point(16, 15);
            this.listTrainings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listTrainings.MultiSelect = false;
            this.listTrainings.Name = "listTrainings";
            this.listTrainings.Size = new System.Drawing.Size(1033, 446);
            this.listTrainings.TabIndex = 2;
            this.listTrainings.UseCompatibleStateImageBehavior = false;
            this.listTrainings.View = System.Windows.Forms.View.Details;
            this.listTrainings.SelectedIndexChanged += new System.EventHandler(this.listTrainings_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Težina";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vježbe";
            this.columnHeader3.Width = 531;
            // 
            // btnRemoveTraining
            // 
            this.btnRemoveTraining.Enabled = false;
            this.btnRemoveTraining.Location = new System.Drawing.Point(687, 484);
            this.btnRemoveTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveTraining.Name = "btnRemoveTraining";
            this.btnRemoveTraining.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveTraining.TabIndex = 9;
            this.btnRemoveTraining.Text = "Obriši trening";
            this.btnRemoveTraining.UseVisualStyleBackColor = true;
            this.btnRemoveTraining.Click += new System.EventHandler(this.btnRemoveTraining_Click);
            // 
            // btnEditTraining
            // 
            this.btnEditTraining.Enabled = false;
            this.btnEditTraining.Location = new System.Drawing.Point(487, 484);
            this.btnEditTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditTraining.Name = "btnEditTraining";
            this.btnEditTraining.Size = new System.Drawing.Size(192, 41);
            this.btnEditTraining.TabIndex = 8;
            this.btnEditTraining.Text = "Uredi trening";
            this.btnEditTraining.UseVisualStyleBackColor = true;
            this.btnEditTraining.Click += new System.EventHandler(this.btnEditTraining_Click);
            // 
            // btnAddTraining
            // 
            this.btnAddTraining.Location = new System.Drawing.Point(175, 484);
            this.btnAddTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.Size = new System.Drawing.Size(192, 41);
            this.btnAddTraining.TabIndex = 7;
            this.btnAddTraining.Text = "Dodaj trening";
            this.btnAddTraining.UseVisualStyleBackColor = true;
            this.btnAddTraining.Click += new System.EventHandler(this.btnAddTraining_Click);
            // 
            // ViewTrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveTraining);
            this.Controls.Add(this.btnEditTraining);
            this.Controls.Add(this.btnAddTraining);
            this.Controls.Add(this.listTrainings);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewTrainingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treninzi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTrainingsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTrainings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRemoveTraining;
        private System.Windows.Forms.Button btnEditTraining;
        private System.Windows.Forms.Button btnAddTraining;
    }
}