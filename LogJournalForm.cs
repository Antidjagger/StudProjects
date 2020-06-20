using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AISFonotekaFrameWork.Forms
{
    public partial class LogJournalForm : Form
    {
        public LogJournalForm()
        {
            InitializeComponent();
        }

        private void LogJournalForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aISFonotekaTablesDataSet.LogJournal". При необходимости она может быть перемещена или удалена.
            this.logJournalTableAdapter.Fill(this.aISFonotekaTablesDataSet.LogJournal);

        }

        private void tSBtnSaveLog_Click(object sender, EventArgs e)
        {
            saveLogJournal.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveLogJournal.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveLogJournal.FileName;
            string path = Path.GetDirectoryName(filename);


            MessageBox.Show("Файл сохранен");

            aISFonotekaTablesDataSet.LogJournal.WriteXml(filename);
        }
    }
}
