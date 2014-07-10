using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takfila
{
    public partial class listDialogForm : Form
    {
        private List<string> fileList = new List<string>();
        private string chosenFile;
        public listDialogForm(List<string> files)
        {
            InitializeComponent();
            fileList = files; //the list of files to display
        }
        //Accessor for the user selected file
        public string ChosenFile
        {
            get { return chosenFile; }
        }
        private void listDialogForm1_Load(object sender, EventArgs e)
        {
            //Setup the dialog buttons
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            //Populate the list
            foreach (string file in fileList)
            {
                listboxFiles.Items.Add(file);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Save which file was selected
            if (listboxFiles.SelectedIndex != -1)
                chosenFile = listboxFiles.SelectedItem.ToString();
        }
    }
}
