namespace project01
{
    partial class OrderForm
    {
        
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
            btnCreateOrder = new Button();
            lblTotal = new Label();
            cmbPayment = new ComboBox();
            btnPay = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            btnUpdateStatus = new Button();
            SuspendLayout();
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(12, 66);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(135, 36);
            btnCreateOrder.TabIndex = 15;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(190, 77);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total: 0";
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Items.AddRange(new object[] { "Cash", "Credit Card", "PayPal" });
            cmbPayment.Location = new Point(12, 155);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(222, 23);
            cmbPayment.TabIndex = 17;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(12, 209);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(135, 39);
            btnPay.TabIndex = 18;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPayNow_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Processing", "Shipped", "Delivered" });
            cmbStatus.Location = new Point(368, 155);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(222, 23);
            cmbStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(439, 195);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 15);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status: Pending";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(420, 214);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(135, 34);
            btnUpdateStatus.TabIndex = 21;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnPay);
            Controls.Add(cmbPayment);
            Controls.Add(lblTotal);
            Controls.Add(btnCreateOrder);
            Name = "OrderForm";
            Text = "OrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateOrder;
        private Label lblTotal;
        private ComboBox cmbPayment;
        private Button btnPay;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Button btnUpdateStatus;
    }
}