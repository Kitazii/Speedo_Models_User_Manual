namespace Employee_User_Manual
{
    partial class SelectRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectRoleForm));
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStockControlManager = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSalesManager = new System.Windows.Forms.Button();
            this.btnAssistantManager = new System.Windows.Forms.Button();
            this.btnSalesAssistant = new System.Windows.Forms.Button();
            this.btnWarehouseAssistant = new System.Windows.Forms.Button();
            this.btnInvoiceClerk = new System.Windows.Forms.Button();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectRole.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectRole.Location = new System.Drawing.Point(171, 38);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(225, 33);
            this.lblSelectRole.TabIndex = 19;
            this.lblSelectRole.Text = "SELECT ROLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 10);
            this.panel1.TabIndex = 20;
            // 
            // btnStockControlManager
            // 
            this.btnStockControlManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockControlManager.Location = new System.Drawing.Point(198, 334);
            this.btnStockControlManager.Name = "btnStockControlManager";
            this.btnStockControlManager.Size = new System.Drawing.Size(188, 60);
            this.btnStockControlManager.TabIndex = 22;
            this.btnStockControlManager.Text = "Stock Control Manager";
            this.btnStockControlManager.UseVisualStyleBackColor = true;
            this.btnStockControlManager.Click += new System.EventHandler(this.btnStockControlManager_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(54, 119);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(188, 60);
            this.btnAdmin.TabIndex = 23;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSalesManager
            // 
            this.btnSalesManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesManager.Location = new System.Drawing.Point(54, 185);
            this.btnSalesManager.Name = "btnSalesManager";
            this.btnSalesManager.Size = new System.Drawing.Size(188, 60);
            this.btnSalesManager.TabIndex = 24;
            this.btnSalesManager.Text = "Sales Manager";
            this.btnSalesManager.UseVisualStyleBackColor = true;
            this.btnSalesManager.Click += new System.EventHandler(this.btnSalesManager_Click);
            // 
            // btnAssistantManager
            // 
            this.btnAssistantManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistantManager.Location = new System.Drawing.Point(54, 251);
            this.btnAssistantManager.Name = "btnAssistantManager";
            this.btnAssistantManager.Size = new System.Drawing.Size(188, 60);
            this.btnAssistantManager.TabIndex = 25;
            this.btnAssistantManager.Text = "Assistant Manager";
            this.btnAssistantManager.UseVisualStyleBackColor = true;
            this.btnAssistantManager.Click += new System.EventHandler(this.btnAssistantManager_Click);
            // 
            // btnSalesAssistant
            // 
            this.btnSalesAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesAssistant.Location = new System.Drawing.Point(347, 119);
            this.btnSalesAssistant.Name = "btnSalesAssistant";
            this.btnSalesAssistant.Size = new System.Drawing.Size(188, 60);
            this.btnSalesAssistant.TabIndex = 26;
            this.btnSalesAssistant.Text = "Sales Assistant";
            this.btnSalesAssistant.UseVisualStyleBackColor = true;
            this.btnSalesAssistant.Click += new System.EventHandler(this.btnSalesAssistant_Click);
            // 
            // btnWarehouseAssistant
            // 
            this.btnWarehouseAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouseAssistant.Location = new System.Drawing.Point(347, 185);
            this.btnWarehouseAssistant.Name = "btnWarehouseAssistant";
            this.btnWarehouseAssistant.Size = new System.Drawing.Size(188, 60);
            this.btnWarehouseAssistant.TabIndex = 27;
            this.btnWarehouseAssistant.Text = "Warehouse Assistant";
            this.btnWarehouseAssistant.UseVisualStyleBackColor = true;
            this.btnWarehouseAssistant.Click += new System.EventHandler(this.btnWarehouseAssistant_Click);
            // 
            // btnInvoiceClerk
            // 
            this.btnInvoiceClerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceClerk.Location = new System.Drawing.Point(347, 251);
            this.btnInvoiceClerk.Name = "btnInvoiceClerk";
            this.btnInvoiceClerk.Size = new System.Drawing.Size(188, 60);
            this.btnInvoiceClerk.TabIndex = 28;
            this.btnInvoiceClerk.Text = "Invoice Clerk";
            this.btnInvoiceClerk.UseVisualStyleBackColor = true;
            this.btnInvoiceClerk.Click += new System.EventHandler(this.btnInvoiceClerk_Click);
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Location = new System.Drawing.Point(278, 471);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(32, 13);
            this.linkBack.TabIndex = 29;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // SelectRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 552);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.btnInvoiceClerk);
            this.Controls.Add(this.btnWarehouseAssistant);
            this.Controls.Add(this.btnSalesAssistant);
            this.Controls.Add(this.btnAssistantManager);
            this.Controls.Add(this.btnSalesManager);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStockControlManager);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSelectRole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speedo Models - Employee User Manual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockControlManager;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSalesManager;
        private System.Windows.Forms.Button btnAssistantManager;
        private System.Windows.Forms.Button btnSalesAssistant;
        private System.Windows.Forms.Button btnWarehouseAssistant;
        private System.Windows.Forms.Button btnInvoiceClerk;
        private System.Windows.Forms.LinkLabel linkBack;
    }
}