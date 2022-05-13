
namespace Progr_Graf_Winforms_Lab
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textAlgroupBox = new System.Windows.Forms.GroupBox();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this.CenterRadioButton = new System.Windows.Forms.RadioButton();
            this.LeftRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CanselButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.textAlgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontSizeLabel
            // 
            resources.ApplyResources(this.fontSizeLabel, "fontSizeLabel");
            this.fontSizeLabel.Name = "fontSizeLabel";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // textAlgroupBox
            // 
            this.textAlgroupBox.Controls.Add(this.rightRadioButton);
            this.textAlgroupBox.Controls.Add(this.CenterRadioButton);
            this.textAlgroupBox.Controls.Add(this.LeftRadioButton);
            resources.ApplyResources(this.textAlgroupBox, "textAlgroupBox");
            this.textAlgroupBox.Name = "textAlgroupBox";
            this.textAlgroupBox.TabStop = false;
            // 
            // rightRadioButton
            // 
            resources.ApplyResources(this.rightRadioButton, "rightRadioButton");
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            // 
            // CenterRadioButton
            // 
            resources.ApplyResources(this.CenterRadioButton, "CenterRadioButton");
            this.CenterRadioButton.Name = "CenterRadioButton";
            this.CenterRadioButton.UseVisualStyleBackColor = true;
            // 
            // LeftRadioButton
            // 
            resources.ApplyResources(this.LeftRadioButton, "LeftRadioButton");
            this.LeftRadioButton.Checked = true;
            this.LeftRadioButton.Name = "LeftRadioButton";
            this.LeftRadioButton.TabStop = true;
            this.LeftRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // CanselButton
            // 
            this.CanselButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.CanselButton, "CanselButton");
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textAlgroupBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.fontSizeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.textAlgroupBox.ResumeLayout(false);
            this.textAlgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox textAlgroupBox;
        private System.Windows.Forms.RadioButton rightRadioButton;
        private System.Windows.Forms.RadioButton CenterRadioButton;
        private System.Windows.Forms.RadioButton LeftRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Button OkButton;
    }
}