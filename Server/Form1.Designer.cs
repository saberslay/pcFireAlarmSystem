namespace Server
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
            this.CMD_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMD_BTN
            // 
            this.CMD_BTN.Location = new System.Drawing.Point(659, 366);
            this.CMD_BTN.Name = "CMD_BTN";
            this.CMD_BTN.Size = new System.Drawing.Size(105, 49);
            this.CMD_BTN.TabIndex = 0;
            this.CMD_BTN.Text = "Send test Command";
            this.CMD_BTN.UseVisualStyleBackColor = true;
            this.CMD_BTN.Click += new System.EventHandler(this.CMD_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 427);
            this.Controls.Add(this.CMD_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CMD_BTN;
    }
}

