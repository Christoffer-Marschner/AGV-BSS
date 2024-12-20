abstract class acKartenelement 
{
  private int x, y, id;

  public acKartenelement(int x, int y, int id) 
  {
    this.x = x;
    this.y = y;
    this.id = id;
  }

  public int getX() 
  {
    return x;
  }

  public int getY() 
  {
    return y;
  }

  public int getId() 
  {
    return id;
  }
}