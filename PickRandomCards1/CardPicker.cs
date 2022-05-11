using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards1
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            //Pobieranie liczby losowej do 1 do 4
            int value = random.Next(1, 5);
            //Jeśli liczba 1, należy zwrócić łańcuch znaków "pik"
            if (value == 1) return "pik";
            //Jeśli liczba 2, należy zwrócić łańcuch znaków "kier"
            if (value == 2) return "kier";
            //Jeśli liczba 3 należy zwrócić łańcuch znaków "trefl"
            if (value == 3) return "trefl";
            //Jeśli do tej pory metoda nie zwróciła sterowania, należy zwrócić "karo"
            return "karo";

        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "As";
            if (value == 11) return "Walet";
            if (value == 12) return "Dama";
            if (value == 13) return "Król";
            return value.ToString();

        }
    }
}