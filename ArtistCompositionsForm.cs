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
    public partial class ArtistCompositionsForm : Form
    {
        public ArtistCompositionsForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Compositions". При необходимости она может быть перемещена или удалена.
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.aISFonotekaTablesDataSet.Studios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.RecordType". При необходимости она может быть перемещена или удалена.
            this.recordTypeTableAdapter.Fill(this.aISFonotekaTablesDataSet.RecordType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Styles". При необходимости она может быть перемещена или удалена.
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Artists". При необходимости она может быть перемещена или удалена.
            this.artistsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Artists);
            

        }

        private void cMSOpenAlbum_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tSMIOpenAlbumForm_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(dGV_Compositions.CurrentRow.Cells[0].Value.ToString());
            AboutAlbumForm aboutAlbumForm = new AboutAlbumForm(ID);
            aboutAlbumForm.Show();
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

        private void dGV_Artist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGV_Artist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.artistsTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.artistsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }

        private void dGV_Compositions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.compositionsTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.compositionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
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

        private void tSMIUpdateArtist_Click(object sender, EventArgs e)
        {
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);

            dGV_Compositions.Update();
            dGV_Compositions.Refresh();
            this.Refresh();
            this.Validate();
            this.compositionsBindingSource.EndEdit();
        }

        private void tSMIDeleteArtist_Click(object sender, EventArgs e)
        {
            
            long ID = Int64.Parse(this.dGV_Artist.CurrentRow.Cells[0].Value.ToString());
            this.artistsTableAdapter.DeleteArtist(ID, this.dGV_Artist.CurrentRow.Cells[1].Value.ToString());
            this.artistsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Artists);

            dGV_Artist.Update();
            dGV_Artist.Refresh();
            this.Refresh();
            this.Validate();
            this.artistsBindingSource.EndEdit();
        }

        private void tSMIAddArtist_Click(object sender, EventArgs e)
        {
            this.artistsTableAdapter.Insert("Введите имя исполнителя");
            this.artistsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Artists);

            dGV_Artist.Update();
            dGV_Artist.Refresh();
            this.Refresh();
            this.Validate();
            this.artistsBindingSource.EndEdit();
            int count = Int32.Parse(dGV_Artist.Rows.Count.ToString());
            dGV_Artist.ClearSelection();
            dGV_Artist.Rows[count-2].Selected = true;
            
        }
    }
}
