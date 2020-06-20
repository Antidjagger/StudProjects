using AISFonotekaFrameWork.Forms;
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
    public partial class MainForm : Form
    {
        public int CountArtistCompositions;
        public MainForm()
        {
            InitializeComponent();
            this.MainToolMenu.Renderer = new ToolStripProfessionalRenderer(new Cols());
            
        }
        public MainForm(int Role)
        {
            InitializeComponent();
            this.MainToolMenu.Renderer = new ToolStripProfessionalRenderer(new Cols());
            if (Role == 2)
            {
                this.btnLog.Enabled = true;
                this.btnLog.Visible = true;
            }
            CountArtistCompositions = 0;
        }


        public class Cols : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.Black; }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return Color.Black; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return Color.Black; }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.Black; }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(51, 153, 255); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(51, 153, 255); }

            }
        }


        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        
        

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tSMIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArtistCompositions_Click(object sender, EventArgs e)
        {
            if (CountArtistCompositions < 2)
            {
                ArtistCompositionsForm artistAlbum = new ArtistCompositionsForm();
                artistAlbum.Show();
                CountArtistCompositions++;
            }
            else
            {
                Console.WriteLine("Слишком много окон");
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            LogJournalForm logJournalForm = new LogJournalForm();
            logJournalForm.Show();
        }

        private void btnCompositions_Click(object sender, EventArgs e)
        {
            AboutCompositionsForm compositionsForm = new AboutCompositionsForm();
            compositionsForm.Show();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            AlbumsForm albumsForm = new AlbumsForm();
            albumsForm.Show();
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            StylesForm stylesForm = new StylesForm();
            stylesForm.Show();
        }

        private void btnOpenStudios_Click(object sender, EventArgs e)
        {
            StudiosForm studiosForm = new StudiosForm();
            studiosForm.Show();
        }

        private void btnOpenRecordTypes_Click(object sender, EventArgs e)
        {
            RecordTypesForm recordTypesForm = new RecordTypesForm();
            recordTypesForm.Show();
        }

        private void tSMIAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
