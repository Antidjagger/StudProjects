using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISFonotekaFrameWork
{
    public partial class AlbumListForm : Form
    {
        private long ID_Studio;
        public AlbumListForm(long ID)
        {
            InitializeComponent();
            ID_Studio = ID;
        }

        private void AlbumListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.RecordType". При необходимости она может быть перемещена или удалена.
            this.recordTypeTableAdapter.Fill(this.aISFonotekaTablesDataSet.RecordType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Styles". При необходимости она может быть перемещена или удалена.
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);
            this.albumsTableAdapter.FillByStudiosID(this.aISFonotekaTablesDataSet.Albums, ID_Studio);

        }

        private void tSMIOpenCompositionList_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_Albums.CurrentRow.Cells[0].Value.ToString());
            CompositionListForm compositionListForm = new CompositionListForm(ID);
            compositionListForm.Show();
        }

        private void tSMIAddAlbum_Click(object sender, EventArgs e)
        {
            this.albumsTableAdapter.Insert("Введите название", 1, 1, 0, System.TimeSpan.Zero, ID_Studio, 1);
            this.albumsTableAdapter.FillByStudiosID(this.aISFonotekaTablesDataSet.Albums, ID_Studio);
            dGV_Albums.DataSource = albumsBindingSource;
            dGV_Albums.Update();
            dGV_Albums.Refresh();
            this.Refresh();
            this.Validate();
            this.albumsBindingSource.EndEdit();
            int count = Int32.Parse(dGV_Albums.Rows.Count.ToString());
            dGV_Albums.ClearSelection();
            dGV_Albums.Rows[count].Selected = true;
        }

        private void tSMIDeleteAlbum_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_Albums.CurrentRow.Cells[0].Value.ToString());
            this.albumsTableAdapter.DeleteAlbum(ID);
            this.albumsTableAdapter.FillByStudiosID(this.aISFonotekaTablesDataSet.Albums, ID_Studio);

            dGV_Albums.Update();
            dGV_Albums.Refresh();
            this.Refresh();
            this.Validate();
            this.albumsBindingSource.EndEdit();
        }

        private void tSMIUpdate_Click(object sender, EventArgs e)
        {
            this.albumsTableAdapter.FillByStudiosID(this.aISFonotekaTablesDataSet.Albums, ID_Studio);
        }

        private void dGV_Albums_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.albumsTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.albumsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }
    }
}
