namespace Private_Assemblies_Task_Performance_1_Reyes
{
    partial class frmBasicCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasicCalculator));
            this.lblBasicCalculator = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBasicCalculator
            // 
            this.lblBasicCalculator.AutoSize = true;
            this.lblBasicCalculator.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicCalculator.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicCalculator.ForeColor = System.Drawing.Color.Sienna;
            this.lblBasicCalculator.Location = new System.Drawing.Point(12, 9);
            this.lblBasicCalculator.Name = "lblBasicCalculator";
            this.lblBasicCalculator.Size = new System.Drawing.Size(260, 25);
            this.lblBasicCalculator.TabIndex = 0;
            this.lblBasicCalculator.Text = "Basic Calculator";
            // 
            // tbNum1
            // 
            this.tbNum1.BackColor = System.Drawing.Color.BurlyWood;
            this.tbNum1.Location = new System.Drawing.Point(17, 79);
            this.tbNum1.Multiline = true;
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(311, 50);
            this.tbNum1.TabIndex = 1;
            // 
            // tbNum2
            // 
            this.tbNum2.BackColor = System.Drawing.Color.BurlyWood;
            this.tbNum2.Location = new System.Drawing.Point(17, 191);
            this.tbNum2.Multiline = true;
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(311, 50);
            this.tbNum2.TabIndex = 2;
            // 
            // cbOperations
            // 
            this.cbOperations.BackColor = System.Drawing.Color.BurlyWood;
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperations.Location = new System.Drawing.Point(128, 150);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(85, 21);
            this.cbOperations.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTotal.Font = new System.Drawing.Font("Solid Edge Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Sienna;
            this.lblTotal.Location = new System.Drawing.Point(38, 261);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(273, 91);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: ";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCompute.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.Sienna;
            this.btnCompute.Location = new System.Drawing.Point(128, 382);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(94, 23);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            // 
            // frmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbOperations);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.lblBasicCalculator);
            this.Name = "frmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasicCalculator;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.ComboBox cbOperations;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompute;
    }
}

