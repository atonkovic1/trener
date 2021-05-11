
namespace Trener.PresentationLayer
{
    partial class AddTrainingPeriodForm
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
            this.comboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.labelPeriodStart = new System.Windows.Forms.Label();
            this.labelPeriodEnd = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.dtpPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBoxDayOfWeek
            // 
            this.comboBoxDayOfWeek.FormattingEnabled = true;
            this.comboBoxDayOfWeek.Location = new System.Drawing.Point(258, 109);
            this.comboBoxDayOfWeek.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
            this.comboBoxDayOfWeek.Size = new System.Drawing.Size(262, 24);
            this.comboBoxDayOfWeek.TabIndex = 0;
            this.comboBoxDayOfWeek.SelectedIndexChanged += new System.EventHandler(this.comboBoxDayOfWeek_SelectedIndexChanged);
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Location = new System.Drawing.Point(157, 112);
            this.labelDayOfWeek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(93, 17);
            this.labelDayOfWeek.TabIndex = 1;
            this.labelDayOfWeek.Text = "Dan u tjednu:";
            // 
            // labelPeriodStart
            // 
            this.labelPeriodStart.AutoSize = true;
            this.labelPeriodStart.Location = new System.Drawing.Point(157, 171);
            this.labelPeriodStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriodStart.Name = "labelPeriodStart";
            this.labelPeriodStart.Size = new System.Drawing.Size(63, 17);
            this.labelPeriodStart.TabIndex = 2;
            this.labelPeriodStart.Text = "Početak:";
            // 
            // labelPeriodEnd
            // 
            this.labelPeriodEnd.AutoSize = true;
            this.labelPeriodEnd.Location = new System.Drawing.Point(157, 231);
            this.labelPeriodEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriodEnd.Name = "labelPeriodEnd";
            this.labelPeriodEnd.Size = new System.Drawing.Size(75, 17);
            this.labelPeriodEnd.TabIndex = 3;
            this.labelPeriodEnd.Text = "Završetak:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(223, 366);
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
            this.btnDecline.Location = new System.Drawing.Point(369, 366);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(100, 33);
            this.btnDecline.TabIndex = 7;
            this.btnDecline.Text = "Odustani";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // dtpPeriodStart
            // 
            this.dtpPeriodStart.Checked = false;
            this.dtpPeriodStart.CustomFormat = "HH:mm";
            this.dtpPeriodStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodStart.Location = new System.Drawing.Point(258, 165);
            this.dtpPeriodStart.Name = "dtpPeriodStart";
            this.dtpPeriodStart.ShowUpDown = true;
            this.dtpPeriodStart.Size = new System.Drawing.Size(262, 22);
            this.dtpPeriodStart.TabIndex = 8;
            // 
            // dtpPeriodEnd
            // 
            this.dtpPeriodEnd.Checked = false;
            this.dtpPeriodEnd.CustomFormat = "HH:mm";
            this.dtpPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodEnd.Location = new System.Drawing.Point(258, 226);
            this.dtpPeriodEnd.Name = "dtpPeriodEnd";
            this.dtpPeriodEnd.ShowUpDown = true;
            this.dtpPeriodEnd.Size = new System.Drawing.Size(262, 22);
            this.dtpPeriodEnd.TabIndex = 9;
            // 
            // AddTrainingPeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 485);
            this.Controls.Add(this.dtpPeriodEnd);
            this.Controls.Add(this.dtpPeriodStart);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelPeriodEnd);
            this.Controls.Add(this.labelPeriodStart);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.comboBoxDayOfWeek);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTrainingPeriodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj termin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDayOfWeek;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Label labelPeriodStart;
        private System.Windows.Forms.Label labelPeriodEnd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.DateTimePicker dtpPeriodStart;
        private System.Windows.Forms.DateTimePicker dtpPeriodEnd;
    }
}