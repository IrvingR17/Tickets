namespace Tickets.Interfaces
{
    partial class CreateTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTicket));
            this.idTicketLbl = new System.Windows.Forms.Label();
            this.idTicketTxtBox = new System.Windows.Forms.TextBox();
            this.employeeListDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeListLbl = new System.Windows.Forms.Label();
            this.registerEmployeeBtn = new System.Windows.Forms.Button();
            this.searchEmployeeTxtBox = new System.Windows.Forms.TextBox();
            this.ticketDatePicker = new System.Windows.Forms.DateTimePicker();
            this.saveTicketBtn = new System.Windows.Forms.Button();
            this.searchEmployeeLbl = new System.Windows.Forms.Label();
            this.dateTicketLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idTicketLbl
            // 
            this.idTicketLbl.AutoSize = true;
            this.idTicketLbl.Location = new System.Drawing.Point(55, 41);
            this.idTicketLbl.Name = "idTicketLbl";
            this.idTicketLbl.Size = new System.Drawing.Size(88, 13);
            this.idTicketLbl.TabIndex = 0;
            this.idTicketLbl.Text = "Numero de vale: ";
            // 
            // idTicketTxtBox
            // 
            this.idTicketTxtBox.Location = new System.Drawing.Point(58, 58);
            this.idTicketTxtBox.Name = "idTicketTxtBox";
            this.idTicketTxtBox.Size = new System.Drawing.Size(100, 20);
            this.idTicketTxtBox.TabIndex = 1;
            // 
            // employeeListDataGridView
            // 
            this.employeeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FistName,
            this.LastName});
            this.employeeListDataGridView.Location = new System.Drawing.Point(58, 122);
            this.employeeListDataGridView.Name = "employeeListDataGridView";
            this.employeeListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeeListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeListDataGridView.Size = new System.Drawing.Size(683, 150);
            this.employeeListDataGridView.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.FillWeight = 35F;
            this.Id.HeaderText = "No. Empleado";
            this.Id.Name = "Id";
            // 
            // FistName
            // 
            this.FistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FistName.HeaderText = "Nombre";
            this.FistName.Name = "FistName";
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "Apellidos";
            this.LastName.Name = "LastName";
            // 
            // employeeListLbl
            // 
            this.employeeListLbl.AutoSize = true;
            this.employeeListLbl.Location = new System.Drawing.Point(58, 103);
            this.employeeListLbl.Name = "employeeListLbl";
            this.employeeListLbl.Size = new System.Drawing.Size(101, 13);
            this.employeeListLbl.TabIndex = 3;
            this.employeeListLbl.Text = "Lista de empleados:";
            // 
            // registerEmployeeBtn
            // 
            this.registerEmployeeBtn.Location = new System.Drawing.Point(591, 278);
            this.registerEmployeeBtn.Name = "registerEmployeeBtn";
            this.registerEmployeeBtn.Size = new System.Drawing.Size(150, 23);
            this.registerEmployeeBtn.TabIndex = 4;
            this.registerEmployeeBtn.Text = "Registrar nuevo empleado";
            this.registerEmployeeBtn.UseVisualStyleBackColor = true;
            this.registerEmployeeBtn.Click += new System.EventHandler(this.registerEmployeeBtn_Click);
            // 
            // searchEmployeeTxtBox
            // 
            this.searchEmployeeTxtBox.Location = new System.Drawing.Point(410, 100);
            this.searchEmployeeTxtBox.Name = "searchEmployeeTxtBox";
            this.searchEmployeeTxtBox.Size = new System.Drawing.Size(331, 20);
            this.searchEmployeeTxtBox.TabIndex = 5;
            this.searchEmployeeTxtBox.TextChanged += new System.EventHandler(this.searchEmployeeTxtBox_TextChanged);
            // 
            // ticketDatePicker
            // 
            this.ticketDatePicker.CustomFormat = "";
            this.ticketDatePicker.Enabled = false;
            this.ticketDatePicker.Location = new System.Drawing.Point(58, 326);
            this.ticketDatePicker.Name = "ticketDatePicker";
            this.ticketDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ticketDatePicker.TabIndex = 6;
            this.ticketDatePicker.Value = new System.DateTime(2024, 4, 17, 0, 0, 0, 0);
            // 
            // saveTicketBtn
            // 
            this.saveTicketBtn.Location = new System.Drawing.Point(658, 386);
            this.saveTicketBtn.Name = "saveTicketBtn";
            this.saveTicketBtn.Size = new System.Drawing.Size(82, 23);
            this.saveTicketBtn.TabIndex = 7;
            this.saveTicketBtn.Text = "Crear ticket";
            this.saveTicketBtn.UseVisualStyleBackColor = true;
            this.saveTicketBtn.Click += new System.EventHandler(this.saveTicketBtn_Click);
            // 
            // searchEmployeeLbl
            // 
            this.searchEmployeeLbl.AutoSize = true;
            this.searchEmployeeLbl.Location = new System.Drawing.Point(410, 81);
            this.searchEmployeeLbl.Name = "searchEmployeeLbl";
            this.searchEmployeeLbl.Size = new System.Drawing.Size(92, 13);
            this.searchEmployeeLbl.TabIndex = 8;
            this.searchEmployeeLbl.Text = "Buscar empleado:";
            // 
            // dateTicketLbl
            // 
            this.dateTicketLbl.AutoSize = true;
            this.dateTicketLbl.Location = new System.Drawing.Point(58, 307);
            this.dateTicketLbl.Name = "dateTicketLbl";
            this.dateTicketLbl.Size = new System.Drawing.Size(80, 13);
            this.dateTicketLbl.TabIndex = 9;
            this.dateTicketLbl.Text = "Fecha del vale:";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(564, 386);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Atras";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dateTicketLbl);
            this.Controls.Add(this.searchEmployeeLbl);
            this.Controls.Add(this.saveTicketBtn);
            this.Controls.Add(this.ticketDatePicker);
            this.Controls.Add(this.searchEmployeeTxtBox);
            this.Controls.Add(this.registerEmployeeBtn);
            this.Controls.Add(this.employeeListLbl);
            this.Controls.Add(this.employeeListDataGridView);
            this.Controls.Add(this.idTicketTxtBox);
            this.Controls.Add(this.idTicketLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear vale";
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idTicketLbl;
        private System.Windows.Forms.TextBox idTicketTxtBox;
        private System.Windows.Forms.DataGridView employeeListDataGridView;
        private System.Windows.Forms.Label employeeListLbl;
        private System.Windows.Forms.Button registerEmployeeBtn;
        private System.Windows.Forms.TextBox searchEmployeeTxtBox;
        private System.Windows.Forms.DateTimePicker ticketDatePicker;
        private System.Windows.Forms.Button saveTicketBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Label searchEmployeeLbl;
        private System.Windows.Forms.Label dateTicketLbl;
        private System.Windows.Forms.Button backBtn;
    }
}