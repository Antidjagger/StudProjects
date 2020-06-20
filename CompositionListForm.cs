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
    public partial class CompositionListForm : Form
    {
        private long ID_Album;
        public CompositionListForm(long ID)
        {
            InitializeComponent();
            ID_Album = ID;

        }

        private void CompositionListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Styles". При необходимости она может быть перемещена или удалена.
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Artists". При необходимости она может быть перемещена или удалена.
            this.artistsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Artists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Compositions". При необходимости она может быть перемещена или удалена.
            this.compositionsTableAdapter.FillByAlbumID(this.aISFonotekaTablesDataSet.Compositions, ID_Album);
            

        }

        private void tSMIUpdate_Click(object sender, EventArgs e)
        {
            this.compositionsTableAdapter.FillByAlbumID(this.aISFonotekaTablesDataSet.Compositions, ID_Album);

            dGV_Compositions.Update();
            dGV_Compositions.Refresh();
            this.Refresh();
            this.Validate();
            this.compositionsBindingSource.EndEdit();
        }

        private void tSMIDeleteComposition_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_Compositions.CurrentRow.Cells[0].Value.ToString());
            this.compositionsTableAdapter.DeleteComposition(ID);
            this.compositionsTableAdapter.FillByAlbumID(this.aISFonotekaTablesDataSet.Compositions, ID_Album);

            dGV_Compositions.Update();
            dGV_Compositions.Refresh();
            this.Refresh();
            this.Validate();
            this.compositionsBindingSource.EndEdit();
        }

        private void tSMIAddComposition_Click(object sender, EventArgs e)
        {
            this.compositionsTableAdapter.Insert("Введите название", 1, ID_Album, 1, System.TimeSpan.Zero, 1, "Введите язык записи", "Введите страну записи");
            this.compositionsTableAdapter.FillByAlbumID(this.aISFonotekaTablesDataSet.Compositions, ID_Album);
            dGV_Compositions.DataSource = compositionsBindingSource;
            dGV_Compositions.Update();
            dGV_Compositions.Refresh();
            this.Refresh();
            this.Validate();
            this.compositionsBindingSource.EndEdit();
            int count = Int32.Parse(dGV_Compositions.Rows.Count.ToString());
            dGV_Compositions.ClearSelection();
            dGV_Compositions.Rows[count].Selected = true;
        }
        private void dGV_Compositions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.compositionsTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.compositionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }

    }
}
