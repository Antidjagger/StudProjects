namespace AISFonotekaFrameWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnOpenRecordTypes = new System.Windows.Forms.Button();
            this.btnOpenStudios = new System.Windows.Forms.Button();
            this.btnStyle = new System.Windows.Forms.Button();
            this.btnCompositions = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnArtistCompositions = new System.Windows.Forms.Button();
            this.MainToolMenu = new System.Windows.Forms.MenuStrip();
            this.tSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.MainToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.btnOpenRecordTypes);
            this.groupBox1.Controls.Add(this.btnOpenStudios);
            this.groupBox1.Controls.Add(this.btnStyle);
            this.groupBox1.Controls.Add(this.btnCompositions);
            this.groupBox1.Controls.Add(this.btnAlbums);
            this.groupBox1.Controls.Add(this.btnArtistCompositions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 410);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // btnLog
            // 
            this.btnLog.Enabled = false;
            this.btnLog.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLog.Image = global::AISFonotekaFrameWork.Properties.Resources.back3_1;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLog.Location = new System.Drawing.Point(0, 315);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(268, 41);
            this.btnLog.TabIndex = 6;
            this.btnLog.TabStop = false;
            this.btnLog.Text = "Журнал лога";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Visible = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnOpenRecordTypes
            // 
            this.btnOpenRecordTypes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenRecordTypes.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOpenRecordTypes.Image = global::AISFonotekaFrameWork.Properties.Resources.back3_1;
            this.btnOpenRecordTypes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenRecordTypes.Location = new System.Drawing.Point(0, 268);
            this.btnOpenRecordTypes.Name = "btnOpenRecordTypes";
            this.btnOpenRecordTypes.Size = new System.Drawing.Size(268, 41);
            this.btnOpenRecordTypes.TabIndex = 5;
            this.btnOpenRecordTypes.Text = "Доступные носители";
            this.btnOpenRecordTypes.UseVisualStyleBackColor = true;
            this.btnOpenRecordTypes.Click += new System.EventHandler(this.btnOpenRecordTypes_Click);
            // 
            // btnOpenStudios
            // 
            this.btnOpenStudios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenStudios.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOpenStudios.Image = global::AISFonotekaFrameWork.Properties.Resources.back3_1;
            this.btnOpenStudios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenStudios.Location = new System.Drawing.Point(0, 221);
            this.btnOpenStudios.Name = "btnOpenStudios";
            this.btnOpenStudios.Size = new System.Drawing.Size(268, 41);
            this.btnOpenStudios.TabIndex = 4;
            this.btnOpenStudios.Text = "Студии";
            this.btnOpenStudios.UseVisualStyleBackColor = true;
            this.btnOpenStudios.Click += new System.EventHandler(this.btnOpenStudios_Click);
            // 
            // btnStyle
            // 
            this.btnStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStyle.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnStyle.Image = global::AISFonotekaFrameWork.Properties.Resources.back3_1;
            this.btnStyle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStyle.Location = new System.Drawing.Point(0, 174);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(268, 41);
            this.btnStyle.TabIndex = 3;
            this.btnStyle.Text = "Музыкальные жанры";
            this.btnStyle.UseVisualStyleBackColor = true;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // btnCompositions
            // 
            this.btnCompositions.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCompositions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCompositions.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCompositions.Image = ((System.Drawing.Image)(resources.GetObject("btnCompositions.Image")));
            this.btnCompositions.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompositions.Location = new System.Drawing.Point(0, 19);
            this.btnCompositions.Name = "btnCompositions";
            this.btnCompositions.Size = new System.Drawing.Size(268, 41);
            this.btnCompositions.TabIndex = 0;
            this.btnCompositions.Text = "Композиции в фонотеке";
            this.btnCompositions.UseVisualStyleBackColor = true;
            this.btnCompositions.Click += new System.EventHandler(this.btnCompositions_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAlbums.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAlbums.Image = global::AISFonotekaFrameWork.Properties.Resources.back3_1;
            this.btnAlbums.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlbums.Location = new System.Drawing.Point(0, 127);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(268, 41);
            this.btnAlbums.TabIndex = 1;
            this.btnAlbums.Text = "Альбомы";
            this.btnAlbums.UseVisualStyleBackColor = true;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);
            // 
            // btnArtistCompositions
            // 
            this.btnArtistCompositions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArtistCompositions.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnArtistCompositions.Image = global::AISFonotekaFrameWork.Properties.Resources.back3_1;
            this.btnArtistCompositions.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArtistCompositions.Location = new System.Drawing.Point(0, 66);
            this.btnArtistCompositions.Name = "btnArtistCompositions";
            this.btnArtistCompositions.Size = new System.Drawing.Size(268, 55);
            this.btnArtistCompositions.TabIndex = 2;
            this.btnArtistCompositions.Text = "Список исполнителей и композиций";
            this.btnArtistCompositions.UseVisualStyleBackColor = true;
            this.btnArtistCompositions.Click += new System.EventHandler(this.btnArtistCompositions_Click);
            // 
            // MainToolMenu
            // 
            this.MainToolMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainToolMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIFile});
            this.MainToolMenu.Location = new System.Drawing.Point(0, 0);
            this.MainToolMenu.Name = "MainToolMenu";
            this.MainToolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainToolMenu.Size = new System.Drawing.Size(800, 28);
            this.MainToolMenu.TabIndex = 4;
            this.MainToolMenu.Text = "menuStrip1";
            // 
            // tSMIFile
            // 
            this.tSMIFile.AutoSize = false;
            this.tSMIFile.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.backMenu2;
            this.tSMIFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIAbout,
            this.tSMIExit});
            this.tSMIFile.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSMIFile.ForeColor = System.Drawing.Color.AliceBlue;
            this.tSMIFile.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tSMIFile.Name = "tSMIFile";
            this.tSMIFile.ShortcutKeyDisplayString = "F1";
            this.tSMIFile.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tSMIFile.Size = new System.Drawing.Size(60, 24);
            this.tSMIFile.Text = "Файл";
            this.tSMIFile.ToolTipText = "Клавиша быстрого доступа: F1";
            // 
            // tSMIAbout
            // 
            this.tSMIAbout.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.backMenu2;
            this.tSMIAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tSMIAbout.ForeColor = System.Drawing.Color.AliceBlue;
            this.tSMIAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSMIAbout.Name = "tSMIAbout";
            this.tSMIAbout.Size = new System.Drawing.Size(182, 24);
            this.tSMIAbout.Text = "О проекте";
            this.tSMIAbout.Click += new System.EventHandler(this.tSMIAbout_Click);
            // 
            // tSMIExit
            // 
            this.tSMIExit.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.backMenu2;
            this.tSMIExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tSMIExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.tSMIExit.Name = "tSMIExit";
            this.tSMIExit.ShortcutKeyDisplayString = "Alt+F4";
            this.tSMIExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tSMIExit.Size = new System.Drawing.Size(182, 24);
            this.tSMIExit.Text = "Выход";
            this.tSMIExit.Click += new System.EventHandler(this.tSMIExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.back4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainToolMenu);
            this.MainMenuStrip = this.MainToolMenu;
            this.Name = "MainForm";
            this.Text = "Интерфейс пользователя АИС Фонотека v 1.0 beta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppExit);
            this.groupBox1.ResumeLayout(false);
            this.MainToolMenu.ResumeLayout(false);
            this.MainToolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompositions;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnArtistCompositions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenRecordTypes;
        private System.Windows.Forms.Button btnOpenStudios;
        private System.Windows.Forms.Button btnStyle;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.MenuStrip MainToolMenu;
        private System.Windows.Forms.ToolStripMenuItem tSMIFile;
        private System.Windows.Forms.ToolStripMenuItem tSMIAbout;
        private System.Windows.Forms.ToolStripMenuItem tSMIExit;
    }
}