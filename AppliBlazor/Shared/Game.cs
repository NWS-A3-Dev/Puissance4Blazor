using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliBlazor.Shared
{
    public class Game
    {
        public Couleur[][] Board;
        public Couleur Turn = Couleur.Jaune;

        public Game()
        {
            InitBoard();
        }

        public void InitBoard()
        {
            int count = 0;

            Board = new Couleur[7][];

            while (count < 7)
            {
                Board[count] = new Couleur[7];
                ++count;
            }
        }

        public void Put(int x)
        {
            int count = 0;
            int last = 0;

            while (count < 7 && Board[count][x] == Couleur.Vide)
            {
                last = count;
                ++count;
            }
            
            Board[last][x] = Turn;
            ChangeTurn();
        }

        public void ChangeTurn()
        {
            Turn = (Turn == Couleur.Jaune ? Couleur.Rouge : Couleur.Jaune);
        }
    }
}
