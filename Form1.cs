namespace Rain_Effect_WFApp
{
    public partial class Form1 : Form
    {
        List<Image> rainDropsList = new List<Image>();
        List<Particles> particles = new List<Particles>();
        Random rand = new Random();
        int rainDropCount = 20;

        int previousSliderValue = 0;

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            foreach (string drop in ImageFactory.Images)
            {
                Image temDrop = Image.FromFile(drop);
                rainDropsList.Add(temDrop);
            }

            for (int i = 0; i < rainDropCount; i++)
            {
                Particles newParticles = new Particles(rainDropsList[rand.Next(0, rainDropsList.Count)]);
                particles.Add(newParticles);            
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            foreach (Particles tempImage in particles)
            {
                tempImage.posX += tempImage.speed;
                tempImage.posY += 8;

                if (tempImage.posY > this.ClientSize.Height + 100)
                {
                    tempImage.speed = rand.Next(5, 15);
                    tempImage.posY = -100;
                    tempImage.posX = rand.Next(-200, 600);
                }
            }

            this.Invalidate();
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            foreach (Particles tempImage in particles)
            {
                Canvas.DrawImage(tempImage.particle, tempImage.posX, tempImage.posY,
                    tempImage.width, tempImage.height);
            }
        }

        private void onDropValueChanged(object sender, EventArgs e)
        {
            int currentValue = countDrops.Value;
            int difference = Math.Abs(currentValue - previousSliderValue) * 40;

            if (currentValue > previousSliderValue)
            {
                rainDropCount += difference;

                for (int i = 0; i < difference; i++)
                {
                    Particles newParticles = new Particles(rainDropsList[rand.Next(0, rainDropsList.Count)]);
                    particles.Add(newParticles);
                }
            }
            else
            {
                rainDropCount -= difference;

                particles.RemoveRange(particles.Count - difference, difference);
            }

            previousSliderValue = currentValue;

            label1.Text = particles.Count.ToString();
        }
    }
}