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
    public partial class StylesForm : Form
    {
        public StylesForm()
        {
            InitializeComponent();
        }

        private void StylesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Artists". При необходимости она может быть перемещена или удалена.
            this.artistsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Artists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Compositions". При необходимости она может быть перемещена или удалена.
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Styles". При необходимости она может быть перемещена или удалена.
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);

        }

        private void tSMIOpenAlbumForm_Click(object sender, EventArgs e)
        {
            long IDC = Int64.Parse(dGV_Compositions.CurrentRow.Cells[0].Value.ToString());
            long ID = (long)compositionsTableAdapter.GetAlbumID(IDC);
           
            AboutAlbumForm aboutAlbumForm = new AboutAlbumForm(ID);
            aboutAlbumForm.Show();
        }

        private void tSMIAddComposition_Click(object sender, EventArgs e)
        {
            this.compositionsTableAdapter.Insert("Введите название", 1, 1, Int64.Parse(dGV_Styles.CurrentRow.Cells[0].Value.ToString()), System.TimeSpan.Zero, 1, "Введите язык записи", "Введите страну записи");
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);
           
            int count = Int32.Parse(dGV_Compositions.Rows.Count.ToString());
            dGV_Compositions.ClearSelection();
            dGV_Compositions.Rows[count].Selected = true;
            this.fKStyleBindingSource.EndEdit();
        }

        private void tSMIUpdate_Click(object sender, EventArgs e)
        {
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);
        }

        private void dGV_Compositions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.compositionsTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.fKStyleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }

        private void dGV_Styles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.stylesTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.stylesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }

        private void tSMIDeleteComposition_Click(object sender, EventArgs e)
        {
            
            long ID = Int64.Parse(this.dGV_Compositions.CurrentRow.Cells[0].Value.ToString());
            this.compositionsTableAdapter.DeleteComposition(ID);
            this.compositionsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Compositions);

            dGV_Compositions.Update();
            dGV_Compositions.Refresh();
            this.Refresh();
            this.Validate();
            this.fKStyleBindingSource.EndEdit();
        }

        private void tSMIAddStyle_Click(object sender, EventArgs e)
        {
            this.stylesTableAdapter.Insert("Введите название");
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);

            int count = Int32.Parse(dGV_Styles.Rows.Count.ToString());
            dGV_Styles.ClearSelection();
            dGV_Styles.Rows[count].Selected = true;
            this.stylesBindingSource.EndEdit();
        }

        private void tSMIUpdateStyle_Click(object sender, EventArgs e)
        {
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);
        }

        private void tSMIDeleteStyle_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_Styles.CurrentRow.Cells[0].Value.ToString());
            this.stylesTableAdapter.DeleteStyle(ID);
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);

            dGV_Styles.Update();
            dGV_Styles.Refresh();
            this.Refresh();
            this.Validate();
            this.stylesBindingSource.EndEdit();
        }
    }
}
