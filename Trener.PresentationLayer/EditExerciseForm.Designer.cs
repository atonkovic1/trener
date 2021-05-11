
namespace Trener.PresentationLayer
{
    partial class EditExerciseForm
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
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textBoxExerciseDescription = new System.Windows.Forms.TextBox();
            this.labelExerciseDescription = new System.Windows.Forms.Label();
            this.labelFitnessLvl = new System.Windows.Forms.Label();
            this.labelExerciseName = new System.Windows.Forms.Label();
            this.comboBoxFitnessLvl = new System.Windows.Forms.ComboBox();
            this.textBoxExerciseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(369, 366);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(100, 33);
            this.btnDecline.TabIndex = 16;
            this.btnDecline.Text = "Odustani";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(223, 366);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Uredi";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // textBoxExerciseDescription
            // 
            this.textBoxExerciseDescription.Location = new System.Drawing.Point(223, 228);
            this.textBoxExerciseDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExerciseDescription.Name = "textBoxExerciseDescription";
            this.textBoxExerciseDescription.Size = new System.Drawing.Size(297, 22);
            this.textBoxExerciseDescription.TabIndex = 14;
            this.textBoxExerciseDescription.TextChanged += new System.EventHandler(this.textBoxExerciseDescription_TextChanged);
            // 
            // labelExerciseDescription
            // 
            this.labelExerciseDescription.AutoSize = true;
            this.labelExerciseDescription.Location = new System.Drawing.Point(157, 231);
            this.labelExerciseDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExerciseDescription.Name = "labelExerciseDescription";
            this.labelExerciseDescription.Size = new System.Drawing.Size(41, 17);
            this.labelExerciseDescription.TabIndex = 12;
            this.labelExerciseDescription.Text = "Opis:";
            // 
            // labelFitnessLvl
            // 
            this.labelFitnessLvl.AutoSize = true;
            this.labelFitnessLvl.Location = new System.Drawing.Point(157, 171);
            this.labelFitnessLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFitnessLvl.Name = "labelFitnessLvl";
            this.labelFitnessLvl.Size = new System.Drawing.Size(55, 17);
            this.labelFitnessLvl.TabIndex = 11;
            this.labelFitnessLvl.Text = "Težina:";
            // 
            // labelExerciseName
            // 
            this.labelExerciseName.AutoSize = true;
            this.labelExerciseName.Location = new System.Drawing.Point(157, 112);
            this.labelExerciseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExerciseName.Name = "labelExerciseName";
            this.labelExerciseName.Size = new System.Drawing.Size(47, 17);
            this.labelExerciseName.TabIndex = 10;
            this.labelExerciseName.Text = "Naziv:";
            // 
            // comboBoxFitnessLvl
            // 
            this.comboBoxFitnessLvl.FormattingEnabled = true;
            this.comboBoxFitnessLvl.Location = new System.Drawing.Point(223, 168);
            this.comboBoxFitnessLvl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFitnessLvl.Name = "comboBoxFitnessLvl";
            this.comboBoxFitnessLvl.Size = new System.Drawing.Size(297, 24);
            this.comboBoxFitnessLvl.TabIndex = 9;
            this.comboBoxFitnessLvl.SelectedIndexChanged += new System.EventHandler(this.comboBoxFitnessLvl_SelectedIndexChanged);
            // 
            // textBoxExerciseName
            // 
            this.textBoxExerciseName.Location = new System.Drawing.Point(223, 109);
            this.textBoxExerciseName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExerciseName.Name = "textBoxExerciseName";
            this.textBoxExerciseName.Size = new System.Drawing.Size(297, 22);
            this.textBoxExerciseName.TabIndex = 17;
            this.textBoxExerciseName.TextChanged += new System.EventHandler(this.textBoxExerciseName_TextChanged);
            // 
            // EditExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 485);
            this.Controls.Add(this.textBoxExerciseName);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textBoxExerciseDescription);
            this.Controls.Add(this.labelExerciseDescription);
            this.Controls.Add(this.labelFitnessLvl);
            this.Controls.Add(this.labelExerciseName);
            this.Controls.Add(this.comboBoxFitnessLvl);
            this.Name = "EditExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi vježbu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBoxExerciseDescription;
        private System.Windows.Forms.Label labelExerciseDescription;
        private System.Windows.Forms.Label labelFitnessLvl;
        private System.Windows.Forms.Label labelExerciseName;
        private System.Windows.Forms.ComboBox comboBoxFitnessLvl;
        private System.Windows.Forms.TextBox textBoxExerciseName;
    }
}