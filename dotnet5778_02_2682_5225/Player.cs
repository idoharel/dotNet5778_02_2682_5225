﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    class Player
    {
        private string name;
        private Queue<Card> playerCards = new Queue<Card>();//queue of the player's cards

        public Player(string _name)
        { name = _name; }

        //property name
        #region property
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal Queue<Card> PlayerCards
        {
            get
            {
                return playerCards;
            }

            set
            {
                playerCards = value;
            }
        }
        #endregion
        public void addCard(params Card[] cards)//function that get ine or more cards and push them to the end of the queue
        {
            foreach (var i in cards)
                playerCards.Enqueue(i);
        }


        public override string ToString()//to string overloading that returns the player, how many cards he have, and all their names
        {
            string allCards = null;
            string tmp1 = null, tmp2 = null;
            foreach (var i in playerCards)
            {
                tmp1 = i.CardName;
                tmp2 = allCards;
                allCards = tmp2 + '\n' + tmp1;
            }
            return Name + "\nnumber card: " + playerCards.Count + allCards;
        }

        public bool lose()//check if the player lose
        {
            if (playerCards.Count == 0)
                return false;
            else return true;
        }

        public Card pop()
        {
            if (!(playerCards.Count == 0))
                return playerCards.Dequeue();
            else return null;
        }
    }


}
