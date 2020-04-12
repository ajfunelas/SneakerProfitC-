namespace SneakerProfit
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
            this.costBox = new System.Windows.Forms.RichTextBox();
            this.sellpriceBox = new System.Windows.Forms.RichTextBox();
            this.shippingBox = new System.Windows.Forms.RichTextBox();
            this.feeBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(336, 49);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(172, 40);
            this.costBox.TabIndex = 0;
            this.costBox.Text = "";
            // 
            // sellpriceBox
            // 
            this.sellpriceBox.Location = new System.Drawing.Point(336, 104);
            this.sellpriceBox.Name = "sellpriceBox";
            this.sellpriceBox.Size = new System.Drawing.Size(172, 42);
            this.sellpriceBox.TabIndex = 1;
            this.sellpriceBox.Text = "";
            // 
            // shippingBox
            // 
            this.shippingBox.Location = new System.Drawing.Point(336, 166);
            this.shippingBox.Name = "shippingBox";
            this.shippingBox.Size = new System.Drawing.Size(172, 42);
            this.shippingBox.TabIndex = 2;
            this.shippingBox.Text = "";
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(336, 223);
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(172, 43);
            this.feeBox.TabIndex = 3;
            this.feeBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buy Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sell Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shipping Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fees";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(398, 370);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feeBox);
            this.Controls.Add(this.shippingBox);
            this.Controls.Add(this.sellpriceBox);
            this.Controls.Add(this.costBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox costBox;
        private System.Windows.Forms.RichTextBox sellpriceBox;
        private System.Windows.Forms.RichTextBox shippingBox;
        private System.Windows.Forms.RichTextBox feeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
    }
}

