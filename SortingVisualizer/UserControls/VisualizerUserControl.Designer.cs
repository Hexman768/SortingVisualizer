namespace SortingVisualizer.UserControls
{
    partial class VisualizerUserControl
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
            this.algorithmCBx = new System.Windows.Forms.ComboBox();
            this.algorithmLbl = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // algorithmCBx
            // 
            this.algorithmCBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmCBx.FormattingEnabled = true;
            this.algorithmCBx.Items.AddRange(new object[] {
            "Bubble",
            "Quick",
            "Selection",
            "Insertion",
            "Heap",
            "Cocktail",
            "Gnome",
            "Bogo"});
            this.algorithmCBx.Location = new System.Drawing.Point(616, 5);
            this.algorithmCBx.Name = "algorithmCBx";
            this.algorithmCBx.Size = new System.Drawing.Size(116, 21);
            this.algorithmCBx.TabIndex = 11;
            // 
            // algorithmLbl
            // 
            this.algorithmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmLbl.AutoSize = true;
            this.algorithmLbl.Location = new System.Drawing.Point(738, 13);
            this.algorithmLbl.Name = "algorithmLbl";
            this.algorithmLbl.Size = new System.Drawing.Size(50, 13);
            this.algorithmLbl.TabIndex = 10;
            this.algorithmLbl.Text = "Algorithm";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(84, 3);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 9;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(3, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainPanel.Location = new System.Drawing.Point(0, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(791, 455);
            this.mainPanel.TabIndex = 12;
            // 
            // VisualizerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.algorithmCBx);
            this.Controls.Add(this.algorithmLbl);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.resetBtn);
            this.Name = "VisualizerUserControl";
            this.Size = new System.Drawing.Size(791, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algorithmCBx;
        private System.Windows.Forms.Label algorithmLbl;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel mainPanel;
    }
}
