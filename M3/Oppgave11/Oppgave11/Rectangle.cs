namespace Oppgave11
{
    public class Rectangle
    {
        //float = decimal tall

                    //!! Skriv ned at du kan ha funksjoner her !!
        public float Area => Width * Height;
        private float Width { get; set; }

        private float Height { get; set; }

        public Rectangle(float width, float height)
        {
            Height = height;
            Width = width;
        }


    }
}