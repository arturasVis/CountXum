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
            this.Label_Top_Left = new System.Windows.Forms.Label();
            this.qty_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.New_Prebuild_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderId_box
            // 
            this.orderId_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderId_box.Location = new System.Drawing.Point(12, 25);
            this.orderId_box.Name = "orderId_box";
            this.orderId_box.Size = new System.Drawing.Size(153, 20);
            this.orderId_box.TabIndex = 0;
            this.orderId_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            // 
            // Label_Top_Left
            // 
            this.Label_Top_Left.AutoSize = true;
            this.Label_Top_Left.Location = new System.Drawing.Point(12, 9);
            this.Label_Top_Left.Name = "Label_Top_Left";
            this.Label_Top_Left.Size = new System.Drawing.Size(45, 13);
            this.Label_Top_Left.TabIndex = 1;
            this.Label_Top_Left.Text = "Order Id";
            // 
            // qty_Label
            // 
            this.qty_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(114, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Ready to Reset?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // New_Prebuild_Button
            // 
            this.New_Prebuild_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.New_Prebuild_Button.Location = new System.Drawing.Point(287, 139);
            this.New_Prebuild_Button.Name = "New_Prebuild_Button";
            this.New_Prebuild_Button.Size = new System.Drawing.Size(110, 23);
            this.New_Prebuild_Button.TabIndex = 6;
            this.New_Prebuild_Button.Text = "New Prebuild";
            this.New_Prebuild_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.New_Prebuild_Button.UseVisualStyleBackColor = true;
            this.New_Prebuild_Button.Visible = false;
            this.New_Prebuild_Button.Click += new System.EventHandler(this.New_Prebuild_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 176);
            this.Controls.Add(this.New_Prebuild_Button);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qty_Label);
            this.Controls.Add(this.Label_Top_Left);
            this.Controls.Add(this.orderId_box);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Building Tracker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderId_box;
        private System.Windows.Forms.Label Label_Top_Left;
        private System.Windows.Forms.Label qty_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button New_Prebuild_Button;
    }
}

