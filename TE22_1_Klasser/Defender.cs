using Raylib_cs;

class Defender
{
  private Rectangle rect = new Rectangle(380, 550, 40, 20);

  private float speed = 2;

  public void Update()
  {
    if (Raylib.IsKeyDown(KeyboardKey.Right))
    {
      rect.X += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.Left))
    {
      rect.X -= speed;
    }

    rect.X = Math.Clamp(rect.X, 0, 760);
  }

  public void Draw()
  {
    Raylib.DrawRectangleRec(rect, Color.Black);
  }
}