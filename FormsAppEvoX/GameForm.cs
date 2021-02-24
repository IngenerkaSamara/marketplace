﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppEvoX
{
    public partial class GameForm : Form
    {

        public GameForm(string game)
        {
            InitializeComponent();

            label1.Text = game;
            try
            {
                GamePicture.Load("../../Маркет плэйс/" + game + ".png");
            }
            catch (Exception)
            {
                try
                {
                    GamePicture.Load("../../Маркет плэйс/" + game + ".jpg");
                }
                catch (Exception) { }
            }


            if (game == "GTA V")
            {
                labelPrice.Text = "1498.50 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: Rockstar North";
                labelPromoter.Text = "ИЗДАТЕЛЬ: Rockstar Games";
                label2.Text = "Дата выхода 14 апр. 2015";
            }

            if (game == "Destiny")
            {
                labelPrice.Text = "5591 руб.";
                labelDeveloper.Text = "Разработчик: Bungel";
                labelPromoter.Text = "Издатель: Activision";
                label2.Text = "Дата выхода: 10 ноя. 2020";
            }

            if (game == "CS GO")
            {
                labelPrice.Text = "Бесплатно";
                labelDeveloper.Text = "ДАТА ВЫХОДА: 21 авг. 2012";
                labelPromoter.Text = "РАЗРАБОТЧИК:Valve, Hidden Path Entertainment";
                label2.Text = "ИЗДАТЕЛЬ:Valve";
            }
            if (game == "Mortal Kombat")
            {
                labelPrice.Text = "690 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК:  NetherRealm Studios, QLOC, Shiver";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  Warner Bros Interactive Entertainment";
                label2.Text = "Дата выхода 23 апр. 2019";
            }
            if (game == "Forza")
            {
                labelPrice.Text = "800 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК:  Playground Games, Turn 10 Studios";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  Playground Games, Turn 10 Studios";
                label2.Text = "Дата выхода 2018 г.";
            }
            if (game == "Mirrors Edge")
            {
                labelPrice.Text = "999 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: EA DICE";
                labelPromoter.Text = "ИЗДАТЕЛЬ: EA DICE";
                label2.Text = "Дата выхода 2008 г.";                
            }

            if (game == "WITCHER")
            { 
                labelPrice.Text = "1354 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
            }


            if (game == "CALL of DUTY WTR")
            {
                labelPrice.Text = "899 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2008 г.";
            }

            if (game == "CALL of DUTY")
            {
                labelPrice.Text = "1999 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
            }
            if (game == "L.A Noire")
                {
                    labelPrice.Text = "699 руб";
                    labelDeveloper.Text = "РАЗРАБОТЧИК; Team Bondi";
                    labelPromoter.Text = "ИЗДАТЕЛЬ:  Rockstar games";
                    label2.Text = "Дата выхода 8 ноя.2011 г.";
                }

        }









        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}