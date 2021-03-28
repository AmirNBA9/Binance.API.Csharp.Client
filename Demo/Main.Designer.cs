namespace Demo
{
    partial class Demo
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
            this.ApiKeyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApiKey = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ApiKeyLabel
            // 
            this.ApiKeyLabel.AutoSize = true;
            this.ApiKeyLabel.Location = new System.Drawing.Point(29, 16);
            this.ApiKeyLabel.Name = "ApiKeyLabel";
            this.ApiKeyLabel.Size = new System.Drawing.Size(51, 14);
            this.ApiKeyLabel.TabIndex = 0;
            this.ApiKeyLabel.Text = "Api key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secret key:";
            // 
            // ApiKey
            // 
            this.ApiKey.Location = new System.Drawing.Point(113, 13);
            this.ApiKey.Name = "ApiKey";
            this.ApiKey.Size = new System.Drawing.Size(406, 22);
            this.ApiKey.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 367);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ApiKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApiKeyLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(721, 406);
            this.Name = "Demo";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApiKeyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApiKey;
        private System.Windows.Forms.TextBox textBox2;
    }
}