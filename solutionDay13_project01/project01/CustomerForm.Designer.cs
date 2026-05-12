namespace project01
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerEmail = new TextBox();
            btnCreateCustomer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 65);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(112, 33);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(314, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(112, 62);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(314, 23);
            txtCustomerEmail.TabIndex = 3;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.Location = new Point(182, 108);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(127, 34);
            btnCreateCustomer.TabIndex = 4;
            btnCreateCustomer.Text = "Create Customer";
            btnCreateCustomer.UseVisualStyleBackColor = true;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateCustomer);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm"; // تم التعديل هنا ✅
            Text = "Customer Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private TextBox txtCustomerEmail;
        private Button btnCreateCustomer;
    }
}