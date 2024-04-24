namespace Tickets.Interfaces
{
    partial class ListTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTickets));
            this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdEmployee,
            this.EmployeeName,
            this.Date});
            this.ticketsDataGridView.Location = new System.Drawing.Point(12, 63);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.Size = new System.Drawing.Size(776, 339);
            this.ticketsDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Folio";
            this.Id.Name = "Id";
            this.Id.Width = 54;
            // 
            // IdEmployee
            // 
            this.IdEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdEmployee.HeaderText = "No. Empleado";
            this.IdEmployee.Name = "IdEmployee";
            this.IdEmployee.Width = 99;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.HeaderText = "Nombre";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "Fecha";
            this.Date.Name = "Date";
            this.Date.Width = 62;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(712, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Atras";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(493, 37);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(294, 20);
            this.searchTxtBox.TabIndex = 2;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(493, 18);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(43, 13);
            this.searchLbl.TabIndex = 3;
            this.searchLbl.Text = "Buscar:";
            // 
            // ListTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ticketsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de vales";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label searchLbl;
    }
}