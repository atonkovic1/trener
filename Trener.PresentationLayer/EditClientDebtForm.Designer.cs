
namespace Trener.PresentationLayer
{
    partial class EditClientDebtForm
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
            this.labelCurrency = new System.Windows.Forms.Label();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelClientInDebt = new System.Windows.Forms.Label();
            this.comboBoxClientInDebt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(357, 171);
            this.labelCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(23, 17);
            this.labelCurrency.TabIndex = 17;
            this.labelCurrency.Text = "kn";
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
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(223, 228);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(297, 22);
            this.textBoxDescription.TabIndex = 14;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(223, 169);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(127, 22);
            this.numericUpDownAmount.TabIndex = 13;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.ThousandsSeparator = true;
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(157, 231);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(41, 17);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Opis:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(157, 171);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(45, 17);
            this.labelAmount.TabIndex = 11;
            this.labelAmount.Text = "Iznos:";
            // 
            // labelClientInDebt
            // 
            this.labelClientInDebt.AutoSize = true;
            this.labelClientInDebt.Location = new System.Drawing.Point(157, 112);
            this.labelClientInDebt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientInDebt.Name = "labelClientInDebt";
            this.labelClientInDebt.Size = new System.Drawing.Size(55, 17);
            this.labelClientInDebt.TabIndex = 10;
            this.labelClientInDebt.Text = "Dužnik:";
            // 
            // comboBoxClientInDebt
            // 
            this.comboBoxClientInDebt.Enabled = false;
            this.comboBoxClientInDebt.FormattingEnabled = true;
            this.comboBoxClientInDebt.Location = new System.Drawing.Point(223, 108);
            this.comboBoxClientInDebt.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClientInDebt.Name = "comboBoxClientInDebt";
            this.comboBoxClientInDebt.Size = new System.Drawing.Size(297, 24);
            this.comboBoxClientInDebt.TabIndex = 9;
            // 
            // EditClientDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 485);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelClientInDebt);
            this.Controls.Add(this.comboBoxClientInDebt);
            this.Name = "EditClientDebtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi dugovanje";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelClientInDebt;
        private System.Windows.Forms.ComboBox comboBoxClientInDebt;
    }
}