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
            this.lstItemTypeSelector.Location = new System.Drawing.Point(12, 36);
            this.lstItemTypeSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstItemTypeSelector.Name = "lstItemTypeSelector";
            this.lstItemTypeSelector.Size = new System.Drawing.Size(133, 23);
            this.lstItemTypeSelector.TabIndex = 0;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.lstItemTypeSelector);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox lstItemTypeSelector;
    }
}