
namespace Trener.PresentationLayer
{
    partial class AddClientForm
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
            this.labelOib = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.textBoxOib = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelDateOfJoining = new System.Windows.Forms.Label();
            this.labelFitnessLvl = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.dtpDateOfJoining = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxFitnessLvl
            // 
            this.comboBoxFitnessLvl.FormattingEnabled = true;
            this.comboBoxFitnessLvl.Location = new System.Drawing.Point(222, 380);
            this.comboBoxFitnessLvl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFitnessLvl.Name = "comboBoxFitnessLvl";
            this.comboBoxFitnessLvl.Size = new System.Drawing.Size(298, 24);
            this.comboBoxFitnessLvl.TabIndex = 0;
            this.comboBoxFitnessLvl.SelectedIndexChanged += new System.EventHandler(this.comboBoxFitnessLvl_SelectedIndexChanged);
            // 
            // labelOib
            // 
            this.labelOib.AutoSize = true;
            this.labelOib.Location = new System.Drawing.Point(157, 65);
            this.labelOib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOib.Name = "labelOib";
            this.labelOib.Size = new System.Drawing.Size(35, 17);
            this.labelOib.TabIndex = 1;
            this.labelOib.Text = "OIB:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(157, 437);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(60, 17);
            this.labelNotes.TabIndex = 3;
            this.labelNotes.Text = "Bilješke:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(222, 434);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(298, 22);
            this.textBoxNotes.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(222, 688);
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
            this.btnDecline.Location = new System.Drawing.Point(368, 688);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(100, 33);
            this.btnDecline.TabIndex = 7;
            this.btnDecline.Text = "Odustani";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // textBoxOib
            // 
            this.textBoxOib.Location = new System.Drawing.Point(223, 62);
            this.textBoxOib.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOib.Name = "textBoxOib";
            this.textBoxOib.Size = new System.Drawing.Size(297, 22);
            this.textBoxOib.TabIndex = 9;
            this.textBoxOib.TextChanged += new System.EventHandler(this.textBoxOib_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(158, 118);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(34, 17);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "Ime:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(157, 171);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(63, 17);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Prezime:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(223, 115);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(297, 22);
            this.textBoxFirstName.TabIndex = 12;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(223, 168);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(297, 22);
            this.textBoxLastName.TabIndex = 13;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(157, 225);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(105, 17);
            this.labelDateOfBirth.TabIndex = 14;
            this.labelDateOfBirth.Text = "Datum rođenja:";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Location = new System.Drawing.Point(157, 278);
            this.labelPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(92, 17);
            this.labelPhoneNum.TabIndex = 15;
            this.labelPhoneNum.Text = "Broj telefona:";
            // 
            // labelDateOfJoining
            // 
            this.labelDateOfJoining.AutoSize = true;
            this.labelDateOfJoining.Location = new System.Drawing.Point(157, 332);
            this.labelDateOfJoining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfJoining.Name = "labelDateOfJoining";
            this.labelDateOfJoining.Size = new System.Drawing.Size(121, 17);
            this.labelDateOfJoining.TabIndex = 16;
            this.labelDateOfJoining.Text = "Datum učlanjenja:";
            // 
            // labelFitnessLvl
            // 
            this.labelFitnessLvl.AutoSize = true;
            this.labelFitnessLvl.Location = new System.Drawing.Point(157, 383);
            this.labelFitnessLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFitnessLvl.Name = "labelFitnessLvl";
            this.labelFitnessLvl.Size = new System.Drawing.Size(56, 17);
            this.labelFitnessLvl.TabIndex = 17;
            this.labelFitnessLvl.Text = "Razina:";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(157, 490);
            this.labelGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(52, 17);
            this.labelGroups.TabIndex = 18;
            this.labelGroups.Text = "Grupe:";
            // 
            // dtpDateOfJoining
            // 
            this.dtpDateOfJoining.Location = new System.Drawing.Point(285, 332);
            this.dtpDateOfJoining.Name = "dtpDateOfJoining";
            this.dtpDateOfJoining.Size = new System.Drawing.Size(235, 22);
            this.dtpDateOfJoining.TabIndex = 19;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(269, 225);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(251, 22);
            this.dtpDateOfBirth.TabIndex = 20;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(257, 275);
            this.textBoxPhoneNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(263, 22);
            this.textBoxPhoneNum.TabIndex = 21;
            this.textBoxPhoneNum.TextChanged += new System.EventHandler(this.textBoxPhoneNum_TextChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(223, 490);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGroups.Size = new System.Drawing.Size(297, 116);
            this.listBoxGroups.TabIndex = 22;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 775);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.dtpDateOfJoining);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelFitnessLvl);
            this.Controls.Add(this.labelDateOfJoining);
            this.Controls.Add(this.labelPhoneNum);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxOib);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelOib);
            this.Controls.Add(this.comboBoxFitnessLvl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj klijenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFitnessLvl;
        private System.Windows.Forms.Label labelOib;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.TextBox textBoxOib;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.Label labelDateOfJoining;
        private System.Windows.Forms.Label labelFitnessLvl;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.DateTimePicker dtpDateOfJoining;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.ListBox listBoxGroups;
    }
}