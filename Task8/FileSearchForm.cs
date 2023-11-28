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

namespace Task8
{
    public partial class FileSearchForm : Form
    {
        public FileSearchForm()
        {
            InitializeComponent();
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
            comboBoxFiles.Items.Clear();

            DirectoryInfo DI = new DirectoryInfo(textBoxInput.Text);
            if (DI.Exists)
            {
                SearchOption SO = SearchOption.TopDirectoryOnly;

                if (checkBoxCond.Checked)
                {
                    SO = SearchOption.AllDirectories;
                }

                FileInfo[] FIs = DI.GetFiles(textBoxInputFile.Text, SO);
                labelResult.Text = "Найдено файлов: " + FIs.Length + "\n";
                foreach (FileInfo file in FIs)
                {
                    comboBoxFiles.Items.Add(file.FullName);
                }
            }
            else
            {
                MessageBox.Show("Каталог не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
