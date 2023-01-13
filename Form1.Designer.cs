namespace BuildQtyTracker
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
            this.orderId_box = new System.Windows.Forms.TextBox();
            this.OrderId_Label = new System.Windows.Forms.Label();
            this.qty_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // orderId_box
            // 
            this.orderId_box.Location = new System.Drawing.Point(12, 25);
            this.orderId_box.Name = "orderId_box";
            this.orderId_box.Size = new System.Drawing.Size(153, 20);
            this.orderId_box.TabIndex = 0;
            this.orderId_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            // 
            // OrderId_Label
            // 
            this.OrderId_Label.AutoSize = true;
            this.OrderId_Label.Location = new System.Drawing.Point(12, 9);
            this.OrderId_Label.Name = "OrderId_Label";
            this.OrderId_Label.Size = new System.Drawing.Size(45, 13);
            this.OrderId_Label.TabIndex = 1;
            this.OrderId_Label.Text = "Order Id";
            // 
            // qty_Label
            // 
            this.qty_Label.AutoSize = true;
            this.qty_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_Label.Location = new System.Drawing.Point(580, 25);
            this.qty_Label.Name = "qty_Label";
            this.qty_Label.Size = new System.Drawing.Size(95, 104);
            this.qty_Label.TabIndex = 2;
            this.qty_Label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 104);
            this.label1.TabIndex = 3;
            this.label1.Text = "Built:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset QTY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(114, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Ready to Reset?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 176);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qty_Label);
            this.Controls.Add(this.OrderId_Label);
            this.Controls.Add(this.orderId_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Building Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderId_box;
        private System.Windows.Forms.Label OrderId_Label;
        private System.Windows.Forms.Label qty_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

