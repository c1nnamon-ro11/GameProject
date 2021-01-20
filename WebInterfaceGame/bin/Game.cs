﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace FirstGame
{
    static class Game
    {
        static void Main(string[] args)
        {
            //Initialization and game size
            //WindowsBase.dll and PresentationCore.dll
            Form GameScreen = new Form();
            GameScreen.Width = 1920;
            GameScreen.Height = 1080;           
            GameFunctional.Initialization(GameScreen);
            GameScreen.Text = "Asteroid Belt";
            GameScreen.Show();
            GameFunctional.Drawing();
            Application.Run(GameScreen);
        }
    }
}
