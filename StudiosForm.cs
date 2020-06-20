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
    public partial class StudiosForm : Form
    {
        public StudiosForm()
        {
            InitializeComponent();
        }

        private void StudiosForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.aISFonotekaTablesDataSet.Studios);

        }

        private void tSMIOpenAlbumList_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(dGV_Studios.CurrentRow.Cells[0].ToString());
            AlbumListForm albumListForm = new AlbumListForm(ID);
            albumListForm.Show();
        }

        private void tSMIAddStudio_Click(object sender, EventArgs e)
        {
            this.studiosTableAdapter.Insert("Введите название", 0, "Введите страну", "Введите адрес", "Введите URL-адрес", "Введите приечание", "0");
            this.studiosTableAdapter.Fill(this.aISFonotekaTablesDataSet.Studios);
            dGV_Studios.DataSource = studiosBindingSource;
            dGV_Studios.Update();
            dGV_Studios.Refresh();
            this.Refresh();
            this.Validate();
            this.studiosBindingSource.EndEdit();
            int count = Int32.Parse(dGV_Studios.Rows.Count.ToString());
            dGV_Studios.ClearSelection();
            dGV_Studios.Rows[count].Selected = true;
        }

        private void tSMIDeleteStudio_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(this.dGV_Studios.CurrentRow.Cells[1].Value.ToString());
            this.studiosTableAdapter.DeleteStudio(ID);
            this.studiosTableAdapter.Fill(this.aISFonotekaTablesDataSet.Studios);

            dGV_Studios.Update();
            dGV_Studios.Refresh();
            this.Refresh();
            this.Validate();
            this.studiosBindingSource.EndEdit();
        }

        private void tSMIUpdate_Click(object sender, EventArgs e)
        {
            this.studiosTableAdapter.Fill(this.aISFonotekaTablesDataSet.Studios);
            this.studiosBindingSource.EndEdit();
        }

        private void dGV_Studios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.studiosTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.studiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }
    }
}
