
namespace Trener.PresentationLayer
{
    partial class AddTrainingForm
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
            this.comboBoxFitnessLvl = new System.Windows.Forms.ComboBox();
            this.labelTrainingName = new System.Windows.Forms.Label();
            this.labelFitnessLvl = new System.Windows.Forms.Label();
            this.labelExercises = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.textBoxTrainingName = new System.Windows.Forms.TextBox();
            this.listBoxExercises = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxFitnessLvl
            // 
            this.comboBoxFitnessLvl.FormattingEnabled = true;
            this.comboBoxFitnessLvl.Location = new System.Drawing.Point(223, 168);
            this.comboBoxFitnessLvl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFitnessLvl.Name = "comboBoxFitnessLvl";
            this.comboBoxFitnessLvl.Size = new System.Drawing.Size(297, 24);
            this.comboBoxFitnessLvl.TabIndex = 0;
            this.comboBoxFitnessLvl.SelectedIndexChanged += new System.EventHandler(this.comboBoxFitnessLvl_SelectedIndexChanged);
            // 
            // labelTrainingName
            // 
            this.labelTrainingName.AutoSize = true;
            this.labelTrainingName.Location = new System.Drawing.Point(157, 112);
            this.labelTrainingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrainingName.Name = "labelTrainingName";
            this.labelTrainingName.Size = new System.Drawing.Size(47, 17);
            this.labelTrainingName.TabIndex = 1;
            this.labelTrainingName.Text = "Naziv:";
            // 
            // labelFitnessLvl
            // 
            this.labelFitnessLvl.AutoSize = true;
            this.labelFitnessLvl.Location = new System.Drawing.Point(157, 171);
            this.labelFitnessLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFitnessLvl.Name = "labelFitnessLvl";
            this.labelFitnessLvl.Size = new System.Drawing.Size(55, 17);
            this.labelFitnessLvl.TabIndex = 2;
            this.labelFitnessLvl.Text = "Težina:";
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Location = new System.Drawing.Point(157, 231);
            this.labelExercises.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(55, 17);
            this.labelExercises.TabIndex = 3;
            this.labelExercises.Text = "Vježbe:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(223, 482);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Dodaj";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(369, 482);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(100, 33);
            this.btnDecline.TabIndex = 7;
            this.btnDecline.Text = "Odustani";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // textBoxTrainingName
            // 
            this.textBoxTrainingName.Location = new System.Drawing.Point(223, 109);
            this.textBoxTrainingName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTrainingName.Name = "textBoxTrainingName";
            this.textBoxTrainingName.Size = new System.Drawing.Size(297, 22);
            this.textBoxTrainingName.TabIndex = 8;
            this.textBoxTrainingName.TextChanged += new System.EventHandler(this.textBoxTrainingName_TextChanged);
            // 
            // listBoxExercises
            // 
            this.listBoxExercises.FormattingEnabled = true;
            this.listBoxExercises.ItemHeight = 16;
            this.listBoxExercises.Location = new System.Drawing.Point(223, 231);
            this.listBoxExercises.Name = "listBoxExercises";
            this.listBoxExercises.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxExercises.Size = new System.Drawing.Size(297, 180);
            this.listBoxExercises.TabIndex = 9;
            this.listBoxExercises.SelectedIndexChanged += new System.EventHandler(this.listBoxExercises_SelectedIndexChanged);
            // 
            // AddTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 560);
            this.Controls.Add(this.listBoxExercises);
            this.Controls.Add(this.textBoxTrainingName);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.labelFitnessLvl);
            this.Controls.Add(this.labelTrainingName);
            this.Controls.Add(this.comboBoxFitnessLvl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj trening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFitnessLvl;
        private System.Windows.Forms.Label labelTrainingName;
        private System.Windows.Forms.Label labelFitnessLvl;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.TextBox textBoxTrainingName;
        private System.Windows.Forms.ListBox listBoxExercises;
    }
}