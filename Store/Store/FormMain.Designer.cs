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
            this.lstSpecific_Order = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSpecific_Order
            // 
            this.lblSpecific_Order.AutoSize = true;
            this.lblSpecific_Order.Location = new System.Drawing.Point(117, 119);
            this.lblSpecific_Order.Name = "lblSpecific_Order";
            this.lblSpecific_Order.Size = new System.Drawing.Size(154, 25);
            this.lblSpecific_Order.TabIndex = 0;
            this.lblSpecific_Order.Text = "Specific_Order";
            // 
            // lstSpecific_Order
            // 
            this.lstSpecific_Order.FormattingEnabled = true;
            this.lstSpecific_Order.ItemHeight = 25;
            this.lstSpecific_Order.Location = new System.Drawing.Point(113, 221);
            this.lstSpecific_Order.Name = "lstSpecific_Order";
            this.lstSpecific_Order.Size = new System.Drawing.Size(248, 454);
            this.lstSpecific_Order.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 931);
            this.Controls.Add(this.lstSpecific_Order);
            this.Controls.Add(this.lblSpecific_Order);
            this.Name = "FormMain";
            this.Text = "Specific_Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpecific_Order;
        private System.Windows.Forms.ListBox lstSpecific_Order;
    }
}

