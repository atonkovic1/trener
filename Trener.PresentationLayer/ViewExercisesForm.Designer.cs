
namespace Trener.PresentationLayer
{
    partial class ViewExercisesForm
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
            this.listExercises = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveExercise = new System.Windows.Forms.Button();
            this.btnEditExercise = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listExercises
            // 
            this.listExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listExercises.FullRowSelect = true;
            this.listExercises.HideSelection = false;
            this.listExercises.Location = new System.Drawing.Point(16, 15);
            this.listExercises.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listExercises.MultiSelect = false;
            this.listExercises.Name = "listExercises";
            this.listExercises.Size = new System.Drawing.Size(1033, 446);
            this.listExercises.TabIndex = 1;
            this.listExercises.UseCompatibleStateImageBehavior = false;
            this.listExercises.View = System.Windows.Forms.View.Details;
            this.listExercises.SelectedIndexChanged += new System.EventHandler(this.listExercises_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Težina";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opis";
            this.columnHeader3.Width = 531;
            // 
            // btnRemoveExercise
            // 
            this.btnRemoveExercise.Enabled = false;
            this.btnRemoveExercise.Location = new System.Drawing.Point(687, 484);
            this.btnRemoveExercise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveExercise.Name = "btnRemoveExercise";
            this.btnRemoveExercise.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveExercise.TabIndex = 6;
            this.btnRemoveExercise.Text = "Obriši vježbu";
            this.btnRemoveExercise.UseVisualStyleBackColor = true;
            this.btnRemoveExercise.Click += new System.EventHandler(this.btnRemoveExercise_Click);
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.Enabled = false;
            this.btnEditExercise.Location = new System.Drawing.Point(487, 484);
            this.btnEditExercise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.Size = new System.Drawing.Size(192, 41);
            this.btnEditExercise.TabIndex = 5;
            this.btnEditExercise.Text = "Uredi vježbu";
            this.btnEditExercise.UseVisualStyleBackColor = true;
            this.btnEditExercise.Click += new System.EventHandler(this.btnEditExercise_Click);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(175, 484);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(192, 41);
            this.btnAddExercise.TabIndex = 4;
            this.btnAddExercise.Text = "Dodaj vježbu";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // ViewExercisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveExercise);
            this.Controls.Add(this.btnEditExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.listExercises);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewExercisesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vježbe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewExercisesForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listExercises;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRemoveExercise;
        private System.Windows.Forms.Button btnEditExercise;
        private System.Windows.Forms.Button btnAddExercise;
    }
}