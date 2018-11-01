namespace PhotoRenamer
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.rdoTile = new System.Windows.Forms.RadioButton();
			this.rdoList = new System.Windows.Forms.RadioButton();
			this.listViewImages = new System.Windows.Forms.ListView();
			this.lstPreview = new System.Windows.Forms.ListView();
			this.lblOutput = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ctmOpen = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.lstExifTags = new System.Windows.Forms.ListBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnAddExif = new System.Windows.Forms.Button();
			this.txtFilenameFormula = new System.Windows.Forms.TextBox();
			this.btnRename = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblExifWarning = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.ctmOpen.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.White;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1541, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem1,
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openFolderToolStripMenuItem1
			// 
			this.openFolderToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openFolderToolStripMenuItem1.Image")));
			this.openFolderToolStripMenuItem1.Name = "openFolderToolStripMenuItem1";
			this.openFolderToolStripMenuItem1.Size = new System.Drawing.Size(175, 26);
			this.openFolderToolStripMenuItem1.Text = "Open Folder...";
			this.openFolderToolStripMenuItem1.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
			// 
			// openFileToolStripMenuItem
			// 
			this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
			this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
			this.openFileToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
			this.openFileToolStripMenuItem.Text = "Open File...";
			this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.Image")));
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.White;
			this.btnDelete.Enabled = false;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(144, 33);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(140, 43);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "         Remove";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.White;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(16, 33);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(128, 43);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "      Open";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// rdoTile
			// 
			this.rdoTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.rdoTile.AutoSize = true;
			this.rdoTile.BackColor = System.Drawing.Color.White;
			this.rdoTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoTile.BackgroundImage")));
			this.rdoTile.Location = new System.Drawing.Point(948, 373);
			this.rdoTile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdoTile.Name = "rdoTile";
			this.rdoTile.Size = new System.Drawing.Size(53, 38);
			this.rdoTile.TabIndex = 7;
			this.rdoTile.TabStop = true;
			this.rdoTile.Text = "  \r\n      ";
			this.rdoTile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.rdoTile.UseVisualStyleBackColor = false;
			this.rdoTile.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
			// 
			// rdoList
			// 
			this.rdoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.rdoList.AutoSize = true;
			this.rdoList.BackColor = System.Drawing.Color.White;
			this.rdoList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoList.BackgroundImage")));
			this.rdoList.Location = new System.Drawing.Point(903, 373);
			this.rdoList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdoList.Name = "rdoList";
			this.rdoList.Size = new System.Drawing.Size(53, 38);
			this.rdoList.TabIndex = 6;
			this.rdoList.TabStop = true;
			this.rdoList.Text = "  \r\n      ";
			this.rdoList.UseVisualStyleBackColor = false;
			this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
			// 
			// listViewImages
			// 
			this.listViewImages.AllowDrop = true;
			this.listViewImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewImages.BackColor = System.Drawing.Color.White;
			this.listViewImages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewImages.BackgroundImage")));
			this.listViewImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewImages.Location = new System.Drawing.Point(16, 79);
			this.listViewImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.listViewImages.Name = "listViewImages";
			this.listViewImages.Size = new System.Drawing.Size(986, 333);
			this.listViewImages.TabIndex = 5;
			this.listViewImages.UseCompatibleStateImageBehavior = false;
			this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.listViewImages_SelectedIndexChanged);
			this.listViewImages.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewImages_DragDrop);
			this.listViewImages.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewImages_DragEnter);
			// 
			// lstPreview
			// 
			this.lstPreview.AllowDrop = true;
			this.lstPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstPreview.BackColor = System.Drawing.Color.White;
			this.lstPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstPreview.Location = new System.Drawing.Point(1009, 79);
			this.lstPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lstPreview.Name = "lstPreview";
			this.lstPreview.Size = new System.Drawing.Size(515, 333);
			this.lstPreview.TabIndex = 10;
			this.lstPreview.UseCompatibleStateImageBehavior = false;
			this.lstPreview.View = System.Windows.Forms.View.List;
			// 
			// lblOutput
			// 
			this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutput.AutoSize = true;
			this.lblOutput.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput.Location = new System.Drawing.Point(1019, 43);
			this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(145, 24);
			this.lblOutput.TabIndex = 11;
			this.lblOutput.Text = "Output Preview";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 437);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 12;
			this.label1.Text = "EXIF Options";
			// 
			// ctmOpen
			// 
			this.ctmOpen.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ctmOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.openFileToolStripMenuItem1});
			this.ctmOpen.Name = "ctmOpen";
			this.ctmOpen.Size = new System.Drawing.Size(174, 56);
			// 
			// openFolderToolStripMenuItem
			// 
			this.openFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFolderToolStripMenuItem.Image")));
			this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
			this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
			this.openFolderToolStripMenuItem.Text = "Open Folder...";
			this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
			// 
			// openFileToolStripMenuItem1
			// 
			this.openFileToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem1.Image")));
			this.openFileToolStripMenuItem1.Name = "openFileToolStripMenuItem1";
			this.openFileToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
			this.openFileToolStripMenuItem1.Text = "Open File...";
			this.openFileToolStripMenuItem1.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
			// 
			// lstExifTags
			// 
			this.lstExifTags.FormattingEnabled = true;
			this.lstExifTags.ItemHeight = 16;
			this.lstExifTags.Location = new System.Drawing.Point(20, 465);
			this.lstExifTags.Name = "lstExifTags";
			this.lstExifTags.Size = new System.Drawing.Size(697, 148);
			this.lstExifTags.TabIndex = 13;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(453, 442);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(264, 21);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "Only Show Exif Tags All Images Have";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// btnAddExif
			// 
			this.btnAddExif.Location = new System.Drawing.Point(514, 619);
			this.btnAddExif.Name = "btnAddExif";
			this.btnAddExif.Size = new System.Drawing.Size(203, 35);
			this.btnAddExif.TabIndex = 15;
			this.btnAddExif.Text = "Add Exif Tag To Name";
			this.btnAddExif.UseVisualStyleBackColor = true;
			this.btnAddExif.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtFilenameFormula
			// 
			this.txtFilenameFormula.Location = new System.Drawing.Point(723, 632);
			this.txtFilenameFormula.Name = "txtFilenameFormula";
			this.txtFilenameFormula.Size = new System.Drawing.Size(664, 22);
			this.txtFilenameFormula.TabIndex = 16;
			this.txtFilenameFormula.TextChanged += new System.EventHandler(this.txtFilenameFormula_TextChanged);
			// 
			// btnRename
			// 
			this.btnRename.Location = new System.Drawing.Point(1261, 419);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(75, 23);
			this.btnRename.TabIndex = 18;
			this.btnRename.Text = "Rename Files";
			this.btnRename.UseVisualStyleBackColor = true;
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(724, 609);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "Filename Formula";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(723, 537);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(658, 68);
			this.label3.TabIndex = 20;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// lblExifWarning
			// 
			this.lblExifWarning.AutoSize = true;
			this.lblExifWarning.ForeColor = System.Drawing.Color.Red;
			this.lblExifWarning.Location = new System.Drawing.Point(1223, 49);
			this.lblExifWarning.Name = "lblExifWarning";
			this.lblExifWarning.Size = new System.Drawing.Size(301, 17);
			this.lblExifWarning.TabIndex = 21;
			this.lblExifWarning.Text = "Some Images Do Not Have All Listed Exif Tags";
			this.lblExifWarning.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1541, 666);
			this.Controls.Add(this.lblExifWarning);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRename);
			this.Controls.Add(this.txtFilenameFormula);
			this.Controls.Add(this.btnAddExif);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.lstExifTags);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.lstPreview);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.rdoTile);
			this.Controls.Add(this.rdoList);
			this.Controls.Add(this.listViewImages);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "Photographic Rename Utility";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ctmOpen.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdoTile;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.ListView lstPreview;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ctmOpen;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem1;
		private System.Windows.Forms.ListBox lstExifTags;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnAddExif;
		private System.Windows.Forms.TextBox txtFilenameFormula;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblExifWarning;
	}
}

