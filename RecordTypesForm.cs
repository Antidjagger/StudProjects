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
    public partial class RecordTypesForm : Form
    {
        public RecordTypesForm()
        {
            InitializeComponent();
        }

        private void RecordTypesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Styles". При необходимости она может быть перемещена или удалена.
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.aISFonotekaTablesDataSet.Studios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.RecordType". При необходимости она может быть перемещена или удалена.
            this.recordTypeTableAdapter.Fill(this.aISFonotekaTablesDataSet.RecordType);

        }

        private void tSMIAddAlbum_Click(object sender, EventArgs e)
        {
            this.albumsTableAdapter.Insert("Введите название", 1, 1, 0, System.TimeSpan.Zero, 1, Int64.Parse(dGV_RecordTypes.CurrentRow.Cells[0].ToString()));
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);
            dGV_Albums.DataSource = fKAlbumsRecordTypeBindingSource;
            dGV_Albums.Update();
            dGV_Albums.Refresh();
            this.Refresh();
            this.Validate();
            this.fKAlbumsRecordTypeBindingSource.EndEdit();
            int count = Int32.Parse(dGV_Albums.Rows.Count.ToString());
            dGV_Albums.ClearSelection();
            dGV_Albums.Rows[count].Selected = true;
        }

        private void tSMIDeleteAlbum_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_Albums.CurrentRow.Cells[0].Value.ToString());
            this.albumsTableAdapter.DeleteAlbum(ID);
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);

            dGV_Albums.Update();
            dGV_Albums.Refresh();
            this.Refresh();
            this.Validate();
            this.fKAlbumsRecordTypeBindingSource.EndEdit();
        }

        private void tSMIUpdate_Click(object sender, EventArgs e)
        {
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);

            dGV_Albums.Update();
            dGV_Albums.Refresh();
            this.Refresh();
            this.Validate();
            this.fKAlbumsRecordTypeBindingSource.EndEdit();
        }

        private void tSMIOpenCompositionList_Click(object sender, EventArgs e)
        {

            long ID = Int64.Parse(this.dGV_Albums.CurrentRow.Cells[0].Value.ToString());
            CompositionListForm compositionListForm = new CompositionListForm(ID);
            compositionListForm.Show();
        }

        

        private void tSMIAddRecord_Click(object sender, EventArgs e)
        {
            this.recordTypeTableAdapter.Insert("Введите название");
            this.recordTypeTableAdapter.Fill(this.aISFonotekaTablesDataSet.RecordType);
            dGV_RecordTypes.DataSource = recordTypeBindingSource;
            dGV_RecordTypes.Update();
            dGV_RecordTypes.Refresh();
            this.Refresh();
            this.Validate();
            this.recordTypeBindingSource.EndEdit();
            int count = Int32.Parse(dGV_RecordTypes.Rows.Count.ToString());
            dGV_RecordTypes.ClearSelection();
            dGV_RecordTypes.Rows[count].Selected = true;
        }

        private void tSMIDeleteRecord_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_RecordTypes.CurrentRow.Cells[0].Value.ToString());
            this.recordTypeTableAdapter.DeleteRecordType(ID);
            this.recordTypeTableAdapter.Fill(this.aISFonotekaTablesDataSet.RecordType);

            dGV_RecordTypes.Update();
            dGV_RecordTypes.Refresh();
            this.Refresh();
            this.Validate();
            this.recordTypeBindingSource.EndEdit();

        }

        private void tSMIUpdateRecord_Click(object sender, EventArgs e)
        {
            this.recordTypeTableAdapter.Fill(this.aISFonotekaTablesDataSet.RecordType);
            this.recordTypeBindingSource.EndEdit();
        }


        private void dGV_Albums_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.albumsTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.fKAlbumsRecordTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }
        private void dGV_RecordTypes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.recordTypeTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.recordTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }
    }
}
