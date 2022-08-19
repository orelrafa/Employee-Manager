using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "company files (*.cmp)|*.cmp|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, Company.COMPANY_LIST);
                    formatter.Serialize(stream, Company.DEP_IT);
                    formatter.Serialize(stream, Company.DEP_SALES);
                    formatter.Serialize(stream, Company.DEP_SUPPORT);
                }
            }
        }

        private void btnLoad_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "company files (*.cmp)|*.cmp|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Company.COMPANY_LIST = (List<List<Employee>>)binaryFormatter.Deserialize(stream);
                Company.DEP_IT= (List<Employee>)binaryFormatter.Deserialize(stream);
                Company.DEP_SALES = (List<Employee>)binaryFormatter.Deserialize(stream);
                Company.DEP_SUPPORT = (List<Employee>)binaryFormatter.Deserialize(stream);
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
