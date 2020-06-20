namespace AISFonotekaFrameWork
{
    partial class StudiosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudiosForm));
            this.dGV_Studios = new System.Windows.Forms.DataGridView();
            this.iDStudioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aISFonotekaTablesDataSet = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            this.studiosTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter();
            this.cMSStudios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIOpenAlbumList = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddStudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDeleteStudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterManager = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Studios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).BeginInit();
            this.cMSStudios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Studios
            // 
            this.dGV_Studios.AutoGenerateColumns = false;
            this.dGV_Studios.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dGV_Studios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Studios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDStudioDataGridViewTextBoxColumn,
            this.studioNameDataGridViewTextBoxColumn,
            this.creationYearDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.studioAdressDataGridViewTextBoxColumn,
            this.studioURLDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn});
            this.dGV_Studios.ContextMenuStrip = this.cMSStudios;
            this.dGV_Studios.DataSource = this.studiosBindingSource;
            this.dGV_Studios.Location = new System.Drawing.Point(23, 56);
            this.dGV_Studios.Name = "dGV_Studios";
            this.dGV_Studios.RowHeadersVisible = false;
            this.dGV_Studios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Studios.Size = new System.Drawing.Size(748, 340);
            this.dGV_Studios.TabIndex = 1;
            this.dGV_Studios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Studios_CellEndEdit);
            // 
            // iDStudioDataGridViewTextBoxColumn
            // 
            this.iDStudioDataGridViewTextBoxColumn.DataPropertyName = "ID_Studio";
            this.iDStudioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDStudioDataGridViewTextBoxColumn.Name = "iDStudioDataGridViewTextBoxColumn";
            this.iDStudioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDStudioDataGridViewTextBoxColumn.Width = 40;
            // 
            // studioNameDataGridViewTextBoxColumn
            // 
            this.studioNameDataGridViewTextBoxColumn.DataPropertyName = "Studio_Name";
            this.studioNameDataGridViewTextBoxColumn.HeaderText = "Название студии";
            this.studioNameDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.studioNameDataGridViewTextBoxColumn.Name = "studioNameDataGridViewTextBoxColumn";
            // 
            // creationYearDataGridViewTextBoxColumn
            // 
            this.creationYearDataGridViewTextBoxColumn.DataPropertyName = "CreationYear";
            this.creationYearDataGridViewTextBoxColumn.HeaderText = "Год создания";
            this.creationYearDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.creationYearDataGridViewTextBoxColumn.Name = "creationYearDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // studioAdressDataGridViewTextBoxColumn
            // 
            this.studioAdressDataGridViewTextBoxColumn.DataPropertyName = "Studio_Adress";
            this.studioAdressDataGridViewTextBoxColumn.HeaderText = "Адрес студии";
            this.studioAdressDataGridViewTextBoxColumn.MaxInputLength = 1000;
            this.studioAdressDataGridViewTextBoxColumn.Name = "studioAdressDataGridViewTextBoxColumn";
            // 
            // studioURLDataGridViewTextBoxColumn
            // 
            this.studioURLDataGridViewTextBoxColumn.DataPropertyName = "Studio_URL";
            this.studioURLDataGridViewTextBoxColumn.HeaderText = "Сайт студии";
            this.studioURLDataGridViewTextBoxColumn.Name = "studioURLDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            this.openDataGridViewTextBoxColumn.FalseValue = "0";
            this.openDataGridViewTextBoxColumn.HeaderText = "Работает?";
            this.openDataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.openDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.openDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // studiosBindingSource
            // 
            this.studiosBindingSource.DataMember = "Studios";
            this.studiosBindingSource.DataSource = this.aISFonotekaTablesDataSet;
            // 
            // aISFonotekaTablesDataSet
            // 
            this.aISFonotekaTablesDataSet.DataSetName = "AISFonotekaTablesDataSet";
            this.aISFonotekaTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studiosTableAdapter
            // 
            this.studiosTableAdapter.ClearBeforeFill = true;
            // 
            // cMSStudios
            // 
            this.cMSStudios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIOpenAlbumList,
            this.tSMIAddStudio,
            this.tSMIDeleteStudio,
            this.tSMIUpdate});
            this.cMSStudios.Name = "cMSCompositions";
            this.cMSStudios.Size = new System.Drawing.Size(373, 92);
            // 
            // tSMIOpenAlbumList
            // 
            this.tSMIOpenAlbumList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIOpenAlbumList.BackgroundImage")));
            this.tSMIOpenAlbumList.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIOpenAlbumList.ForeColor = System.Drawing.Color.White;
            this.tSMIOpenAlbumList.Image = ((System.Drawing.Image)(resources.GetObject("tSMIOpenAlbumList.Image")));
            this.tSMIOpenAlbumList.Name = "tSMIOpenAlbumList";
            this.tSMIOpenAlbumList.Size = new System.Drawing.Size(372, 22);
            this.tSMIOpenAlbumList.Text = "Просмотреть список альбомов студии";
            this.tSMIOpenAlbumList.Click += new System.EventHandler(this.tSMIOpenAlbumList_Click);
            // 
            // tSMIAddStudio
            // 
            this.tSMIAddStudio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIAddStudio.BackgroundImage")));
            this.tSMIAddStudio.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIAddStudio.ForeColor = System.Drawing.Color.White;
            this.tSMIAddStudio.Image = ((System.Drawing.Image)(resources.GetObject("tSMIAddStudio.Image")));
            this.tSMIAddStudio.Name = "tSMIAddStudio";
            this.tSMIAddStudio.Size = new System.Drawing.Size(372, 22);
            this.tSMIAddStudio.Text = "Добавить студию...";
            this.tSMIAddStudio.Click += new System.EventHandler(this.tSMIAddStudio_Click);
            // 
            // tSMIDeleteStudio
            // 
            this.tSMIDeleteStudio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteStudio.BackgroundImage")));
            this.tSMIDeleteStudio.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIDeleteStudio.ForeColor = System.Drawing.Color.White;
            this.tSMIDeleteStudio.Image = ((System.Drawing.Image)(resources.GetObject("tSMIDeleteStudio.Image")));
            this.tSMIDeleteStudio.Name = "tSMIDeleteStudio";
            this.tSMIDeleteStudio.Size = new System.Drawing.Size(372, 22);
            this.tSMIDeleteStudio.Text = "Удалить студию";
            this.tSMIDeleteStudio.Click += new System.EventHandler(this.tSMIDeleteStudio_Click);
            // 
            // tSMIUpdate
            // 
            this.tSMIUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.BackgroundImage")));
            this.tSMIUpdate.Font = new System.Drawing.Font("a_OldTyperNr", 11.25F, System.Drawing.FontStyle.Bold);
            this.tSMIUpdate.ForeColor = System.Drawing.Color.White;
            this.tSMIUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tSMIUpdate.Image")));
            this.tSMIUpdate.Name = "tSMIUpdate";
            this.tSMIUpdate.Size = new System.Drawing.Size(372, 22);
            this.tSMIUpdate.Text = "Обновить";
            this.tSMIUpdate.Click += new System.EventHandler(this.tSMIUpdate_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = null;
            this.tableAdapterManager.ArtistsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompositionsTableAdapter = null;
            this.tableAdapterManager.LogJournalTableAdapter = null;
            this.tableAdapterManager.RecordTypeTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = this.studiosTableAdapter;
            this.tableAdapterManager.StylesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StudiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.dGV_Studios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudiosForm";
            this.Text = "StudiosForm";
            this.Load += new System.EventHandler(this.StudiosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Studios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aISFonotekaTablesDataSet)).EndInit();
            this.cMSStudios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Studios;
        private AISFonotekaTablesDataSet aISFonotekaTablesDataSet;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private AISFonotekaTablesDataSetTableAdapters.StudiosTableAdapter studiosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStudioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cMSStudios;
        private System.Windows.Forms.ToolStripMenuItem tSMIOpenAlbumList;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddStudio;
        private System.Windows.Forms.ToolStripMenuItem tSMIDeleteStudio;
        private System.Windows.Forms.ToolStripMenuItem tSMIUpdate;
        private AISFonotekaTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}