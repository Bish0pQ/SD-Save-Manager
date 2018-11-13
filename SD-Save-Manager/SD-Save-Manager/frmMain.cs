using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_Save_Manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string SaveGameLocation;

        private void frmMain_Load(object sender, EventArgs e)
        {
            /* Check whether the save game has been found */
            Tuple<bool, string>  saveFound = MainController.FindSaveGame();

            if (saveFound.Item1)
            {
                MessageBox.Show("The save has succesfully been located! You can proceed!", "Save game found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToggleControls(true);
                SaveGameLocation = saveFound.Item2;
            }
            else
            {
                MessageBox.Show("The save game location has not been found! You can not proceed!", "Error: save not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToggleControls(false);
                 
            }
        }

        private void ToggleControls(bool status)
        {
            btnCopyCurrent.Enabled = status;
            btnDelete.Enabled = status;
            btnLoadSave.Enabled = status;
            btnRename.Enabled = status;
        }

    }
}
