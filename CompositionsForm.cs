using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISFonotekaFrameWork.Forms
{
    public partial class AboutCompositionsForm : Form
    {
        public AboutCompositionsForm()
        {
            InitializeComponent();
        }

        private void CompositionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Styles". При необходимости она может быть перемещена или удалена.
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Artists". При необходимости она может быть перемещена или удалена.
            this.artistsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Artists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Compositions". При необходимости она может быть перемещена или удалена.
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);

        }

        private void tSMIOpenAlbumForm_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(dGV_Compositions.CurrentRow.Cells[0].Value.ToString());
            AboutAlbumForm aboutAlbumForm = new AboutAlbumForm(ID);
        }

        private void tSMIAddComposition_Click(object sender, EventArgs e)
        {
            this.compositionsTableAdapter.Insert("Введите название", 1, 1, 1, System.TimeSpan.Zero, 1, "Введите язык записи", "Введите страну записи");
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);
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

        private void tSMIDeleteComposition_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_Compositions.CurrentRow.Cells[1].Value.ToString());
            this.compositionsTableAdapter.DeleteComposition(ID);
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);

            dGV_Compositions.Update();
            dGV_Compositions.Refresh();
            this.Refresh();
            this.Validate();
            this.compositionsBindingSource.EndEdit();
        }

        private void tSMIUpdate_Click(object sender, EventArgs e)
        {
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);

            dGV_Compositions.Update();
            dGV_Compositions.Refresh();
            this.Refresh();
            this.Validate();
            this.compositionsBindingSource.EndEdit();
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
