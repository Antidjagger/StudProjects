using System.Drawing;

namespace AISFonotekaFrameWork
{
    partial class AboutAlbumForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutAlbumForm));
            this.dGV_Album = new System.Windows.Forms.DataGridView();
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
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.AlbumsTableAdapter();
            this.stylesTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StylesTableAdapter();
            this.studiosTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter();
            this.recordTypeTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.RecordTypeTableAdapter();
            this.stylesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            this.cMSAlbum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIUpdateAlbum = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource1)).BeginInit();
            this.cMSAlbum.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Album
            // 
            this.dGV_Album.AllowUserToAddRows = false;
            this.dGV_Album.AllowUserToDeleteRows = false;
            this.dGV_Album.AutoGenerateColumns = false;
            this.dGV_Album.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Album.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGV_Album.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Album.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Album.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlbumDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.timelapseDataGridViewTextBoxColumn,
            this.studioDataGridViewTextBoxColumn,
            this.recordTypeDataGridViewTextBoxColumn});
            this.dGV_Album.DataSource = this.albumsBindingSource;
            this.dGV_Album.GridColor = System.Drawing.Color.Maroon;
            this.dGV_Album.Location = new System.Drawing.Point(40, 52);
            this.dGV_Album.Name = "dGV_Album";
            this.dGV_Album.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGV_Album.RowHeadersVisible = false;
            this.dGV_Album.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dGV_Album.Size = new System.Drawing.Size(726, 126);
            this.dGV_Album.TabIndex = 0;
            this.dGV_Album.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Album_CellEndEdit);
            // 
            // iDAlbumDataGridViewTextBoxColumn
            // 
            this.iDAlbumDataGridViewTextBoxColumn.DataPropertyName = "ID_Album";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDAlbumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDAlbumDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDAlbumDataGridViewTextBoxColumn.Name = "iDAlbumDataGridViewTextBoxColumn";
            this.iDAlbumDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAlbumDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mistral", 14F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название альбома";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.DataSource = this.stylesBindingSource;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mistral", 14F);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.styleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.styleDataGridViewTextBoxColumn.DisplayMember = "style_Name";
            this.styleDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.styleDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.styleDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.styleDataGridViewTextBoxColumn.MaxDropDownItems = 1;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.styleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.styleDataGridViewTextBoxColumn.ValueMember = "ID_Styles";
            this.styleDataGridViewTextBoxColumn.Width = 80;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Mistral", 14F);
            this.countDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество композиций";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Mistral", 14F);
            this.yearDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.yearDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 90;
            // 
            // timelapseDataGridViewTextBoxColumn
            // 
            this.timelapseDataGridViewTextBoxColumn.DataPropertyName = "Timelapse";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Mistral", 14F);
            this.timelapseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.timelapseDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.timelapseDataGridViewTextBoxColumn.Name = "timelapseDataGridViewTextBoxColumn";
            this.timelapseDataGridViewTextBoxColumn.Width = 115;
            // 
            // studioDataGridViewTextBoxColumn
            // 
            this.studioDataGridViewTextBoxColumn.DataPropertyName = "Studio";
            this.studioDataGridViewTextBoxColumn.DataSource = this.studiosBindingSource;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Mistral", 14F);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.studioDataGridViewTextBoxColumn.DisplayMember = "Studio_Name";
            this.studioDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.studioDataGridViewTextBoxColumn.HeaderText = "Студия записи";
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Mistral", 14F);
            this.recordTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.recordTypeDataGridViewTextBoxColumn.DisplayMember = "RecordType_Name";
            this.recordTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.recordTypeDataGridViewTextBoxColumn.HeaderText = "Тип носителя";
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
            // stylesBindingSource1
            // 
            this.stylesBindingSource1.DataMember = "Styles";
            this.stylesBindingSource1.DataSource = this.aISFonotekaTablesDataSet;
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
            // cMSAlbum
            // 
            this.cMSAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cMSAlbum.BackgroundImage")));
            this.cMSAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cMSAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIUpdateAlbum});
            this.cMSAlbum.Name = "cMSAlbum";
            this.cMSAlbum.Size = new System.Drawing.Size(181, 48);
            // 
            // tSMIUpdateAlbum
            // 
            this.tSMIUpdateAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIUpdateAlbum.BackgroundImage")));
            this.tSMIUpdateAlbum.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIUpdateAlbum.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdateAlbum.Image = ((System.Drawing.Image)(resources.GetObject("tSMIUpdateAlbum.Image")));
            this.tSMIUpdateAlbum.Name = "tSMIUpdateAlbum";
            this.tSMIUpdateAlbum.Size = new System.Drawing.Size(180, 22);
            this.tSMIUpdateAlbum.Text = "Обновить";
            this.tSMIUpdateAlbum.Click += new System.EventHandler(this.tSMIUpdateAlbum_Click);
            // 
            // AboutAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 220);
            this.Controls.Add(this.dGV_Album);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutAlbumForm";
            this.ShowIcon = false;
            this.Text = "AboutAlbumForm";
            this.Load += new System.EventHandler(this.AboutAlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesBindingSource1)).EndInit();
            this.cMSAlbum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Album;
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
        private System.Windows.Forms.BindingSource stylesBindingSource1;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip cMSAlbum;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdateAlbum;
    }
}