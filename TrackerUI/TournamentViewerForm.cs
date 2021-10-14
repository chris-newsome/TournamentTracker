using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        public TournamentViewerForm()
        {
            InitializeComponent();
            tournamentTabControl.ItemSize = new Size(0, 1);
            removePlayerButton.Text = char.ConvertFromUtf32(8592);
            addPlayerButton.Text = char.ConvertFromUtf32(8594);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {

        }

        private void scoreButton_MouseDown(object sender, MouseEventArgs e)
        {
            scoreButton.ForeColor = Color.Black;
            scoreButton.BackColor = Color.FromArgb(140, 196, 134);
            scoreButton.FlatAppearance.BorderColor = Color.FromArgb(140, 196, 134);
            
        }

        private void scoreButton_MouseUp(object sender, MouseEventArgs e)
        {
            scoreButton.ForeColor = Color.White;
            scoreButton.BackColor = Color.FromArgb(0, 156, 222);
            scoreButton.FlatAppearance.BorderColor = Color.FromArgb(0, 156, 222);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            tournamentTabControl.SelectedTab = tabPage4;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeButton.ForeColor = Color.Black;
            closeButton.BackColor = Color.FromArgb(140, 196, 134);
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(140, 196, 134);
        }

        private void closeButton_MouseUp(object sender, MouseEventArgs e)
        {
            closeButton.ForeColor = Color.White;
            closeButton.BackColor = Color.FromArgb(0, 156, 222);
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 156, 222);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tournamentTabControl.SelectedTab = tabPage1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tournamentTabControl.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tournamentTabControl.SelectedTab = tabPage0;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            loadExistingTournamentLabel.Enabled = true;
            loadExistingTournamentCombo.Enabled = true;
            loadTournamentButton.Enabled = true;
            createTournamentNavButton.Enabled = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            loadExistingTournamentLabel.Enabled = false;
            loadExistingTournamentCombo.Enabled = false;
            loadTournamentButton.Enabled = false;
            createTournamentNavButton.Enabled = true;
        }
    }
}
