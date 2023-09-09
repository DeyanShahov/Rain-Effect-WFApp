namespace Rain_Effect_WFApp
{
    internal class Particles
    {
        public int height;
        public int width;
        public int posX;
        public int posY;
        public int[] size = { 30, 40, 50};
        Random rand = new Random();
        public int speed = 0;
        int i = 0;

        public Image particle;

        public Particles(Image drop)
        {
            particle = drop;
            i = rand.Next(0, size.Length);
            height = size[i];
            width = size[i];

            posX = rand.Next(-200, 800);
            posY = rand.Next(-700, -200);

            speed = rand.Next(1, 10);          
        }
    }
}
