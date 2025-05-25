using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    internal class CardShuffler
    {
    }
    public class Card
    {
        private string face;
        private string suit;
        public Card(string face, string suit)
        {
            this.face = face;
            this.suit = suit;
        }   
        public override string ToString()
        {
            return face + " " + suit;
        }
    }

    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int no_of_cards = 52;
        private Random randomNumber;

        public Deck()
        {
            string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "Hearts","Clubs","Diamonds","Spades"}; // "♠", "♥", "♦", "♣"
            deck = new Card[no_of_cards];
            currentCard = 0;
            randomNumber = new Random();
            for(int count =0;count<deck.Length;count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
                //Console.WriteLine("Count:" + count + "Face:" + count % 13 + "Suit:" + count / 13); 
            }
        }

        public void Suffle()
        {
            currentCard = 0;
            for(int first =0;first<deck.Length;first++)
            {
                int second = randomNumber.Next(no_of_cards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
                    
            }
        }
        public Card DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }

        public void SuffleSingleMethod()
        {
            Random randomNumber = new Random(DateAndTime.Now.Millisecond);
            List<int> suffleDeck = new List<int>(52);
            List<int> deckSecq = Enumerable.Range(0,52).ToList();
            int card;
            for(int i = 0; i < 52; i++)
            {
                card = deckSecq[randomNumber.Next(deckSecq.Count)];
                deckSecq.Remove(card);
                suffleDeck.Add(card);
            }

            foreach(int i in suffleDeck)
            {
                Console.WriteLine(i);
            }
        }
    }
}
