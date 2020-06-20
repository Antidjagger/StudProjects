namespace AISFonotekaFrameWork.Forms
{
    partial class AboutCompositionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutCompositionsForm));
            this.dGV_Compositions = new System.Windows.Forms.DataGridView();
            this.iDCompositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aISFonotekaTablesDataSet = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stylesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timelapseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSCompositions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIOpenAlbumForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddComposition = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteComposition = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.compositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.CompositionsTableAdapter();
            this.artistsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.ArtistsTableAdapter();
            this.albumsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter();
            this.stylesTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter();
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Compositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).BeginInit();
            this.cMSCompositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Compositions
            // 
            this.dGV_Compositions.AutoGenerateColumns = false;
            this.dGV_Compositions.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dGV_Compositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Compositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCompositionDataGridViewTextBoxColumn,
            this.compositionNameDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.timelapseDataGridViewTextBoxColumn,
            this.creationYearDataGridViewTextBoxColumn,
            this.cLanguageDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dGV_Compositions.ContextMenuStrip = this.cMSCompositions;
            this.dGV_Compositions.DataSource = this.compositionsBindingSource;
            this.dGV_Compositions.Location = new System.Drawing.Point(12, 35);
            this.dGV_Compositions.Name = "dGV_Compositions";
            this.dGV_Compositions.RowHeadersVisible = false;
            this.dGV_Compositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Compositions.Size = new System.Drawing.Size(844, 340);
            this.dGV_Compositions.TabIndex = 0;
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
            // aISFonotekaTablesDataSet
            // 
            this.aISFonotekaTablesDataSet.DataSetName = "AISFonotekaTablesDataSet";
            this.aISFonotekaTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.DataSource = this.stylesBindingSource;
            this.styleDataGridViewTextBoxColumn.DisplayMember = "style_Name";
            this.styleDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.styleDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.styleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.styleDataGridViewTextBoxColumn.ValueMember = "ID_Styles";
            this.styleDataGridViewTextBoxColumn.Width = 90;
            // 
            // stylesBindingSource
            // 
            this.stylesBindingSource.DataMember = "Styles";
            this.stylesBindingSource.DataSource = this.aISFonotekaTablesDataSet;
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
            this.creationYearDataGridViewTextBoxColumn.Name = "creationYearDataGridViewTextBoxColumn";
            // 
            // cLanguageDataGridViewTextBoxColumn
            // 
            this.cLanguageDataGridViewTextBoxColumn.DataPropertyName = "CLanguage";
            this.cLanguageDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.cLanguageDataGridViewTextBoxColumn.Name = "cLanguageDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // cMSCompositions
            // 
            this.cMSCompositions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIOpenAlbumForm,
            this.tSMIAddComposition,
            this.tSMIDeleteComposition,
            this.tSMIUpdate});
            this.cMSCompositions.Name = "cMSCompositions";
            this.cMSCompositions.Size = new System.Drawing.Size(374, 92);
            // 
            // tSMIOpenAlbumForm
            // 
            this.tSMIOpenAlbumForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIOpenAlbumForm.BackgroundImage")));
            this.tSMIOpenAlbumForm.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIOpenAlbumForm.ForeColor = System.Drawing.Color.White;
            this.tSMIOpenAlbumForm.Image = ((System.Drawing.Image)(resources.GetObject("tSMIOpenAlbumForm.Image")));
            this.tSMIOpenAlbumForm.Name = "tSMIOpenAlbumForm";
            this.tSMIOpenAlbumForm.Size = new System.Drawing.Size(373, 22);
            this.tSMIOpenAlbumForm.Text = "Просмотреть информацию об альбоме";
            this.tSMIOpenAlbumForm.Click += new System.EventHandler(this.tSMIOpenAlbumForm_Click);
            // 
            // tSMIAddComposition
            // 
            this.tSMIAddComposition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIAddComposition.BackgroundImage")));
            this.tSMIAddComposition.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIAddComposition.ForeColor = System.Drawing.Color.White;
            this.tSMIAddComposition.Image = ((System.Drawing.Image)(resources.GetObject("tSMIAddComposition.Image")));
            this.tSMIAddComposition.Name = "tSMIAddComposition";
            this.tSMIAddComposition.Size = new System.Drawing.Size(373, 22);
            this.tSMIAddComposition.Text = "Добавить композицию...";
            this.tSMIAddComposition.Click += new System.EventHandler(this.tSMIAddComposition_Click);
            // 
            // tSMIDeleteComposition
            // 
            this.tSMIDeleteComposition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteComposition.BackgroundImage")));
            this.tSMIDeleteComposition.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIDeleteComposition.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteComposition.Image = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteComposition.Image")));
            this.tSMIDeleteComposition.Name = "tSMIDeleteComposition";
            this.tSMIDeleteComposition.Size = new System.Drawing.Size(373, 22);
            this.tSMIDeleteComposition.Text = "Удалить композицию";
            this.tSMIDeleteComposition.Click += new System.EventHandler(this.tSMIDeleteComposition_Click);
            // 
            // tSMIUpdate
            // 
            this.tSMIUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.BackgroundImage")));
            this.tSMIUpdate.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIUpdate.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.Image")));
            this.tSMIUpdate.Name = "tSMIUpdate";
            this.tSMIUpdate.Size = new System.Drawing.Size(373, 22);
            this.tSMIUpdate.Text = "Обновить";
            this.tSMIUpdate.Click += new System.EventHandler(this.tSMIUpdate_Click);
            // 
            // compositionsBindingSource
            // 
            this.compositionsBindingSource.DataMember = "Compositions";
            this.compositionsBindingSource.DataSource = this.aISFonotekaTablesDataSet;
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
            // stylesTableAdapter
            // 
            this.stylesTableAdapter.ClearBeforeFill = true;
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
            // CompositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.dGV_Compositions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompositionsForm";
            this.Text = "Композиции";
            this.Load += new System.EventHandler(this.CompositionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Compositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).EndInit();
            this.cMSCompositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Compositions;
        private AISFonotekaTablesDataSet aISFonotekaTablesDataSet;
        private System.Windows.Forms.BindingSource compositionsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.CompositionsTableAdapter compositionsTableAdapter;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource stylesBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter stylesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCompositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelapseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cMSCompositions;
        private System.Windows.Forms.ToolStripMenuItem tSMIOpenAlbumForm;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddComposition;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteComposition;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdate;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}