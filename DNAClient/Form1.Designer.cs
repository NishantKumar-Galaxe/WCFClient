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
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btn_V1NonRest = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_V1RestDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "InvokeService";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(93, 23);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(339, 20);
            this.txtResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name::";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(12, 68);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(710, 394);
            this.lstResult.TabIndex = 4;
            // 
            // btn_V1NonRest
            // 
            this.btn_V1NonRest.Location = new System.Drawing.Point(11, 498);
            this.btn_V1NonRest.Name = "btn_V1NonRest";
            this.btn_V1NonRest.Size = new System.Drawing.Size(173, 23);
            this.btn_V1NonRest.TabIndex = 5;
            this.btn_V1NonRest.Text = "V1 Non Restful Service Demo";
            this.btn_V1NonRest.UseVisualStyleBackColor = true;
            this.btn_V1NonRest.Click += new System.EventHandler(this.Btn_V1NonRest_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "OneWayServiceDemo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(548, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "TwoWayBindingDemo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(190, 469);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Restful Service Demo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Non Restful Service Demo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_V1RestDemo
            // 
            this.btn_V1RestDemo.Location = new System.Drawing.Point(190, 498);
            this.btn_V1RestDemo.Name = "btn_V1RestDemo";
            this.btn_V1RestDemo.Size = new System.Drawing.Size(173, 23);
            this.btn_V1RestDemo.TabIndex = 11;
            this.btn_V1RestDemo.Text = "V1 Restful Service Demo";
            this.btn_V1RestDemo.UseVisualStyleBackColor = true;
            this.btn_V1RestDemo.Click += new System.EventHandler(this.Btn_V1RestDemo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 540);
            this.Controls.Add(this.btn_V1RestDemo);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_V1NonRest);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btn_V1NonRest;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_V1RestDemo;
    }
}

