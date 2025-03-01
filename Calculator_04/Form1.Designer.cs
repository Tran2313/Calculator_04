
namespace Calculator_04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCong = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(213, 214);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 13;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(121, 152);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(168, 23);
            this.txtResult.TabIndex = 12;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(121, 105);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(168, 23);
            this.txt2.TabIndex = 11;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(121, 59);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(168, 23);
            this.txt1.TabIndex = 10;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(51, 160);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(47, 15);
            this.lbResult.TabIndex = 9;
            this.lbResult.Text = "Kết quả";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(51, 113);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(30, 15);
            this.lbNum2.TabIndex = 8;
            this.lbNum2.Text = "Số b";
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(51, 67);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(29, 15);
            this.lbNum1.TabIndex = 7;
            this.lbNum1.Text = "Số a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 286);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbNum1;
    }
}

