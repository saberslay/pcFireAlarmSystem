namespace Client
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
            this.TOP_Text_LB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TOP_Text_LB
            // 
            this.TOP_Text_LB.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP_Text_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOP_Text_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.TOP_Text_LB.Location = new System.Drawing.Point(0, 0);
            this.TOP_Text_LB.Name = "TOP_Text_LB";
            this.TOP_Text_LB.Size = new System.Drawing.Size(800, 121);
            this.TOP_Text_LB.TabIndex = 0;
            this.TOP_Text_LB.Text = "Please Evacuate";
            this.TOP_Text_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 121);
            this.label2.TabIndex = 1;
            this.label2.Text = "This Building";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TOP_Text_LB);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TOP_Text_LB;
        private System.Windows.Forms.Label label2;
    }
}

