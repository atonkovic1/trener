
namespace Trener.PresentationLayer
{
    partial class EditTrainingGroupForm
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
            this.comboBoxTraining = new System.Windows.Forms.ComboBox();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelTraining = new System.Windows.Forms.Label();
            this.labelTrainingPeriods = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.listBoxTrainingPeriods = new System.Windows.Forms.ListBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelCurrency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTraining
            // 
            this.comboBoxTraining.FormattingEnabled = true;
            this.comboBoxTraining.Location = new System.Drawing.Point(223, 168);
            this.comboBoxTraining.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTraining.Name = "comboBoxTraining";
            this.comboBoxTraining.Size = new System.Drawing.Size(297, 24);
            this.comboBoxTraining.TabIndex = 0;
            this.comboBoxTraining.SelectedIndexChanged += new System.EventHandler(this.comboBoxTraining_SelectedIndexChanged);
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Location = new System.Drawing.Point(157, 112);
            this.labelGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(47, 17);
            this.labelGroupName.TabIndex = 1;
            this.labelGroupName.Text = "Naziv:";
            // 
            // labelTraining
            // 
            this.labelTraining.AutoSize = true;
            this.labelTraining.Location = new System.Drawing.Point(157, 171);
            this.labelTraining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTraining.Name = "labelTraining";
            this.labelTraining.Size = new System.Drawing.Size(61, 17);
            this.labelTraining.TabIndex = 2;
            this.labelTraining.Text = "Trening:";
            // 
            // labelTrainingPeriods
            // 
            this.labelTrainingPeriods.AutoSize = true;
            this.labelTrainingPeriods.Location = new System.Drawing.Point(157, 231);
            this.labelTrainingPeriods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrainingPeriods.Name = "labelTrainingPeriods";
            this.labelTrainingPeriods.Size = new System.Drawing.Size(59, 17);
            this.labelTrainingPeriods.TabIndex = 3;
            this.labelTrainingPeriods.Text = "Termini:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(223, 482);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Uredi";
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
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(223, 109);
            this.textBoxGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(297, 22);
            this.textBoxGroupName.TabIndex = 8;
            this.textBoxGroupName.TextChanged += new System.EventHandler(this.textBoxGroupName_TextChanged);
            // 
            // listBoxTrainingPeriods
            // 
            this.listBoxTrainingPeriods.FormattingEnabled = true;
            this.listBoxTrainingPeriods.ItemHeight = 16;
            this.listBoxTrainingPeriods.Location = new System.Drawing.Point(223, 231);
            this.listBoxTrainingPeriods.Name = "listBoxTrainingPeriods";
            this.listBoxTrainingPeriods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTrainingPeriods.Size = new System.Drawing.Size(297, 100);
            this.listBoxTrainingPeriods.TabIndex = 9;
            this.listBoxTrainingPeriods.SelectedIndexChanged += new System.EventHandler(this.listBoxTrainingPeriods_SelectedIndexChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(157, 362);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(113, 17);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Mjesečna cijena:";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(278, 362);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(124, 22);
            this.numericUpDownPrice.TabIndex = 11;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPrice.ThousandsSeparator = true;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(409, 364);
            this.labelCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(23, 17);
            this.labelCurrency.TabIndex = 12;
            this.labelCurrency.Text = "kn";
            // 
            // EditTrainingGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 560);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.listBoxTrainingPeriods);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelTrainingPeriods);
            this.Controls.Add(this.labelTraining);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.comboBoxTraining);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditTrainingGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi grupu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTraining;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelTraining;
        private System.Windows.Forms.Label labelTrainingPeriods;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.ListBox listBoxTrainingPeriods;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelCurrency;
    }
}