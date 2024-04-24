namespace Tickets.Interfaces
{
    partial class RegisterEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterEmployee));
            this.idEmployeeTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.idEmployeeLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.saveEmployeeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idEmployeeTxtBox
            // 
            this.idEmployeeTxtBox.Location = new System.Drawing.Point(83, 80);
            this.idEmployeeTxtBox.Name = "idEmployeeTxtBox";
            this.idEmployeeTxtBox.Size = new System.Drawing.Size(110, 20);
            this.idEmployeeTxtBox.TabIndex = 0;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(83, 132);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(182, 20);
            this.firstNameTxtBox.TabIndex = 1;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(83, 187);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(182, 20);
            this.lastNameTxtBox.TabIndex = 2;
            // 
            // idEmployeeLbl
            // 
            this.idEmployeeLbl.AutoSize = true;
            this.idEmployeeLbl.Location = new System.Drawing.Point(82, 61);
            this.idEmployeeLbl.Name = "idEmployeeLbl";
            this.idEmployeeLbl.Size = new System.Drawing.Size(111, 13);
            this.idEmployeeLbl.TabIndex = 3;
            this.idEmployeeLbl.Text = "Numero de empleado:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(82, 113);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(52, 13);
            this.firstNameLbl.TabIndex = 4;
            this.firstNameLbl.Text = "Nombres:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(82, 168);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(52, 13);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Apellidos:";
            // 
            // saveEmployeeBtn
            // 
            this.saveEmployeeBtn.Location = new System.Drawing.Point(125, 249);
            this.saveEmployeeBtn.Name = "saveEmployeeBtn";
            this.saveEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.saveEmployeeBtn.TabIndex = 6;
            this.saveEmployeeBtn.Text = "Guardar";
            this.saveEmployeeBtn.UseVisualStyleBackColor = true;
            this.saveEmployeeBtn.Click += new System.EventHandler(this.saveEmployeeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(206, 249);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Atras";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // RegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveEmployeeBtn);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.idEmployeeLbl);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.idEmployeeTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idEmployeeTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label idEmployeeLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Button saveEmployeeBtn;
        private System.Windows.Forms.Button backBtn;
    }
}