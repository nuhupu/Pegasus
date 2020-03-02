namespace PEGASUS.Test
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
            this.btnTestCom = new System.Windows.Forms.Button();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.btnTextSend = new System.Windows.Forms.Button();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTestCom
            // 
            this.btnTestCom.Location = new System.Drawing.Point(12, 12);
            this.btnTestCom.Name = "btnTestCom";
            this.btnTestCom.Size = new System.Drawing.Size(82, 23);
            this.btnTestCom.TabIndex = 0;
            this.btnTestCom.Text = "Test COM";
            this.btnTestCom.UseVisualStyleBackColor = true;
            this.btnTestCom.Click += new System.EventHandler(this.btnTestCom_Click);
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(12, 52);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(295, 20);
            this.txt01.TabIndex = 1;
            // 
            // btnTextSend
            // 
            this.btnTextSend.Location = new System.Drawing.Point(12, 98);
            this.btnTextSend.Name = "btnTextSend";
            this.btnTextSend.Size = new System.Drawing.Size(82, 23);
            this.btnTextSend.TabIndex = 0;
            this.btnTextSend.Text = "Test Send";
            this.btnTextSend.UseVisualStyleBackColor = true;
            this.btnTextSend.Click += new System.EventHandler(this.btnTestSend_Click);
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(142, 13);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.btnTextSend);
            this.Controls.Add(this.btnTestCom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestCom;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.Button btnTextSend;
        private System.Windows.Forms.ComboBox cbCom;
    }
}

