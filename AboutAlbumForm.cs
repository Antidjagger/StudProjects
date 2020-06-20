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
    public partial class AboutAlbumForm : Form
    {
        private string Album_Name;
        private long Album_ID;
        public AboutAlbumForm()
        {
            InitializeComponent();
            Album_Name = "Без альбома/Сингл";
        }
        public AboutAlbumForm(string Name)
        {
            InitializeComponent();
            Album_Name = Name;
        }
        public AboutAlbumForm(long ID)
        {
            InitializeComponent();
            Album_ID = ID;
        }

        private void AboutAlbumForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.RecordType". При необходимости она может быть перемещена или удалена.
            this.recordTypeTableAdapter.Fill(this.aISFonotekaTablesDataSet.RecordType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.aISFonotekaTablesDataSet.Studios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Styles". При необходимости она может быть перемещена или удалена.
            this.stylesTableAdapter.Fill(this.aISFonotekaTablesDataSet.Styles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.aISFonotekaTablesDataSet.Albums);
            try
            {
                //this.albumsTableAdapter.FillByAlbumName(this.aISFonotekaTablesDataSet.Albums, Album_Name);
                this.albumsTableAdapter.FillByComposition(this.aISFonotekaTablesDataSet.Albums, Album_ID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dGV_Album_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.albumsTableAdapter.Update(aISFonotekaTablesDataSet);
            this.Validate();
            this.albumsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aISFonotekaTablesDataSet);
        }

        private void tSMIUpdateAlbum_Click(object sender, EventArgs e)
        {
            this.albumsTableAdapter.FillByComposition(this.aISFonotekaTablesDataSet.Albums, Album_ID);

            dGV_Album.Update();
            dGV_Album.Refresh();
            this.Refresh();
            this.Validate();
            this.albumsBindingSource.EndEdit();
        }
    }
}
