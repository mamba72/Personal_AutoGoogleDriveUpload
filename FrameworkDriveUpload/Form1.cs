using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FrameworkDriveUpload
{
    public partial class Form1 : Form
    {

        //List<string> fileNameList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        public void FillInBar()
        {
            progressBarTest.Maximum = 30;

            for(int i = 0; i < progressBarTest.Maximum; ++i)
            {
                progressBarTest.Value++;
                Thread.Sleep(500);
                //fileListBox.Items.Add("File" + i);
                AddToListBox("File" + i, fileListBox);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("button1 was clicked");
            FillInBar();
        }

        //public event FoundFile();
        static async Task AddToListBox(string fileName, ListBox listBox)
        {
            listBox.Items.Add(fileName);
        }
    }

    //public static class Form1AsyncFunctions
    //{
    //    static async Task AddToListBox(string fileName, ListBox listBox)
    //    {
    //        listBox.Items.Add(fileName);
    //    }
    //}
}
