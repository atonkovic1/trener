
namespace Trener.PresentationLayer
{
    partial class ViewTrainingGroupsForm
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
            this.listTrainingGroups = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveTrainingGroup = new System.Windows.Forms.Button();
            this.btnEditTrainingGroup = new System.Windows.Forms.Button();
            this.btnAddTrainingGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTrainingGroups
            // 
            this.listTrainingGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listTrainingGroups.FullRowSelect = true;
            this.listTrainingGroups.HideSelection = false;
            this.listTrainingGroups.Location = new System.Drawing.Point(16, 15);
            this.listTrainingGroups.Margin = new System.Windows.Forms.Padding(4);
            this.listTrainingGroups.MultiSelect = false;
            this.listTrainingGroups.Name = "listTrainingGroups";
            this.listTrainingGroups.Size = new System.Drawing.Size(1033, 446);
            this.listTrainingGroups.TabIndex = 3;
            this.listTrainingGroups.UseCompatibleStateImageBehavior = false;
            this.listTrainingGroups.View = System.Windows.Forms.View.Details;
            this.listTrainingGroups.SelectedIndexChanged += new System.EventHandler(this.listTrainingGroups_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trening";
            this.columnHeader2.Width = 225;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Termini";
            this.columnHeader3.Width = 388;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mjesečna cijena";
            this.columnHeader4.Width = 242;
            // 
            // btnRemoveTrainingGroup
            // 
            this.btnRemoveTrainingGroup.Enabled = false;
            this.btnRemoveTrainingGroup.Location = new System.Drawing.Point(687, 484);
            this.btnRemoveTrainingGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveTrainingGroup.Name = "btnRemoveTrainingGroup";
            this.btnRemoveTrainingGroup.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveTrainingGroup.TabIndex = 12;
            this.btnRemoveTrainingGroup.Text = "Obriši grupu";
            this.btnRemoveTrainingGroup.UseVisualStyleBackColor = true;
            this.btnRemoveTrainingGroup.Click += new System.EventHandler(this.btnRemoveTrainingGroup_Click);
            // 
            // btnEditTrainingGroup
            // 
            this.btnEditTrainingGroup.Enabled = false;
            this.btnEditTrainingGroup.Location = new System.Drawing.Point(487, 484);
            this.btnEditTrainingGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTrainingGroup.Name = "btnEditTrainingGroup";
            this.btnEditTrainingGroup.Size = new System.Drawing.Size(192, 41);
            this.btnEditTrainingGroup.TabIndex = 11;
            this.btnEditTrainingGroup.Text = "Uredi grupu";
            this.btnEditTrainingGroup.UseVisualStyleBackColor = true;
            this.btnEditTrainingGroup.Click += new System.EventHandler(this.btnEditTrainingGroup_Click);
            // 
            // btnAddTrainingGroup
            // 
            this.btnAddTrainingGroup.Location = new System.Drawing.Point(175, 484);
            this.btnAddTrainingGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTrainingGroup.Name = "btnAddTrainingGroup";
            this.btnAddTrainingGroup.Size = new System.Drawing.Size(192, 41);
            this.btnAddTrainingGroup.TabIndex = 10;
            this.btnAddTrainingGroup.Text = "Dodaj grupu";
            this.btnAddTrainingGroup.UseVisualStyleBackColor = true;
            this.btnAddTrainingGroup.Click += new System.EventHandler(this.btnAddTrainingGroup_Click);
            // 
            // ViewTrainingGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveTrainingGroup);
            this.Controls.Add(this.btnEditTrainingGroup);
            this.Controls.Add(this.btnAddTrainingGroup);
            this.Controls.Add(this.listTrainingGroups);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewTrainingGroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTrainingGroupsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTrainingGroups;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRemoveTrainingGroup;
        private System.Windows.Forms.Button btnEditTrainingGroup;
        private System.Windows.Forms.Button btnAddTrainingGroup;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}