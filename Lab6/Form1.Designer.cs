namespace Lab6
{
    partial class Form1
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
            txtX1 = new System.Windows.Forms.TextBox();
            txtX2 = new System.Windows.Forms.TextBox();
            txtVariant = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblResult = new System.Windows.Forms.Label();
            lblExtra = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtX1
            // 
            txtX1.Location = new System.Drawing.Point(228, 36);
            txtX1.Name = "txtX1";
            txtX1.Size = new System.Drawing.Size(153, 23);
            txtX1.TabIndex = 0;
            // 
            // txtX2
            // 
            txtX2.Location = new System.Drawing.Point(228, 94);
            txtX2.Name = "txtX2";
            txtX2.Size = new System.Drawing.Size(153, 23);
            txtX2.TabIndex = 1;
            // 
            // txtVariant
            // 
            txtVariant.Location = new System.Drawing.Point(228, 151);
            txtVariant.Name = "txtVariant";
            txtVariant.Size = new System.Drawing.Size(153, 23);
            txtVariant.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(29, 301);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(91, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Обчислити";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(147, 301);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(91, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(280, 301);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(91, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Вийти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Змінна X1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "Змінна X2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "Варіант";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(40, 245);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(0, 15);
            lblResult.TabIndex = 9;
            lblResult.Click += label4_Click;
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Location = new System.Drawing.Point(147, 245);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new System.Drawing.Size(0, 15);
            lblExtra.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(393, 354);
            Controls.Add(lblExtra);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtVariant);
            Controls.Add(txtX2);
            Controls.Add(txtX1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Лабораторна работа №6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtVariant;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblExtra;
    }
}
