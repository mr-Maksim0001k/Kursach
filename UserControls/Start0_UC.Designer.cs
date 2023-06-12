namespace OP1___CSharp_WinForm___Labs.UserControls
{
    partial class Start0_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Welcome.Location = new System.Drawing.Point(407, 235);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(392, 55);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Адаменко Максим";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "група ПД-24";
            // 
            // Start0_UC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Welcome);
            this.Name = "Start0_UC";
            this.Size = new System.Drawing.Size(1061, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label1;
    }
}
