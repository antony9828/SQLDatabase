

namespace Store
{
    partial class FormMain
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
            this.lblSpecific_Order = new System.Windows.Forms.Label();
            this.nameList = new System.Windows.Forms.ListBox();
            this.itemsListSpecificOrder = new System.Windows.Forms.ListBox();
            this.priceList = new System.Windows.Forms.ListBox();
            this.statusList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemListProduct = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enterField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.ChangeOrder = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpecific_Order
            // 
            this.lblSpecific_Order.AutoSize = true;
            this.lblSpecific_Order.Location = new System.Drawing.Point(108, 132);
            this.lblSpecific_Order.Name = "lblSpecific_Order";
            this.lblSpecific_Order.Size = new System.Drawing.Size(154, 25);
            this.lblSpecific_Order.TabIndex = 0;
            this.lblSpecific_Order.Text = "Specific_Order";
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.ItemHeight = 25;
            this.nameList.Location = new System.Drawing.Point(113, 221);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(197, 154);
            this.nameList.TabIndex = 1;
            this.nameList.SelectedIndexChanged += new System.EventHandler(this.listBox0_SelectedIndexChanged);
            // 
            // itemsListSpecificOrder
            // 
            this.itemsListSpecificOrder.FormattingEnabled = true;
            this.itemsListSpecificOrder.ItemHeight = 25;
            this.itemsListSpecificOrder.Location = new System.Drawing.Point(339, 221);
            this.itemsListSpecificOrder.Name = "itemsListSpecificOrder";
            this.itemsListSpecificOrder.Size = new System.Drawing.Size(197, 154);
            this.itemsListSpecificOrder.TabIndex = 2;
            // 
            // priceList
            // 
            this.priceList.FormattingEnabled = true;
            this.priceList.ItemHeight = 25;
            this.priceList.Location = new System.Drawing.Point(559, 221);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(197, 154);
            this.priceList.TabIndex = 3;
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.ItemHeight = 25;
            this.statusList.Location = new System.Drawing.Point(777, 221);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(197, 154);
            this.statusList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product";
            // 
            // itemListProduct
            // 
            this.itemListProduct.FormattingEnabled = true;
            this.itemListProduct.ItemHeight = 25;
            this.itemListProduct.Location = new System.Drawing.Point(113, 556);
            this.itemListProduct.Name = "itemListProduct";
            this.itemListProduct.Size = new System.Drawing.Size(197, 154);
            this.itemListProduct.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 13;
            // 
            // enterField
            // 
            this.enterField.Location = new System.Drawing.Point(1074, 222);
            this.enterField.Name = "enterField";
            this.enterField.Size = new System.Drawing.Size(248, 31);
            this.enterField.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1069, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter new Name to add or change";
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(1081, 556);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(241, 69);
            this.DeleteOrder.TabIndex = 19;
            this.DeleteOrder.Text = "Delete order";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // ChangeOrder
            // 
            this.ChangeOrder.Location = new System.Drawing.Point(1081, 446);
            this.ChangeOrder.Name = "ChangeOrder";
            this.ChangeOrder.Size = new System.Drawing.Size(241, 69);
            this.ChangeOrder.TabIndex = 20;
            this.ChangeOrder.Text = "Change order name";
            this.ChangeOrder.UseVisualStyleBackColor = true;
            this.ChangeOrder.Click += new System.EventHandler(this.ChangeOrder_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(1081, 334);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(241, 69);
            this.AddOrder.TabIndex = 21;
            this.AddOrder.Text = "Add new order";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 931);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.ChangeOrder);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.enterField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemListProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.priceList);
            this.Controls.Add(this.itemsListSpecificOrder);
            this.Controls.Add(this.nameList);
            this.Controls.Add(this.lblSpecific_Order);
            this.Name = "FormMain";
            this.Text = "Specific_Order";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpecific_Order;
        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.ListBox itemsListSpecificOrder;
        private System.Windows.Forms.ListBox priceList;
        private System.Windows.Forms.ListBox statusList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox itemListProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox enterField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button ChangeOrder;
        private System.Windows.Forms.Button AddOrder;
    }
}

