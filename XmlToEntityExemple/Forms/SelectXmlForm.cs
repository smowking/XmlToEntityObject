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
using System.Xml;
using XmlToEntityExemple.Classes;
using XmlToEntityExemple.Entities;
using XmlToEntityExemple.FileReader;
using XmlToEntityExemple.FileReader.Implementation.Xml;

namespace XmlToEntityExemple
{
    public partial class SelectXmlForm : Form
    {
        public SelectXmlForm()
        {
            InitializeComponent();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!openFileDialog.FileName.Equals(""))
                {
                    ClientReader reader;
                    reader = new ClientReader(new ConverterXml<ClientInfo>("CLIENTE"));
                    textBox1.Text = openFileDialog.FileName;
                    dataGridView1.DataSource = reader.ProcessFile(openFileDialog.FileName);
                }
            }
        }
    }
}
