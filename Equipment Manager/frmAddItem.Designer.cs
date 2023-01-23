namespace Equipment_Manager
{
    partial class frmAddItem
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
            this.lstItemTypeSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstItemTypeSelector
            // 
            this.lstItemTypeSelector.FormattingEnabled = true;
            this.lstItemTypeSelector.Items.AddRange(new object[] {
            "Type...",
            "Item",
            "Weapon",
            "Armor"});
            this.lstItemTypeSelector.Location = new System.Drawing.Point(66, 41);
            this.lstItemTypeSelector.Name = "lstItemTypeSelector";
            this.lstItemTypeSelector.Size = new System.Drawing.Size(151, 28);
            this.lstItemTypeSelector.TabIndex = 0;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstItemTypeSelector);
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox lstItemTypeSelector;
    }
}