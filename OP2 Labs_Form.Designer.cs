namespace OP1___CSharp_WinForm___Labs
{
    partial class OP1_Labs_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OP1_Labs_Form));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_Minimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panelActiveButton = new System.Windows.Forms.Panel();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.UC_Container = new System.Windows.Forms.Panel();
            this.lab10_UC1 = new OP1___CSharp_WinForm___Labs.UserControls.Start10_UC();
            this.lab0_UC1 = new OP1___CSharp_WinForm___Labs.UserControls.Start0_UC();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.UC_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.BTN_Close);
            this.TopPanel.Controls.Add(this.BTN_Minimize);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1261, 50);
            this.TopPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(611, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Об’єктно-орієнтовне програмування С# - Курсова робота";
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Close.FlatAppearance.BorderSize = 0;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Close.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.Location = new System.Drawing.Point(1219, 10);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(30, 30);
            this.BTN_Close.TabIndex = 2;
            this.BTN_Close.Text = "X";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Minimize
            // 
            this.BTN_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Minimize.FlatAppearance.BorderSize = 0;
            this.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Minimize.Location = new System.Drawing.Point(1183, 10);
            this.BTN_Minimize.Name = "BTN_Minimize";
            this.BTN_Minimize.Size = new System.Drawing.Size(30, 30);
            this.BTN_Minimize.TabIndex = 3;
            this.BTN_Minimize.Text = "_";
            this.BTN_Minimize.UseVisualStyleBackColor = true;
            this.BTN_Minimize.Click += new System.EventHandler(this.BTN_Minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "WinForms";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.LeftPanel.Controls.Add(this.panelActiveButton);
            this.LeftPanel.Controls.Add(this.BTN_Start);
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 50);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 581);
            this.LeftPanel.TabIndex = 1;
            // 
            // panelActiveButton
            // 
            this.panelActiveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.panelActiveButton.AllowDrop = true;
            this.panelActiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActiveButton.BackColor = System.Drawing.Color.Magenta;
            this.panelActiveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelActiveButton.Location = new System.Drawing.Point(183, 20);
            this.panelActiveButton.Name = "panelActiveButton";
            this.panelActiveButton.Size = new System.Drawing.Size(14, 110);
            this.panelActiveButton.TabIndex = 2;
            // 
            // BTN_Start
            // 
            this.BTN_Start.FlatAppearance.BorderSize = 0;
            this.BTN_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Start.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Start.ForeColor = System.Drawing.Color.White;
            this.BTN_Start.Location = new System.Drawing.Point(8, 20);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(177, 110);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // UC_Container
            // 
            this.UC_Container.AllowDrop = true;
            this.UC_Container.Controls.Add(this.lab10_UC1);
            this.UC_Container.Controls.Add(this.lab0_UC1);
            this.UC_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Container.Location = new System.Drawing.Point(200, 50);
            this.UC_Container.Name = "UC_Container";
            this.UC_Container.Size = new System.Drawing.Size(1061, 581);
            this.UC_Container.TabIndex = 2;
            // 
            // lab10_UC1
            // 
            this.lab10_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lab10_UC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lab10_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab10_UC1.ForeColor = System.Drawing.Color.White;
            this.lab10_UC1.Location = new System.Drawing.Point(0, 0);
            this.lab10_UC1.Name = "lab10_UC1";
            this.lab10_UC1.Size = new System.Drawing.Size(1061, 581);
            this.lab10_UC1.TabIndex = 12;
            this.lab10_UC1.Load += new System.EventHandler(this.lab10_UC1_Load);
            // 
            // lab0_UC1
            // 
            this.lab0_UC1.AllowDrop = true;
            this.lab0_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lab0_UC1.Location = new System.Drawing.Point(0, 0);
            this.lab0_UC1.Name = "lab0_UC1";
            this.lab0_UC1.Size = new System.Drawing.Size(1061, 581);
            this.lab0_UC1.TabIndex = 2;
            // 
            // OP1_Labs_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1261, 631);
            this.Controls.Add(this.UC_Container);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OP1_Labs_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КР";
            this.TransparencyKey = System.Drawing.Color.ForestGreen;
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.UC_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Button BTN_Minimize;
        private System.Windows.Forms.Panel panelActiveButton;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel UC_Container;
        private UserControls.Start0_UC lab0_UC1;
        private UserControls.Start10_UC lab10_UC1;
    }
}

