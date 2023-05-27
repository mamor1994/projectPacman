﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPacman
{
    public partial class GameOverForm : Form
    {

        private string name;
        private string selectedDifficulty;

        //SoundPlayer player = new SoundPlayer("mysound.wav");

        public GameOverForm()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // player.Stop();

            this.Hide();
            CloseGameAndGameOverForms();
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // player.Stop();
            if (selectedDifficulty == "Easy")
            {
                this.Hide();
                CloseGameAndGameOverForms();
                EasyGameForm easyGame = new EasyGameForm(name, selectedDifficulty);
                easyGame.ShowDialog();


            }
            else if (selectedDifficulty == "Hard")
            {
                this.Hide();
                CloseGameAndGameOverForms();
                EasyGameForm easyGame = new EasyGameForm(name, selectedDifficulty);
                easyGame.ShowDialog();

                //HardGameForm hardGame = new HardGameForm(name);
                //hardGame.ShowDialog();
            }
        }
        private void CloseGameAndGameOverForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is EasyGameForm)
                {
                    form.Hide();
                    break;
                }
            }
            this.Hide();
        }

    }
}
