namespace AISFonotekaFrameWork
{
    partial class AlbumsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumsForm));
            this.dGV_Albums = new System.Windows.Forms.DataGridView();
            this.iDAlbumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stylesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aISFonotekaTablesDataSet = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timelapseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.recordTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSAlbums = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIOpenCompositionList = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter();
            this.stylesTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter();
            this.studiosTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter();
            this.recordTypeTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter();
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Albums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).BeginInit();
            this.cMSAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Albums
            // 
            this.dGV_Albums.AllowUserToAddRows = false;
            this.dGV_Albums.AllowUserToDeleteRows = false;
            this.dGV_Albums.AutoGenerateColumns = false;
            this.dGV_Albums.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dGV_Albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Albums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlbumDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.timelapseDataGridViewTextBoxColumn,
            this.studioDataGridViewTextBoxColumn,
            this.recordTypeDataGridViewTextBoxColumn});
            this.dGV_Albums.ContextMenuStrip = this.cMSAlbums;
            this.dGV_Albums.DataSource = this.albumsBindingSource;
            this.dGV_Albums.Location = new System.Drawing.Point(12, 39);
            this.dGV_Albums.Name = "dGV_Albums";
            this.dGV_Albums.RowHeadersVisible = false;
            this.dGV_Albums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Albums.Size = new System.Drawing.Size(755, 376);
            this.dGV_Albums.TabIndex = 0;
            this.dGV_Albums.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Albums_CellEndEdit);
            // 
            // iDAlbumDataGridViewTextBoxColumn
            // 
            this.iDAlbumDataGridViewTextBoxColumn.DataPropertyName = "ID_Album";
            this.iDAlbumDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDAlbumDataGridViewTextBoxColumn.Name = "iDAlbumDataGridViewTextBoxColumn";
            this.iDAlbumDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAlbumDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название альбома";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество композиций";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // timelapseDataGridViewTextBoxColumn
            // 
            this.timelapseDataGridViewTextBoxColumn.DataPropertyName = "Timelapse";
            this.timelapseDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.timelapseDataGridViewTextBoxColumn.Name = "timelapseDataGridViewTextBoxColumn";
            this.timelapseDataGridViewTextBoxColumn.Width = 110;
            // 
            // studioDataGridViewTextBoxColumn
            // 
            this.studioDataGridViewTextBoxColumn.DataPropertyName = "Studio";
            this.studioDataGridViewTextBoxColumn.DataSource = this.studiosBindingSource;
            this.studioDataGridViewTextBoxColumn.DisplayMember = "Studio_Name";
            this.studioDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.studioDataGridViewTextBoxColumn.HeaderText = "Студия";
            this.studioDataGridViewTextBoxColumn.Name = "studioDataGridViewTextBoxColumn";
            this.studioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studioDataGridViewTextBoxColumn.ValueMember = "ID_Studio";
            // 
            // studiosBindingSource
            // 
            this.studiosBindingSource.DataMember = "Studios";
            this.studiosBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // recordTypeDataGridViewTextBoxColumn
            // 
            this.recordTypeDataGridViewTextBoxColumn.DataPropertyName = "RecordType";
            this.recordTypeDataGridViewTextBoxColumn.DataSource = this.recordTypeBindingSource;
            this.recordTypeDataGridViewTextBoxColumn.DisplayMember = "RecordType_Name";
            this.recordTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.recordTypeDataGridViewTextBoxColumn.HeaderText = "Вид носителя";
            this.recordTypeDataGridViewTextBoxColumn.Name = "recordTypeDataGridViewTextBoxColumn";
            this.recordTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recordTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.recordTypeDataGridViewTextBoxColumn.ValueMember = "ID_RecordType";
            // 
            // recordTypeBindingSource
            // 
            this.recordTypeBindingSource.DataMember = "RecordType";
            this.recordTypeBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // cMSAlbums
            // 
            this.cMSAlbums.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIOpenCompositionList,
            this.tSMIAddAlbum,
            this.tSMIDeleteAlbum,
            this.tSMIUpdate});
            this.cMSAlbums.Name = "cMSAlbums";
            this.cMSAlbums.Size = new System.Drawing.Size(335, 92);
            // 
            // tSMIOpenCompositionList
            // 
            this.tSMIOpenCompositionList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIOpenCompositionList.BackgroundImage")));
            this.tSMIOpenCompositionList.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIOpenCompositionList.ForeColor = System.Drawing.Color.White;
            this.tSMIOpenCompositionList.Name = "tSMIOpenCompositionList";
            this.tSMIOpenCompositionList.Size = new System.Drawing.Size(334, 22);
            this.tSMIOpenCompositionList.Text = "Просмотреть список композиций";
            this.tSMIOpenCompositionList.Click += new System.EventHandler(this.tSMIOpenCompositionList_Click);
            // 
            // tSMIAddAlbum
            // 
            this.tSMIAddAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIAddAlbum.BackgroundImage")));
            this.tSMIAddAlbum.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIAddAlbum.ForeColor = System.Drawing.Color.White;
            this.tSMIAddAlbum.Image = ((System.Drawing.Image)(resources.GetObject("tSMIAddAlbum.Image")));
            this.tSMIAddAlbum.Name = "tSMIAddAlbum";
            this.tSMIAddAlbum.Size = new System.Drawing.Size(334, 22);
            this.tSMIAddAlbum.Text = "Добавить альбом";
            this.tSMIAddAlbum.Click += new System.EventHandler(this.tSMIAddAlbum_Click);
            // 
            // tSMIDeleteAlbum
            // 
            this.tSMIDeleteAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteAlbum.BackgroundImage")));
            this.tSMIDeleteAlbum.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIDeleteAlbum.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteAlbum.Image = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteAlbum.Image")));
            this.tSMIDeleteAlbum.Name = "tSMIDeleteAlbum";
            this.tSMIDeleteAlbum.Size = new System.Drawing.Size(334, 22);
            this.tSMIDeleteAlbum.Text = "Удалить альбом";
            this.tSMIDeleteAlbum.Click += new System.EventHandler(this.tSMIDeleteAlbum_Click);
            // 
            // tSMIUpdate
            // 
            this.tSMIUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.BackgroundImage")));
            this.tSMIUpdate.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIUpdate.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.Image")));
            this.tSMIUpdate.Name = "tSMIUpdate";
            this.tSMIUpdate.Size = new System.Drawing.Size(334, 22);
            this.tSMIUpdate.Text = "Обновить";
            this.tSMIUpdate.Click += new System.EventHandler(this.tSMIUpdate_Click);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // stylesTableAdapter
            // 
            this.stylesTableAdapter.ClearBeforeFill = true;
            // 
            // studiosTableAdapter
            // 
            this.studiosTableAdapter.ClearBeforeFill = true;
            // 
            // recordTypeTableAdapter
            // 
            this.recordTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = this.albumsTableAdapter;
            this.tableAdapterManager.ArtistsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompositionsTableAdapter = null;
            this.tableAdapterManager.LogJournalTableAdapter = null;
            this.tableAdapterManager.RecordTypeTableAdapter = this.recordTypeTableAdapter;
            this.tableAdapterManager.StudiosTableAdapter = this.studiosTableAdapter;
            this.tableAdapterManager.StylesTableAdapter = this.stylesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.dGV_Albums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlbumsForm";
            this.Text = "Альбомы";
            this.Load += new System.EventHandler(this.AlbumsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Albums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).EndInit();
            this.cMSAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Albums;
        private AISFonotekaTablesDataSet aISFonotekaTablesDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource stylesBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter stylesTableAdapter;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter studiosTableAdapter;
        private System.Windows.Forms.BindingSource recordTypeBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter recordTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlbumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelapseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn recordTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cMSAlbums;
        private System.Windows.Forms.ToolStripMenuItem tSMIOpenCompositionList;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddAlbum;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteAlbum;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdate;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}