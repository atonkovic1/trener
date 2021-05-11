
namespace Trener.PresentationLayer
{
    partial class ViewClientDebtsForm
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
            this.listClientDebts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddClientDebt = new System.Windows.Forms.Button();
            this.btnEditClientDebt = new System.Windows.Forms.Button();
            this.btnRemoveClientDebt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listClientDebts
            // 
            this.listClientDebts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listClientDebts.FullRowSelect = true;
            this.listClientDebts.HideSelection = false;
            this.listClientDebts.Location = new System.Drawing.Point(16, 15);
            this.listClientDebts.Margin = new System.Windows.Forms.Padding(4);
            this.listClientDebts.MultiSelect = false;
            this.listClientDebts.Name = "listClientDebts";
            this.listClientDebts.Size = new System.Drawing.Size(1033, 446);
            this.listClientDebts.TabIndex = 0;
            this.listClientDebts.UseCompatibleStateImageBehavior = false;
            this.listClientDebts.View = System.Windows.Forms.View.Details;
            this.listClientDebts.SelectedIndexChanged += new System.EventHandler(this.listClientDebts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Šifra";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime dužnika";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime dužnika";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OIB dužnika";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Iznos";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Opis";
            this.columnHeader6.Width = 402;
            // 
            // btnAddClientDebt
            // 
            this.btnAddClientDebt.Location = new System.Drawing.Point(175, 484);
            this.btnAddClientDebt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClientDebt.Name = "btnAddClientDebt";
            this.btnAddClientDebt.Size = new System.Drawing.Size(192, 41);
            this.btnAddClientDebt.TabIndex = 1;
            this.btnAddClientDebt.Text = "Dodaj dugovanje";
            this.btnAddClientDebt.UseVisualStyleBackColor = true;
            this.btnAddClientDebt.Click += new System.EventHandler(this.btnAddClientDebt_Click);
            // 
            // btnEditClientDebt
            // 
            this.btnEditClientDebt.Enabled = false;
            this.btnEditClientDebt.Location = new System.Drawing.Point(487, 484);
            this.btnEditClientDebt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClientDebt.Name = "btnEditClientDebt";
            this.btnEditClientDebt.Size = new System.Drawing.Size(192, 41);
            this.btnEditClientDebt.TabIndex = 2;
            this.btnEditClientDebt.Text = "Uredi dugovanje";
            this.btnEditClientDebt.UseVisualStyleBackColor = true;
            this.btnEditClientDebt.Click += new System.EventHandler(this.btnEditClientDebt_Click);
            // 
            // btnRemoveClientDebt
            // 
            this.btnRemoveClientDebt.Enabled = false;
            this.btnRemoveClientDebt.Location = new System.Drawing.Point(687, 484);
            this.btnRemoveClientDebt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveClientDebt.Name = "btnRemoveClientDebt";
            this.btnRemoveClientDebt.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveClientDebt.TabIndex = 3;
            this.btnRemoveClientDebt.Text = "Obriši dugovanje";
            this.btnRemoveClientDebt.UseVisualStyleBackColor = true;
            this.btnRemoveClientDebt.Click += new System.EventHandler(this.btnRemoveClientDebt_Click);
            // 
            // ViewClientDebtsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveClientDebt);
            this.Controls.Add(this.btnEditClientDebt);
            this.Controls.Add(this.btnAddClientDebt);
            this.Controls.Add(this.listClientDebts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewClientDebtsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dugovanja klijenata";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewClientDebtsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listClientDebts;
        private System.Windows.Forms.Button btnAddClientDebt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnEditClientDebt;
        private System.Windows.Forms.Button btnRemoveClientDebt;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}