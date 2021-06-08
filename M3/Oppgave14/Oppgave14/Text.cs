using System;

namespace RandomBoxes
{
    class Text : Shape
    {
        private string TextSomSkalVises { get; set; }

        //??????? hva skjer med base her
        public Text(int x, int y, string text, Random random) : base(random)
        {
            X = x;
            Y = y;
            TextSomSkalVises = text;
        }

        public override string GetCharacter(int row, int col)
        {
            //Hvis ikke row er lik Y eller
            //Col er mindre enn x + Text.length > returner null
            if (row != Y || col < X || col >= X + TextSomSkalVises.Length) return null;
            var index = col - X;
            return TextSomSkalVises[index].ToString();
        }
    }
}