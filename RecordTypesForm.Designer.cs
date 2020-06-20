namespace AISFonotekaFrameWork
{
    partial class RecordTypesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordTypesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_RecordTypes = new System.Windows.Forms.DataGridView();
            this.iDRecordTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSRecordTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIAddRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdateRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.recordTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aISFonotekaTablesDataSet = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            this.recordTypeTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter();
            this.dGV_Albums = new System.Windows.Forms.DataGridView();
            this.iDAlbumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stylesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timelapseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSAlbums = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIOpenCompositionList = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.fKAlbumsRecordTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter();
            this.studiosTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter();
            this.stylesTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter();
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RecordTypes)).BeginInit();
            this.cMSRecordTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Albums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            this.cMSAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAlbumsRecordTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_RecordTypes
            // 
            this.dGV_RecordTypes.AllowUserToAddRows = false;
            this.dGV_RecordTypes.AllowUserToDeleteRows = false;
            this.dGV_RecordTypes.AutoGenerateColumns = false;
            this.dGV_RecordTypes.BackgroundColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_RecordTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_RecordTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_RecordTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRecordTypeDataGridViewTextBoxColumn,
            this.recordTypeNameDataGridViewTextBoxColumn});
            this.dGV_RecordTypes.ContextMenuStrip = this.cMSRecordTypes;
            this.dGV_RecordTypes.DataSource = this.recordTypeBindingSource;
            this.dGV_RecordTypes.Location = new System.Drawing.Point(23, 37);
            this.dGV_RecordTypes.Name = "dGV_RecordTypes";
            this.dGV_RecordTypes.RowHeadersVisible = false;
            this.dGV_RecordTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_RecordTypes.Size = new System.Drawing.Size(147, 376);
            this.dGV_RecordTypes.TabIndex = 1;
            this.dGV_RecordTypes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_RecordTypes_CellEndEdit);
            // 
            // iDRecordTypeDataGridViewTextBoxColumn
            // 
            this.iDRecordTypeDataGridViewTextBoxColumn.DataPropertyName = "ID_RecordType";
            this.iDRecordTypeDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDRecordTypeDataGridViewTextBoxColumn.Name = "iDRecordTypeDataGridViewTextBoxColumn";
            this.iDRecordTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRecordTypeDataGridViewTextBoxColumn.Width = 40;
            // 
            // recordTypeNameDataGridViewTextBoxColumn
            // 
            this.recordTypeNameDataGridViewTextBoxColumn.DataPropertyName = "RecordType_Name";
            this.recordTypeNameDataGridViewTextBoxColumn.HeaderText = "Вид носителя";
            this.recordTypeNameDataGridViewTextBoxColumn.Name = "recordTypeNameDataGridViewTextBoxColumn";
            // 
            // cMSRecordTypes
            // 
            this.cMSRecordTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIAddRecord,
            this.tSMIDeleteRecord,
            this.tSMIUpdateRecord});
            this.cMSRecordTypes.Name = "cMSAlbums";
            this.cMSRecordTypes.Size = new System.Drawing.Size(225, 92);
            // 
            // tSMIAddRecord
            // 
            this.tSMIAddRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIAddRecord.BackgroundImage")));
            this.tSMIAddRecord.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIAddRecord.ForeColor = System.Drawing.Color.White;
            this.tSMIAddRecord.Image = ((System.Drawing.Image)(resources.GetObject("tSMIAddRecord.Image")));
            this.tSMIAddRecord.Name = "tSMIAddRecord";
            this.tSMIAddRecord.Size = new System.Drawing.Size(224, 22);
            this.tSMIAddRecord.Text = "Добавить носитель";
            this.tSMIAddRecord.Click += new System.EventHandler(this.tSMIAddRecord_Click);
            // 
            // tSMIDeleteRecord
            // 
            this.tSMIDeleteRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteRecord.BackgroundImage")));
            this.tSMIDeleteRecord.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIDeleteRecord.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteRecord.Image")));
            this.tSMIDeleteRecord.Name = "tSMIDeleteRecord";
            this.tSMIDeleteRecord.Size = new System.Drawing.Size(224, 22);
            this.tSMIDeleteRecord.Text = "Удалить носитель";
            this.tSMIDeleteRecord.Click += new System.EventHandler(this.tSMIDeleteRecord_Click);
            // 
            // tSMIUpdateRecord
            // 
            this.tSMIUpdateRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIUpdateRecord.BackgroundImage")));
            this.tSMIUpdateRecord.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIUpdateRecord.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdateRecord.Image = ((System.Drawing.Image)(resources.GetObject("tSMIUpdateRecord.Image")));
            this.tSMIUpdateRecord.Name = "tSMIUpdateRecord";
            this.tSMIUpdateRecord.Size = new System.Drawing.Size(224, 22);
            this.tSMIUpdateRecord.Text = "Обновить";
            this.tSMIUpdateRecord.Click += new System.EventHandler(this.tSMIUpdateRecord_Click);
            // 
            // recordTypeBindingSource
            // 
            this.recordTypeBindingSource.DataMember = "RecordType";
            this.recordTypeBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // aISFonotekaTablesDataSet
            // 
            this.aISFonotekaTablesDataSet.DataSetName = "AISFonotekaTablesDataSet";
            this.aISFonotekaTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordTypeTableAdapter
            // 
            this.recordTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dGV_Albums
            // 
            this.dGV_Albums.AllowUserToAddRows = false;
            this.dGV_Albums.AllowUserToDeleteRows = false;
            this.dGV_Albums.AutoGenerateColumns = false;
            this.dGV_Albums.BackgroundColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Albums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Albums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlbumDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.timelapseDataGridViewTextBoxColumn,
            this.studioDataGridViewTextBoxColumn});
            this.dGV_Albums.ContextMenuStrip = this.cMSAlbums;
            this.dGV_Albums.DataSource = this.fKAlbumsRecordTypeBindingSource;
            this.dGV_Albums.Location = new System.Drawing.Point(228, 37);
            this.dGV_Albums.Name = "dGV_Albums";
            this.dGV_Albums.RowHeadersVisible = false;
            this.dGV_Albums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Albums.Size = new System.Drawing.Size(653, 376);
            this.dGV_Albums.TabIndex = 2;
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
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество композиций";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Год создания";
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
            // fKAlbumsRecordTypeBindingSource
            // 
            this.fKAlbumsRecordTypeBindingSource.DataMember = "FK_Albums_RecordType";
            this.fKAlbumsRecordTypeBindingSource.DataSource = this.recordTypeBindingSource;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // studiosTableAdapter
            // 
            this.studiosTableAdapter.ClearBeforeFill = true;
            // 
            // stylesTableAdapter
            // 
            this.stylesTableAdapter.ClearBeforeFill = true;
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
            // RecordTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.backMenu2;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.dGV_Albums);
            this.Controls.Add(this.dGV_RecordTypes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordTypesForm";
            this.Text = "RecordTypesForm";
            this.Load += new System.EventHandler(this.RecordTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RecordTypes)).EndInit();
            this.cMSRecordTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Albums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            this.cMSAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKAlbumsRecordTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_RecordTypes;
        private AISFonotekaTablesDataSet aISFonotekaTablesDataSet;
        private System.Windows.Forms.BindingSource recordTypeBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter recordTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRecordTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dGV_Albums;
        private System.Windows.Forms.BindingSource fKAlbumsRecordTypeBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter studiosTableAdapter;
        private System.Windows.Forms.BindingSource stylesBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter stylesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlbumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelapseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studioDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cMSAlbums;
        private System.Windows.Forms.ToolStripMenuItem tSMIOpenCompositionList;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddAlbum;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteAlbum;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdate;
        private System.Windows.Forms.ContextMenuStrip cMSRecordTypes;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddRecord;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteRecord;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdateRecord;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}