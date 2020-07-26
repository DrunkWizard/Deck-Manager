using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeckController;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DeckManager deckManager = new DeckManager();
        public Form1()
        {
            InitializeComponent();
        }
        private void deleteDeckButton_Click(object sender, EventArgs e)
        {
            deckManager.DeleteDeck(deleteText.Text);
        }

        private void createDeckButton_Click(object sender, EventArgs e)
        {
            deckManager.CreateNewDeck(createText.Text);
        }

        private void shuffleDeckButton_Click(object sender, EventArgs e)
        {
            if (isHand.Checked)
            {
                deckManager.HandShuffleDeck(shuffleText.Text);
            }
            else
            {
                deckManager.ShuffleDeck(shuffleText.Text);
            }
        }

        private void getDeckNamesButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < deckManager.GetDeckNames().Count; i++)
            {
                deckNames.Text += deckManager.GetDeckNames()[i].ToString() + ", ";
            }
        }

        private void GetDeckByNameButton_Click(object sender, EventArgs e)
        {
            deckManager.GetDeckByName(GetDeckText.Text);
            deckNames.Text = deckManager.GetDeckByName(GetDeckText.Text);
        }
        
    }
}