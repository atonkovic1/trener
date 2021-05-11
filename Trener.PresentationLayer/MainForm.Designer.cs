
namespace Trener.PresentationLayer
{
    partial class MainForm
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
            this.btnViewClientDebts = new System.Windows.Forms.Button();
            this.btnViewClients = new System.Windows.Forms.Button();
            this.btnViewTrainingGroups = new System.Windows.Forms.Button();
            this.btnViewExercises = new System.Windows.Forms.Button();
            this.btnViewTrainings = new System.Windows.Forms.Button();
            this.btnViewTrainingPeriods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewClientDebts
            // 
            this.btnViewClientDebts.Location = new System.Drawing.Point(170, 210);
            this.btnViewClientDebts.Name = "btnViewClientDebts";
            this.btnViewClientDebts.Size = new System.Drawing.Size(195, 36);
            this.btnViewClientDebts.TabIndex = 0;
            this.btnViewClientDebts.Text = "Dugovanja klijenata";
            this.btnViewClientDebts.UseVisualStyleBackColor = true;
            this.btnViewClientDebts.Click += new System.EventHandler(this.btnViewClientDebts_Click);
            // 
            // btnViewClients
            // 
            this.btnViewClients.Location = new System.Drawing.Point(170, 168);
            this.btnViewClients.Name = "btnViewClients";
            this.btnViewClients.Size = new System.Drawing.Size(195, 36);
            this.btnViewClients.TabIndex = 1;
            this.btnViewClients.Text = "Klijenti";
            this.btnViewClients.UseVisualStyleBackColor = true;
            this.btnViewClients.Click += new System.EventHandler(this.btnViewClients_Click);
            // 
            // btnViewTrainingGroups
            // 
            this.btnViewTrainingGroups.Location = new System.Drawing.Point(430, 124);
            this.btnViewTrainingGroups.Name = "btnViewTrainingGroups";
            this.btnViewTrainingGroups.Size = new System.Drawing.Size(195, 37);
            this.btnViewTrainingGroups.TabIndex = 2;
            this.btnViewTrainingGroups.Text = "Grupe";
            this.btnViewTrainingGroups.UseVisualStyleBackColor = true;
            this.btnViewTrainingGroups.Click += new System.EventHandler(this.btnViewTrainingGroups_Click);
            // 
            // btnViewExercises
            // 
            this.btnViewExercises.Location = new System.Drawing.Point(430, 252);
            this.btnViewExercises.Name = "btnViewExercises";
            this.btnViewExercises.Size = new System.Drawing.Size(195, 36);
            this.btnViewExercises.TabIndex = 3;
            this.btnViewExercises.Text = "Vježbe";
            this.btnViewExercises.UseVisualStyleBackColor = true;
            this.btnViewExercises.Click += new System.EventHandler(this.btnViewExercises_Click);
            // 
            // btnViewTrainings
            // 
            this.btnViewTrainings.Location = new System.Drawing.Point(430, 210);
            this.btnViewTrainings.Name = "btnViewTrainings";
            this.btnViewTrainings.Size = new System.Drawing.Size(195, 36);
            this.btnViewTrainings.TabIndex = 4;
            this.btnViewTrainings.Text = "Treninzi";
            this.btnViewTrainings.UseVisualStyleBackColor = true;
            this.btnViewTrainings.Click += new System.EventHandler(this.btnViewTrainings_Click);
            // 
            // btnViewTrainingPeriods
            // 
            this.btnViewTrainingPeriods.Location = new System.Drawing.Point(430, 167);
            this.btnViewTrainingPeriods.Name = "btnViewTrainingPeriods";
            this.btnViewTrainingPeriods.Size = new System.Drawing.Size(195, 37);
            this.btnViewTrainingPeriods.TabIndex = 5;
            this.btnViewTrainingPeriods.Text = "Termini";
            this.btnViewTrainingPeriods.UseVisualStyleBackColor = true;
            this.btnViewTrainingPeriods.Click += new System.EventHandler(this.btnViewTrainingPeriods_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewTrainingPeriods);
            this.Controls.Add(this.btnViewTrainings);
            this.Controls.Add(this.btnViewExercises);
            this.Controls.Add(this.btnViewTrainingGroups);
            this.Controls.Add(this.btnViewClients);
            this.Controls.Add(this.btnViewClientDebts);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trener";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewClientDebts;
        private System.Windows.Forms.Button btnViewClients;
        private System.Windows.Forms.Button btnViewTrainingGroups;
        private System.Windows.Forms.Button btnViewExercises;
        private System.Windows.Forms.Button btnViewTrainings;
        private System.Windows.Forms.Button btnViewTrainingPeriods;
    }
}