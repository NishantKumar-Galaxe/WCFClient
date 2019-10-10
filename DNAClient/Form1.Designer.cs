namespace DNAClient
{
    partial class Form1
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btn_GetCustomer_Rest = new System.Windows.Forms.Button();
            this.btn_GetCustomer = new System.Windows.Forms.Button();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.btn_AddNewCustRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtMessage.Location = new System.Drawing.Point(12, 448);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(589, 80);
            this.txtMessage.TabIndex = 2;
            // 
            // btn_GetCustomer_Rest
            // 
            this.btn_GetCustomer_Rest.Location = new System.Drawing.Point(610, 506);
            this.btn_GetCustomer_Rest.Name = "btn_GetCustomer_Rest";
            this.btn_GetCustomer_Rest.Size = new System.Drawing.Size(111, 23);
            this.btn_GetCustomer_Rest.TabIndex = 12;
            this.btn_GetCustomer_Rest.Text = "Get Customer Rest";
            this.btn_GetCustomer_Rest.UseVisualStyleBackColor = true;
            this.btn_GetCustomer_Rest.Click += new System.EventHandler(this.Btn_GetCustomer_Rest_Click);
            // 
            // btn_GetCustomer
            // 
            this.btn_GetCustomer.Location = new System.Drawing.Point(610, 477);
            this.btn_GetCustomer.Name = "btn_GetCustomer";
            this.btn_GetCustomer.Size = new System.Drawing.Size(111, 23);
            this.btn_GetCustomer.TabIndex = 13;
            this.btn_GetCustomer.Text = "Get Customer";
            this.btn_GetCustomer.UseVisualStyleBackColor = true;
            this.btn_GetCustomer.Click += new System.EventHandler(this.Btn_GetCustomer_Click);
            // 
            // gvData
            // 
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Location = new System.Drawing.Point(9, 12);
            this.gvData.Name = "gvData";
            this.gvData.Size = new System.Drawing.Size(709, 430);
            this.gvData.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(610, 448);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(12, 534);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(111, 23);
            this.btn_AddNew.TabIndex = 17;
            this.btn_AddNew.Text = "Add New Customer";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.Btn_AddNew_Click);
            // 
            // btn_AddNewCustRest
            // 
            this.btn_AddNewCustRest.Location = new System.Drawing.Point(129, 534);
            this.btn_AddNewCustRest.Name = "btn_AddNewCustRest";
            this.btn_AddNewCustRest.Size = new System.Drawing.Size(160, 23);
            this.btn_AddNewCustRest.TabIndex = 18;
            this.btn_AddNewCustRest.Text = "Add New Customer Rest";
            this.btn_AddNewCustRest.UseVisualStyleBackColor = true;
            this.btn_AddNewCustRest.Click += new System.EventHandler(this.Btn_AddNewCustRest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 562);
            this.Controls.Add(this.btn_AddNewCustRest);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.btn_GetCustomer);
            this.Controls.Add(this.btn_GetCustomer_Rest);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btn_GetCustomer_Rest;
        private System.Windows.Forms.Button btn_GetCustomer;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_AddNewCustRest;
    }
}

