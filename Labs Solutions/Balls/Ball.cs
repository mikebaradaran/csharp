using System;
using System.Collections.Generic;
using System.Drawing;


public class Ball
{
    //public static event EventHandler<char> SideHit = delegate { };
    public World world;
    public RectangleF bounds;
    protected Brush colour;
    protected float dx, dy;

    public Ball(RectangleF bounds, Brush colour, float dx, float dy, World world)
    {
        this.bounds = bounds;
        this.colour = colour;
        this.dx = dx;
        this.dy = dy;
        this.world = world;
    }

    public virtual void draw(Graphics g)
    {
        g.FillEllipse(colour, bounds);
    }

    public double Right { get { return this.bounds.Right; } }

    public double Bottom  { get { return this.bounds.Bottom; } }

    public void move()
    {
        bounds.Offset(dx, dy);

        float friction = 0.9F;
        if (this.Right >= world.Right)
        {
            bounds.X = (float)(world.Right - bounds.Width);   // push back inside
            dx = -dx * friction;
            //SideHit(this, 'R');
        }

        if (bounds.Left <= world.bounds.Left)
        {
            bounds.X = world.bounds.Left;
            dx = -dx * friction;
            //SideHit(this, 'L');

        }

        if (this.Bottom >= world.Bottom)
        {
            bounds.Y = world.bounds.Bottom - bounds.Height;
            dy = -dy * friction;
            //SideHit(this, 'B');

        }

        if (bounds.Top <= world.bounds.Top)
        {
            bounds.Y = world.bounds.Top;
            dy = -dy * friction;
            //SideHit(this, 'T');

        }
    }

}
