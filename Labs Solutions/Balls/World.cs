using System;
using System.Collections.Generic;
using System.Text;

public class World : Ball
{
    public World(Rectangle bounds, Brush colour, int dx, int dy, World world)
        : base(bounds, colour, dx, dy, world)
    {
    }

    public override void draw(Graphics g)
    {
        g.FillRectangle(colour, this.bounds);
    }
}

