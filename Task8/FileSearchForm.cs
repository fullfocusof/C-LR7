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
            comboBoxResult.Items.Clear();

            DirectoryInfo DI = new DirectoryInfo(textBoxInput.Text);
            if (DI.Exists)
            {
                FileInfo[] FIs = DI.GetFiles();

                if (checkBoxCond.Checked)
                {
                    DirectoryInfo[] DIs = DI.GetDirectories();

                    foreach (DirectoryInfo dir in DIs)
                    {
                        comboBoxResult.Items.Add("*dir* " + dir.Name);
                    }              
                }

                foreach (FileInfo file in FIs)
                {
                    comboBoxResult.Items.Add("*file* " + file.Name);
                }
            }
            else
            {
                MessageBox.Show("Каталог не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
