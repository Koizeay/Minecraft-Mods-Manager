namespace Minecraft_Mods_Manager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.checkedListBoxMods = new System.Windows.Forms.CheckedListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonOpenModsDir = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxMods
            // 
            this.checkedListBoxMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxMods.FormattingEnabled = true;
            this.checkedListBoxMods.Location = new System.Drawing.Point(12, 39);
            this.checkedListBoxMods.Name = "checkedListBoxMods";
            this.checkedListBoxMods.Size = new System.Drawing.Size(775, 292);
            this.checkedListBoxMods.TabIndex = 0;
            this.checkedListBoxMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxMods_ItemCheck);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Mods";
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.Location = new System.Drawing.Point(689, 9);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(98, 22);
            this.buttonReload.TabIndex = 2;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(12, 337);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(722, 23);
            this.textBoxPath.TabIndex = 3;
            // 
            // buttonPath
            // 
            this.buttonPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPath.Location = new System.Drawing.Point(740, 337);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(47, 23);
            this.buttonPath.TabIndex = 4;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Choose your Minecraft mods folder";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // buttonOpenModsDir
            // 
            this.buttonOpenModsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenModsDir.Location = new System.Drawing.Point(614, 366);
            this.buttonOpenModsDir.Name = "buttonOpenModsDir";
            this.buttonOpenModsDir.Size = new System.Drawing.Size(173, 22);
            this.buttonOpenModsDir.TabIndex = 5;
            this.buttonOpenModsDir.Text = "Open mods folder in explorer";
            this.buttonOpenModsDir.UseVisualStyleBackColor = true;
            this.buttonOpenModsDir.Click += new System.EventHandler(this.buttonOpenModsDir_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(12, 366);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 22);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 400);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOpenModsDir);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkedListBoxMods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Minecraft Mods Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBoxMods;
        private Label labelTitle;
        private Button buttonReload;
        private TextBox textBoxPath;
        private Button buttonPath;
        private FolderBrowserDialog folderBrowserDialog;
        private Button buttonOpenModsDir;
        private Button buttonDelete;
    }
}