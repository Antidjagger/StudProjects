namespace AISFonotekaFrameWork
{
    partial class ArtistCompositionsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistCompositionsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Artist = new System.Windows.Forms.DataGridView();
            this.iDArtistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDGViewTBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSArtist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIAddArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdateArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSAIS = new System.Windows.Forms.BindingSource(this.components);
            this.aISFonotekaTablesDataSet = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            this.dGV_Compositions = new System.Windows.Forms.DataGridView();
            this.AlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCompositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlbumsBS = new System.Windows.Forms.BindingSource(this.components);
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stylesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timelapseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSOpenAlbum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIOpenAlbumForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddComposition = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteComposition = new System.Windows.Forms.ToolStripMenuItem();
            this.compositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stylesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.ArtistsTableAdapter();
            this.albumsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter();
            this.stylesTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter();
            this.recordTypeTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter();
            this.studiosTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter();
            this.compositionsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.CompositionsTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Artist)).BeginInit();
            this.cMSArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSAIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Compositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource1)).BeginInit();
            this.cMSOpenAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Artist
            // 
            this.dGV_Artist.AllowUserToAddRows = false;
            this.dGV_Artist.AutoGenerateColumns = false;
            this.dGV_Artist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Artist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(171)))), ((int)(((byte)(83)))));
            this.dGV_Artist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_Artist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Artist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dGV_Artist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Artist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDArtistDataGridViewTextBoxColumn,
            this.artistNameDGViewTBColumn});
            this.dGV_Artist.ContextMenuStrip = this.cMSArtist;
            this.dGV_Artist.DataSource = this.artistsBindingSource;
            this.dGV_Artist.GridColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.dGV_Artist, "dGV_Artist");
            this.dGV_Artist.MultiSelect = false;
            this.dGV_Artist.Name = "dGV_Artist";
            this.dGV_Artist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV_Artist.RowHeadersVisible = false;
            this.dGV_Artist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Artist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Artist_CellContentClick);
            this.dGV_Artist.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Artist_CellEndEdit);
            // 
            // iDArtistDataGridViewTextBoxColumn
            // 
            this.iDArtistDataGridViewTextBoxColumn.DataPropertyName = "ID_Artist";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.iDArtistDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.iDArtistDataGridViewTextBoxColumn, "iDArtistDataGridViewTextBoxColumn");
            this.iDArtistDataGridViewTextBoxColumn.Name = "iDArtistDataGridViewTextBoxColumn";
            this.iDArtistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistNameDGViewTBColumn
            // 
            this.artistNameDGViewTBColumn.DataPropertyName = "Artist_Name";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.artistNameDGViewTBColumn.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.artistNameDGViewTBColumn, "artistNameDGViewTBColumn");
            this.artistNameDGViewTBColumn.MaxInputLength = 500;
            this.artistNameDGViewTBColumn.Name = "artistNameDGViewTBColumn";
            // 
            // cMSArtist
            // 
            resources.ApplyResources(this.cMSArtist, "cMSArtist");
            this.cMSArtist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIAddArtist,
            this.tSMIUpdateArtist,
            this.tSMIDeleteArtist});
            this.cMSArtist.Name = "cMSArtist";
            this.cMSArtist.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // tSMIAddArtist
            // 
            resources.ApplyResources(this.tSMIAddArtist, "tSMIAddArtist");
            this.tSMIAddArtist.ForeColor = System.Drawing.Color.White;
            this.tSMIAddArtist.Name = "tSMIAddArtist";
            this.tSMIAddArtist.Click += new System.EventHandler(this.tSMIAddArtist_Click);
            // 
            // tSMIUpdateArtist
            // 
            resources.ApplyResources(this.tSMIUpdateArtist, "tSMIUpdateArtist");
            this.tSMIUpdateArtist.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdateArtist.Name = "tSMIUpdateArtist";
            this.tSMIUpdateArtist.Click += new System.EventHandler(this.tSMIUpdateArtist_Click);
            // 
            // tSMIDeleteArtist
            // 
            resources.ApplyResources(this.tSMIDeleteArtist, "tSMIDeleteArtist");
            this.tSMIDeleteArtist.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteArtist.Name = "tSMIDeleteArtist";
            this.tSMIDeleteArtist.Click += new System.EventHandler(this.tSMIDeleteArtist_Click);
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.bSAIS;
            // 
            // bSAIS
            // 
            this.bSAIS.DataSource = this.aISFonotekaTablesDataSet;
            this.bSAIS.Position = 0;
            // 
            // aISFonotekaTablesDataSet
            // 
            this.aISFonotekaTablesDataSet.DataSetName = "AISFonotekaTablesDataSet";
            this.aISFonotekaTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dGV_Compositions
            // 
            this.dGV_Compositions.AllowUserToAddRows = false;
            this.dGV_Compositions.AutoGenerateColumns = false;
            this.dGV_Compositions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Compositions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(171)))), ((int)(((byte)(83)))));
            this.dGV_Compositions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_Compositions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Compositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Compositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Compositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumID,
            this.iDCompositionDataGridViewTextBoxColumn,
            this.compositionNameDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.timelapseDataGridViewTextBoxColumn,
            this.creationYearDataGridViewTextBoxColumn,
            this.cLanguageDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dGV_Compositions.ContextMenuStrip = this.cMSOpenAlbum;
            this.dGV_Compositions.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.artistsBindingSource, "ID_Artist", true));
            this.dGV_Compositions.DataSource = this.compositionsBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Compositions.DefaultCellStyle = dataGridViewCellStyle15;
            this.dGV_Compositions.GridColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.dGV_Compositions, "dGV_Compositions");
            this.dGV_Compositions.Name = "dGV_Compositions";
            this.dGV_Compositions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV_Compositions.RowHeadersVisible = false;
            this.dGV_Compositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Compositions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Compositions_CellEndEdit);
            // 
            // AlbumID
            // 
            this.AlbumID.DataPropertyName = "Album";
            this.AlbumID.Frozen = true;
            resources.ApplyResources(this.AlbumID, "AlbumID");
            this.AlbumID.Name = "AlbumID";
            // 
            // iDCompositionDataGridViewTextBoxColumn
            // 
            this.iDCompositionDataGridViewTextBoxColumn.DataPropertyName = "ID_Composition";
            this.iDCompositionDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.iDCompositionDataGridViewTextBoxColumn, "iDCompositionDataGridViewTextBoxColumn");
            this.iDCompositionDataGridViewTextBoxColumn.Name = "iDCompositionDataGridViewTextBoxColumn";
            this.iDCompositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compositionNameDataGridViewTextBoxColumn
            // 
            this.compositionNameDataGridViewTextBoxColumn.DataPropertyName = "CompositionName";
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compositionNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.compositionNameDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.compositionNameDataGridViewTextBoxColumn, "compositionNameDataGridViewTextBoxColumn");
            this.compositionNameDataGridViewTextBoxColumn.MaxInputLength = 500;
            this.compositionNameDataGridViewTextBoxColumn.Name = "compositionNameDataGridViewTextBoxColumn";
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.DataSource = this.albumsBindingSource;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.albumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.albumDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.albumDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.albumDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.albumDataGridViewTextBoxColumn, "albumDataGridViewTextBoxColumn");
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.albumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.albumDataGridViewTextBoxColumn.ValueMember = "ID_Album";
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.AlbumsBS;
            // 
            // AlbumsBS
            // 
            this.AlbumsBS.DataSource = this.aISFonotekaTablesDataSet;
            this.AlbumsBS.Position = 0;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.DataSource = this.stylesBindingSource1;
            this.styleDataGridViewTextBoxColumn.DisplayMember = "style_Name";
            this.styleDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.styleDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.styleDataGridViewTextBoxColumn, "styleDataGridViewTextBoxColumn");
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.styleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.styleDataGridViewTextBoxColumn.ValueMember = "ID_Styles";
            // 
            // stylesBindingSource1
            // 
            this.stylesBindingSource1.DataMember = "Styles";
            this.stylesBindingSource1.DataSource = this.bSAIS;
            // 
            // timelapseDataGridViewTextBoxColumn
            // 
            this.timelapseDataGridViewTextBoxColumn.DataPropertyName = "Timelapse";
            this.timelapseDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.timelapseDataGridViewTextBoxColumn, "timelapseDataGridViewTextBoxColumn");
            this.timelapseDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.timelapseDataGridViewTextBoxColumn.Name = "timelapseDataGridViewTextBoxColumn";
            // 
            // creationYearDataGridViewTextBoxColumn
            // 
            this.creationYearDataGridViewTextBoxColumn.DataPropertyName = "CreationYear";
            this.creationYearDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.creationYearDataGridViewTextBoxColumn, "creationYearDataGridViewTextBoxColumn");
            this.creationYearDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.creationYearDataGridViewTextBoxColumn.Name = "creationYearDataGridViewTextBoxColumn";
            // 
            // cLanguageDataGridViewTextBoxColumn
            // 
            this.cLanguageDataGridViewTextBoxColumn.DataPropertyName = "CLanguage";
            this.cLanguageDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.cLanguageDataGridViewTextBoxColumn, "cLanguageDataGridViewTextBoxColumn");
            this.cLanguageDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.cLanguageDataGridViewTextBoxColumn.Name = "cLanguageDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.countryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.countryDataGridViewTextBoxColumn.Frozen = true;
            resources.ApplyResources(this.countryDataGridViewTextBoxColumn, "countryDataGridViewTextBoxColumn");
            this.countryDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // cMSOpenAlbum
            // 
            this.cMSOpenAlbum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.cMSOpenAlbum, "cMSOpenAlbum");
            this.cMSOpenAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIOpenAlbumForm,
            this.tSMIAddComposition,
            this.tSMIUpdate,
            this.tSMIDeleteComposition});
            this.cMSOpenAlbum.Name = "cMSOpenAlbum";
            this.cMSOpenAlbum.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMSOpenAlbum.Opening += new System.ComponentModel.CancelEventHandler(this.cMSOpenAlbum_Opening);
            // 
            // tSMIOpenAlbumForm
            // 
            this.tSMIOpenAlbumForm.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.tSMIOpenAlbumForm, "tSMIOpenAlbumForm");
            this.tSMIOpenAlbumForm.ForeColor = System.Drawing.Color.White;
            this.tSMIOpenAlbumForm.Name = "tSMIOpenAlbumForm";
            this.tSMIOpenAlbumForm.Click += new System.EventHandler(this.tSMIOpenAlbumForm_Click);
            // 
            // tSMIAddComposition
            // 
            resources.ApplyResources(this.tSMIAddComposition, "tSMIAddComposition");
            this.tSMIAddComposition.ForeColor = System.Drawing.Color.White;
            this.tSMIAddComposition.Name = "tSMIAddComposition";
            this.tSMIAddComposition.Click += new System.EventHandler(this.tSMIAddComposition_Click);
            // 
            // tSMIUpdate
            // 
            resources.ApplyResources(this.tSMIUpdate, "tSMIUpdate");
            this.tSMIUpdate.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdate.Name = "tSMIUpdate";
            this.tSMIUpdate.Click += new System.EventHandler(this.tSMIUpdate_Click);
            // 
            // tSMIDeleteComposition
            // 
            resources.ApplyResources(this.tSMIDeleteComposition, "tSMIDeleteComposition");
            this.tSMIDeleteComposition.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteComposition.Name = "tSMIDeleteComposition";
            this.tSMIDeleteComposition.Click += new System.EventHandler(this.tSMIDeleteComposition_Click);
            // 
            // compositionsBindingSource
            // 
            this.compositionsBindingSource.DataMember = "FK_Artist";
            this.compositionsBindingSource.DataSource = this.artistsBindingSource;
            // 
            // stylesBindingSource
            // 
            this.stylesBindingSource.DataMember = "Styles";
            this.stylesBindingSource.DataSource = this.bSAIS;
            // 
            // studiosBindingSource
            // 
            this.studiosBindingSource.DataMember = "Studios";
            this.studiosBindingSource.DataSource = this.bSAIS;
            // 
            // recordTypeBindingSource
            // 
            this.recordTypeBindingSource.DataMember = "RecordType";
            this.recordTypeBindingSource.DataSource = this.bSAIS;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // stylesTableAdapter
            // 
            this.stylesTableAdapter.ClearBeforeFill = true;
            // 
            // recordTypeTableAdapter
            // 
            this.recordTypeTableAdapter.ClearBeforeFill = true;
            // 
            // studiosTableAdapter
            // 
            this.studiosTableAdapter.ClearBeforeFill = true;
            // 
            // compositionsTableAdapter
            // 
            this.compositionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = this.albumsTableAdapter;
            this.tableAdapterManager.ArtistsTableAdapter = this.artistsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompositionsTableAdapter = null;
            this.tableAdapterManager.LogJournalTableAdapter = null;
            this.tableAdapterManager.RecordTypeTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.StylesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ArtistCompositionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.dGV_Compositions);
            this.Controls.Add(this.dGV_Artist);
            this.HelpButton = true;
            this.Name = "ArtistCompositionsForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Artist)).EndInit();
            this.cMSArtist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSAIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Compositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource1)).EndInit();
            this.cMSOpenAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Artist;
        private System.Windows.Forms.BindingSource bSAIS;
        private AISFonotekaTablesDataSet aISFonotekaTablesDataSet;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.BindingSource compositionsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource AlbumsBS;
        private System.Windows.Forms.BindingSource stylesBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter stylesTableAdapter;
        private System.Windows.Forms.BindingSource recordTypeBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter recordTypeTableAdapter;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter studiosTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.BindingSource stylesBindingSource1;
        private System.Windows.Forms.ContextMenuStrip cMSOpenAlbum;
        public System.Windows.Forms.ToolStripMenuItem tSMIOpenAlbumForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDArtistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDGViewTBColumn;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddComposition;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdate;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteComposition;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip cMSArtist;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddArtist;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdateArtist;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCompositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelapseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dGV_Compositions;
        public AISFonotekaTablesDataSetTableAdapters.CompositionsTableAdapter compositionsTableAdapter;
    }
}

