namespace AISFonotekaFrameWork
{
    partial class StylesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StylesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Styles = new System.Windows.Forms.DataGridView();
            this.cMSStyles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIAddStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdateStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.stylesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aISFonotekaTablesDataSet = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            this.stylesTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Compositions = new System.Windows.Forms.DataGridView();
            this.iDCompositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timelapseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSOpenAlbum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIOpenAlbumForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddComposition = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteComposition = new System.Windows.Forms.ToolStripMenuItem();
            this.fKStyleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.CompositionsTableAdapter();
            this.artistsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.ArtistsTableAdapter();
            this.albumsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            this.iDStylesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Styles)).BeginInit();
            this.cMSStyles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Compositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.cMSOpenAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKStyleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Styles
            // 
            this.dGV_Styles.AllowUserToAddRows = false;
            this.dGV_Styles.AllowUserToDeleteRows = false;
            this.dGV_Styles.AutoGenerateColumns = false;
            this.dGV_Styles.BackgroundColor = System.Drawing.Color.Khaki;
            this.dGV_Styles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Styles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDStylesDataGridViewTextBoxColumn,
            this.styleNameDataGridViewTextBoxColumn});
            this.dGV_Styles.ContextMenuStrip = this.cMSStyles;
            this.dGV_Styles.DataSource = this.stylesBindingSource;
            this.dGV_Styles.Location = new System.Drawing.Point(23, 37);
            this.dGV_Styles.Name = "dGV_Styles";
            this.dGV_Styles.RowHeadersVisible = false;
            this.dGV_Styles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Styles.Size = new System.Drawing.Size(204, 376);
            this.dGV_Styles.TabIndex = 1;
            this.dGV_Styles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Styles_CellEndEdit);
            // 
            // cMSStyles
            // 
            this.cMSStyles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cMSStyles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cMSStyles.BackgroundImage")));
            this.cMSStyles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cMSStyles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIAddStyle,
            this.tSMIUpdateStyle,
            this.tSMIDeleteStyle});
            this.cMSStyles.Name = "cMSOpenAlbum";
            this.cMSStyles.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMSStyles.Size = new System.Drawing.Size(193, 70);
            // 
            // tSMIAddStyle
            // 
            this.tSMIAddStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIAddStyle.BackgroundImage")));
            this.tSMIAddStyle.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIAddStyle.ForeColor = System.Drawing.Color.White;
            this.tSMIAddStyle.Image = ((System.Drawing.Image)(resources.GetObject("tSMIAddStyle.Image")));
            this.tSMIAddStyle.Name = "tSMIAddStyle";
            this.tSMIAddStyle.Size = new System.Drawing.Size(192, 22);
            this.tSMIAddStyle.Text = "Добавить жанр";
            this.tSMIAddStyle.Click += new System.EventHandler(this.tSMIAddStyle_Click);
            // 
            // tSMIUpdateStyle
            // 
            this.tSMIUpdateStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIUpdateStyle.BackgroundImage")));
            this.tSMIUpdateStyle.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIUpdateStyle.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdateStyle.Image = ((System.Drawing.Image)(resources.GetObject("tSMIUpdateStyle.Image")));
            this.tSMIUpdateStyle.Name = "tSMIUpdateStyle";
            this.tSMIUpdateStyle.Size = new System.Drawing.Size(192, 22);
            this.tSMIUpdateStyle.Text = "Обновить";
            this.tSMIUpdateStyle.Click += new System.EventHandler(this.tSMIUpdateStyle_Click);
            // 
            // tSMIDeleteStyle
            // 
            this.tSMIDeleteStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteStyle.BackgroundImage")));
            this.tSMIDeleteStyle.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIDeleteStyle.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteStyle.Image = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteStyle.Image")));
            this.tSMIDeleteStyle.Name = "tSMIDeleteStyle";
            this.tSMIDeleteStyle.Size = new System.Drawing.Size(192, 22);
            this.tSMIDeleteStyle.Text = "Удалить жанр";
            this.tSMIDeleteStyle.Click += new System.EventHandler(this.tSMIDeleteStyle_Click);
            // 
            // stylesBindingSource
            // 
            this.stylesBindingSource.DataMember = "Styles";
            this.stylesBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // aISFonotekaTablesDataSet
            // 
            this.aISFonotekaTablesDataSet.DataSetName = "AISFonotekaTablesDataSet";
            this.aISFonotekaTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stylesTableAdapter
            // 
            this.stylesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список жанров:";
            // 
            // dGV_Compositions
            // 
            this.dGV_Compositions.AllowUserToAddRows = false;
            this.dGV_Compositions.AllowUserToDeleteRows = false;
            this.dGV_Compositions.AutoGenerateColumns = false;
            this.dGV_Compositions.BackgroundColor = System.Drawing.Color.Khaki;
            this.dGV_Compositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Compositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCompositionDataGridViewTextBoxColumn,
            this.compositionNameDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.timelapseDataGridViewTextBoxColumn,
            this.creationYearDataGridViewTextBoxColumn,
            this.cLanguageDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dGV_Compositions.ContextMenuStrip = this.cMSOpenAlbum;
            this.dGV_Compositions.DataSource = this.fKStyleBindingSource;
            this.dGV_Compositions.Location = new System.Drawing.Point(263, 37);
            this.dGV_Compositions.Name = "dGV_Compositions";
            this.dGV_Compositions.RowHeadersVisible = false;
            this.dGV_Compositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Compositions.Size = new System.Drawing.Size(754, 376);
            this.dGV_Compositions.TabIndex = 3;
            this.dGV_Compositions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Compositions_CellEndEdit);
            // 
            // iDCompositionDataGridViewTextBoxColumn
            // 
            this.iDCompositionDataGridViewTextBoxColumn.DataPropertyName = "ID_Composition";
            this.iDCompositionDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCompositionDataGridViewTextBoxColumn.Name = "iDCompositionDataGridViewTextBoxColumn";
            this.iDCompositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCompositionDataGridViewTextBoxColumn.Width = 40;
            // 
            // compositionNameDataGridViewTextBoxColumn
            // 
            this.compositionNameDataGridViewTextBoxColumn.DataPropertyName = "CompositionName";
            this.compositionNameDataGridViewTextBoxColumn.HeaderText = "Название композиции";
            this.compositionNameDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.compositionNameDataGridViewTextBoxColumn.Name = "compositionNameDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.DataSource = this.artistsBindingSource;
            this.artistDataGridViewTextBoxColumn.DisplayMember = "Artist_Name";
            this.artistDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.artistDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artistDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artistDataGridViewTextBoxColumn.ValueMember = "ID_Artist";
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.DataSource = this.albumsBindingSource;
            this.albumDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.albumDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.albumDataGridViewTextBoxColumn.HeaderText = "Альбом";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.albumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.albumDataGridViewTextBoxColumn.ValueMember = "ID_Album";
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // timelapseDataGridViewTextBoxColumn
            // 
            this.timelapseDataGridViewTextBoxColumn.DataPropertyName = "Timelapse";
            this.timelapseDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.timelapseDataGridViewTextBoxColumn.Name = "timelapseDataGridViewTextBoxColumn";
            this.timelapseDataGridViewTextBoxColumn.Width = 110;
            // 
            // creationYearDataGridViewTextBoxColumn
            // 
            this.creationYearDataGridViewTextBoxColumn.DataPropertyName = "CreationYear";
            this.creationYearDataGridViewTextBoxColumn.HeaderText = "Год создания";
            this.creationYearDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.creationYearDataGridViewTextBoxColumn.Name = "creationYearDataGridViewTextBoxColumn";
            // 
            // cLanguageDataGridViewTextBoxColumn
            // 
            this.cLanguageDataGridViewTextBoxColumn.DataPropertyName = "CLanguage";
            this.cLanguageDataGridViewTextBoxColumn.HeaderText = "Язык композиции";
            this.cLanguageDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.cLanguageDataGridViewTextBoxColumn.Name = "cLanguageDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // cMSOpenAlbum
            // 
            this.cMSOpenAlbum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cMSOpenAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cMSOpenAlbum.BackgroundImage")));
            this.cMSOpenAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cMSOpenAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIOpenAlbumForm,
            this.tSMIAddComposition,
            this.tSMIUpdate,
            this.tSMIDeleteComposition});
            this.cMSOpenAlbum.Name = "cMSOpenAlbum";
            this.cMSOpenAlbum.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMSOpenAlbum.Size = new System.Drawing.Size(357, 92);
            // 
            // tSMIOpenAlbumForm
            // 
            this.tSMIOpenAlbumForm.BackColor = System.Drawing.Color.Maroon;
            this.tSMIOpenAlbumForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIOpenAlbumForm.BackgroundImage")));
            this.tSMIOpenAlbumForm.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIOpenAlbumForm.ForeColor = System.Drawing.Color.White;
            this.tSMIOpenAlbumForm.Image = ((System.Drawing.Image)(resources.GetObject("tSMIOpenAlbumForm.Image")));
            this.tSMIOpenAlbumForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSMIOpenAlbumForm.Name = "tSMIOpenAlbumForm";
            this.tSMIOpenAlbumForm.Size = new System.Drawing.Size(356, 22);
            this.tSMIOpenAlbumForm.Text = "Посмотреть информацию о альбоме";
            this.tSMIOpenAlbumForm.Click += new System.EventHandler(this.tSMIOpenAlbumForm_Click);
            // 
            // tSMIAddComposition
            // 
            this.tSMIAddComposition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIAddComposition.BackgroundImage")));
            this.tSMIAddComposition.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIAddComposition.ForeColor = System.Drawing.Color.White;
            this.tSMIAddComposition.Image = ((System.Drawing.Image)(resources.GetObject("tSMIAddComposition.Image")));
            this.tSMIAddComposition.Name = "tSMIAddComposition";
            this.tSMIAddComposition.Size = new System.Drawing.Size(356, 22);
            this.tSMIAddComposition.Text = "Добавить композицию";
            this.tSMIAddComposition.Click += new System.EventHandler(this.tSMIAddComposition_Click);
            // 
            // tSMIUpdate
            // 
            this.tSMIUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.BackgroundImage")));
            this.tSMIUpdate.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIUpdate.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.Image")));
            this.tSMIUpdate.Name = "tSMIUpdate";
            this.tSMIUpdate.Size = new System.Drawing.Size(356, 22);
            this.tSMIUpdate.Text = "Обновить";
            this.tSMIUpdate.Click += new System.EventHandler(this.tSMIUpdate_Click);
            // 
            // tSMIDeleteComposition
            // 
            this.tSMIDeleteComposition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteComposition.BackgroundImage")));
            this.tSMIDeleteComposition.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIDeleteComposition.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteComposition.Image = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteComposition.Image")));
            this.tSMIDeleteComposition.Name = "tSMIDeleteComposition";
            this.tSMIDeleteComposition.Size = new System.Drawing.Size(356, 22);
            this.tSMIDeleteComposition.Text = "Удалить композицию";
            this.tSMIDeleteComposition.Click += new System.EventHandler(this.tSMIDeleteComposition_Click);
            // 
            // fKStyleBindingSource
            // 
            this.fKStyleBindingSource.DataMember = "FK_Style";
            this.fKStyleBindingSource.DataSource = this.stylesBindingSource;
            // 
            // compositionsTableAdapter
            // 
            this.compositionsTableAdapter.ClearBeforeFill = true;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(263, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Композиции выбранного жанра:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = this.albumsTableAdapter;
            this.tableAdapterManager.ArtistsTableAdapter = this.artistsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompositionsTableAdapter = this.compositionsTableAdapter;
            this.tableAdapterManager.LogJournalTableAdapter = null;
            this.tableAdapterManager.RecordTypeTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.StylesTableAdapter = this.stylesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDStylesDataGridViewTextBoxColumn
            // 
            this.iDStylesDataGridViewTextBoxColumn.DataPropertyName = "ID_Styles";
            this.iDStylesDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDStylesDataGridViewTextBoxColumn.Name = "iDStylesDataGridViewTextBoxColumn";
            this.iDStylesDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDStylesDataGridViewTextBoxColumn.Width = 40;
            // 
            // styleNameDataGridViewTextBoxColumn
            // 
            this.styleNameDataGridViewTextBoxColumn.DataPropertyName = "style_Name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.styleNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.styleNameDataGridViewTextBoxColumn.HeaderText = "Название жанра";
            this.styleNameDataGridViewTextBoxColumn.Name = "styleNameDataGridViewTextBoxColumn";
            this.styleNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // StylesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGV_Compositions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Styles);
            this.Name = "StylesForm";
            this.Text = "StylesForm";
            this.Load += new System.EventHandler(this.StylesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Styles)).EndInit();
            this.cMSStyles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Compositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.cMSOpenAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKStyleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Styles;
        private AISFonotekaTablesDataSet aISFonotekaTablesDataSet;
        private System.Windows.Forms.BindingSource stylesBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter stylesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Compositions;
        private System.Windows.Forms.BindingSource fKStyleBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.CompositionsTableAdapter compositionsTableAdapter;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCompositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelapseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cMSOpenAlbum;
        public System.Windows.Forms.ToolStripMenuItem tSMIOpenAlbumForm;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddComposition;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdate;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteComposition;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip cMSStyles;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddStyle;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdateStyle;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStylesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleNameDataGridViewTextBoxColumn;
    }
}