using System;
using System.Collections.Generic;
using System.Drawing;

public class Balls
{
    World world;

    List<Ball> balls = new List<Ball>();
    public Balls(World world)
    {
        this.world = world;
        Random rnd = new Random();

        balls.Add(world);  // Must add the world first!

        for (int i = 0; i < 10; i++)
        {
            int radius = rnd.Next(20, 51);
            int x = rnd.Next(30, 100);
            int y = rnd.Next(30, 100);
            int w = rnd.Next(20, 50);
            int h = rnd.Next(20, 50);
            int dx = rnd.Next(1, 5);
            int dy = rnd.Next(1, 5);

            byte r = (byte)rnd.Next(0, 256);
            byte g = (byte)rnd.Next(0, 256);
            byte b = (byte)rnd.Next(0, 256);
            Color c = Color.FromArgb(r, g, b);
            Brush brush = new SolidBrush(c);
            Ball ball = new Ball(new Rectangle(x, y, w, h), brush, dx, dy, world);
            balls.Add(ball);
          
        }
    }
    public void move(Graphics g)
    {

        foreach (Ball ball in balls)
        {
            ball.move();
            ball.draw(g);
        }

    }

}