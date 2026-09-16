
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Balls balls;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            World formWorld = new World(this.ClientRectangle, Brushes.Aqua, 0, 0, null);
            World w = new World(new Rectangle(30, 20, 300, 300), Brushes.Aqua, 2, 3, formWorld);
            balls = new Balls(w);
            var t = new System.Windows.Forms.Timer();
            t.Interval = 50;
            t.Tick += (s, ev) =>
            {
                this.Invalidate();
            };
            this.Paint += (s, ev) =>
            {
                balls.move(ev.Graphics);
            };
            t.Start();

            
           
        }
    }
}
