using System;

namespace RandomBoxes
{
    //abstract class = bruker til å gjemme noen detaljer og kun vise viktig info til bruker. 
    abstract class Shape
    {
        //Auto properties
        //Internal = Koden kan KUN nås fram innenfor der koden er utført, men ikke fra andre
        public int DirectionX { get; internal set; }
        public int DirectionY { get; internal set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }

        //Tom constructor
        protected Shape()
        {
        }


        //Protected = Koden kan bli nådd fram innenfor samme class eller class som er inherited/arvet fra class.
        //Hvor kommer random fra? ser ut som default verdi?
        protected Shape(Random random)
        {
            DirectionX = random.Next(0, 2);
            DirectionY = random.Next(0, 2);
        }

        //Method - Legger til +1 i X eller Y
        public void Move()
        {
            X += DirectionX;
            Y += DirectionY;
        }

        //Abstraction = Betyr å gjemme noen detaljer og kun vise viktig info til bruker. 
        //deklarert uten body - mottar row og col verdi - blir brukt i rectangle.cs og triangle.cs
        public abstract string GetCharacter(int row, int col);
    }
}