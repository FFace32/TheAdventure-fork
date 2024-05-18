using Silk.NET.Maths;
using Silk.NET.SDL;

namespace TheAdventure.Models;

public class RenderableGameObject : GameObject
{
    public SpriteSheet SpriteSheet { get; set; }
    public (double X, double Y) Position { get; set; }
    public double Angle { get; set; }
    public Point RotationCenter { get; set; }

    public RenderableGameObject(SpriteSheet spriteSheet, (double X, double Y) position, double angle = 0.0, Point rotationCenter = new())
        : base()
    {
        SpriteSheet = spriteSheet.Clone() as SpriteSheet ?? spriteSheet;
        Position = position;
        Angle = angle;
        RotationCenter = rotationCenter;
    }

    public virtual void Render(GameRenderer renderer)
    {
        SpriteSheet.Render(renderer, ((int) Position.X, (int) Position.Y), Angle, RotationCenter);
    }
}
