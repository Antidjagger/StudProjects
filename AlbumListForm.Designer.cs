namespace AISFonotekaFrameWork
{
    partial class AlbumListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumListForm));
            this.dGV_Albums = new System.Windows.Forms.DataGridView();
            this.aISFonotekaTablesDataSet = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter();
            this.stylesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stylesTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter();
            this.recordTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordTypeTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter();
            this.iDAlbumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timelapseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cMSAlbums = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIOpenCompositionList = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Albums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).BeginInit();
            this.cMSAlbums.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Albums
            // 
            this.dGV_Albums.AllowUserToAddRows = false;
            this.dGV_Albums.AllowUserToDeleteRows = false;
            this.dGV_Albums.AutoGenerateColumns = false;
            this.dGV_Albums.BackgroundColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Albums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Albums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlbumDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.timelapseDataGridViewTextBoxColumn,
            this.recordTypeDataGridViewTextBoxColumn});
            this.dGV_Albums.ContextMenuStrip = this.cMSAlbums;
            this.dGV_Albums.DataSource = this.albumsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Albums.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Albums.Location = new System.Drawing.Point(23, 37);
            this.dGV_Albums.Name = "dGV_Albums";
            this.dGV_Albums.RowHeadersVisible = false;
            this.dGV_Albums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Albums.Size = new System.Drawing.Size(654, 376);
            this.dGV_Albums.TabIndex = 1;
            this.dGV_Albums.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Albums_CellEndEdit);
            // 
            // aISFonotekaTablesDataSet
            // 
            this.aISFonotekaTablesDataSet.DataSetName = "AISFonotekaTablesDataSet";
            this.aISFonotekaTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // stylesBindingSource
            // 
            this.stylesBindingSource.DataMember = "Styles";
            this.stylesBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // stylesTableAdapter
            // 
            this.stylesTableAdapter.ClearBeforeFill = true;
            // 
            // recordTypeBindingSource
            // 
            this.recordTypeBindingSource.DataMember = "RecordType";
            this.recordTypeBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // recordTypeTableAdapter
            // 
            this.recordTypeTableAdapter.ClearBeforeFill = true;
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
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 200;
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
            // recordTypeDataGridViewTextBoxColumn
            // 
            this.recordTypeDataGridViewTextBoxColumn.DataPropertyName = "RecordType";
            this.recordTypeDataGridViewTextBoxColumn.DataSource = this.recordTypeBindingSource;
            this.recordTypeDataGridViewTextBoxColumn.DisplayMember = "RecordType_Name";
            this.recordTypeDataGridViewTextBoxColumn.HeaderText = "Вид носителя";
            this.recordTypeDataGridViewTextBoxColumn.Name = "recordTypeDataGridViewTextBoxColumn";
            this.recordTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recordTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.recordTypeDataGridViewTextBoxColumn.ValueMember = "ID_RecordType";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = this.albumsTableAdapter;
            this.tableAdapterManager.ArtistsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompositionsTableAdapter = null;
            this.tableAdapterManager.LogJournalTableAdapter = null;
            this.tableAdapterManager.RecordTypeTableAdapter = this.recordTypeTableAdapter;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.StylesTableAdapter = this.stylesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AlbumListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.dGV_Albums);
            this.Name = "AlbumListForm";
            this.ShowIcon = false;
            this.Text = "Список альбомов";
            this.Load += new System.EventHandler(this.AlbumListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Albums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).EndInit();
            this.cMSAlbums.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Albums;
        private AISFonotekaTablesDataSet aISFonotekaTablesDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource stylesBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter stylesTableAdapter;
        private System.Windows.Forms.BindingSource recordTypeBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter recordTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlbumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelapseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn recordTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cMSAlbums;
        private System.Windows.Forms.ToolStripMenuItem tSMIOpenCompositionList;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddAlbum;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteAlbum;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdate;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}