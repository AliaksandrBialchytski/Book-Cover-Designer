
namespace Progr_Graf_Winforms_Lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTtextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AddTextLabel = new System.Windows.Forms.Label();
            this.addTextButton = new System.Windows.Forms.Button();
            this.labelClrSettings = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCLRBackGround = new System.Windows.Forms.Label();
            this.labelClrText = new System.Windows.Forms.Label();
            this.buttonClrBackGround = new System.Windows.Forms.Button();
            this.buttonClrText = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RussianStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleTtextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AuthorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AuthorTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddTextLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.addTextButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelClrSettings, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // titleTtextBox
            // 
            resources.ApplyResources(this.titleTtextBox, "titleTtextBox");
            this.titleTtextBox.Name = "titleTtextBox";
            this.titleTtextBox.TextChanged += new System.EventHandler(this.titleTtextBox_TextChanged);
            // 
            // AuthorLabel
            // 
            resources.ApplyResources(this.AuthorLabel, "AuthorLabel");
            this.AuthorLabel.Name = "AuthorLabel";
            // 
            // AuthorTextBox
            // 
            resources.ApplyResources(this.AuthorTextBox, "AuthorTextBox");
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // AddTextLabel
            // 
            resources.ApplyResources(this.AddTextLabel, "AddTextLabel");
            this.AddTextLabel.Name = "AddTextLabel";
            // 
            // addTextButton
            // 
            resources.ApplyResources(this.addTextButton, "addTextButton");
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.UseVisualStyleBackColor = true;
            this.addTextButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addTextButton_MouseClick);
            // 
            // labelClrSettings
            // 
            resources.ApplyResources(this.labelClrSettings, "labelClrSettings");
            this.labelClrSettings.Name = "labelClrSettings";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.labelCLRBackGround, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelClrText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonClrBackGround, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClrText, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // labelCLRBackGround
            // 
            resources.ApplyResources(this.labelCLRBackGround, "labelCLRBackGround");
            this.labelCLRBackGround.Name = "labelCLRBackGround";
            // 
            // labelClrText
            // 
            resources.ApplyResources(this.labelClrText, "labelClrText");
            this.labelClrText.Name = "labelClrText";
            // 
            // buttonClrBackGround
            // 
            resources.ApplyResources(this.buttonClrBackGround, "buttonClrBackGround");
            this.buttonClrBackGround.Name = "buttonClrBackGround";
            this.buttonClrBackGround.UseMnemonic = false;
            this.buttonClrBackGround.UseVisualStyleBackColor = true;
            this.buttonClrBackGround.Click += new System.EventHandler(this.buttonClrBackGround_Click);
            // 
            // buttonClrText
            // 
            resources.ApplyResources(this.buttonClrText, "buttonClrText");
            this.buttonClrText.Name = "buttonClrText";
            this.buttonClrText.UseVisualStyleBackColor = true;
            this.buttonClrText.Click += new System.EventHandler(this.buttonClrText_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem,
            this.SettingsStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileStripMenuItem
            // 
            this.FileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStripMenuItem1,
            this.OpenStripMenuItem,
            this.SaveStripMenuItem});
            this.FileStripMenuItem.Name = "FileStripMenuItem";
            resources.ApplyResources(this.FileStripMenuItem, "FileStripMenuItem");
            // 
            // NewStripMenuItem1
            // 
            this.NewStripMenuItem1.Name = "NewStripMenuItem1";
            resources.ApplyResources(this.NewStripMenuItem1, "NewStripMenuItem1");
            // 
            // OpenStripMenuItem
            // 
            this.OpenStripMenuItem.Name = "OpenStripMenuItem";
            resources.ApplyResources(this.OpenStripMenuItem, "OpenStripMenuItem");
            // 
            // SaveStripMenuItem
            // 
            this.SaveStripMenuItem.Name = "SaveStripMenuItem";
            resources.ApplyResources(this.SaveStripMenuItem, "SaveStripMenuItem");
            // 
            // SettingsStripMenuItem
            // 
            this.SettingsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageStripMenuItem});
            this.SettingsStripMenuItem.Name = "SettingsStripMenuItem";
            resources.ApplyResources(this.SettingsStripMenuItem, "SettingsStripMenuItem");
            // 
            // LanguageStripMenuItem
            // 
            this.LanguageStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnglishStripMenuItem,
            this.RussianStripMenuItem});
            this.LanguageStripMenuItem.Name = "LanguageStripMenuItem";
            resources.ApplyResources(this.LanguageStripMenuItem, "LanguageStripMenuItem");
            // 
            // EnglishStripMenuItem
            // 
            this.EnglishStripMenuItem.Checked = true;
            this.EnglishStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnglishStripMenuItem.Name = "EnglishStripMenuItem";
            resources.ApplyResources(this.EnglishStripMenuItem, "EnglishStripMenuItem");
            // 
            // RussianStripMenuItem
            // 
            this.RussianStripMenuItem.Name = "RussianStripMenuItem";
            resources.ApplyResources(this.RussianStripMenuItem, "RussianStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTtextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label AddTextLabel;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.Label labelClrSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelCLRBackGround;
        private System.Windows.Forms.Label labelClrText;
        private System.Windows.Forms.Button buttonClrBackGround;
        private System.Windows.Forms.Button buttonClrText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnglishStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RussianStripMenuItem;
    }
}

