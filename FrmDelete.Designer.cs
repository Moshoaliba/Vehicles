namespace _34316345_SU2_ACT5
{
    partial class FrmDelete
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
            this.buttonD = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(315, 37);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(103, 23);
            this.buttonD.TabIndex = 0;
            this.buttonD.Text = "Delete";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(22, 47);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(76, 13);
            this.lblDelete.TabIndex = 1;
            this.lblDelete.Text = "Vehicle model:";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(104, 40);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(136, 20);
            this.txtDelete.TabIndex = 2;
            // 
            // FrmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 118);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.buttonD);
            this.Name = "FrmDelete";
            this.Text = "FrmDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtDelete;
    }
}