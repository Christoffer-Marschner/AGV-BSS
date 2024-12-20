class cHaltepunkt : acKartenelement 
{
  private richtung_n ausrichtung;
  private int nummer;

  public cHaltepunkt(int x, int y, int id, richtung_n ausrichtung, int nummer) : base(x, y, id)
  {
    this.ausrichtung = ausrichtung;
    this.nummer = nummer;
  }

  public richtung_n getAusrichtung()
  {
    return ausrichtung;
  }
  
  public int getNummer()
  {
    return nummer;
  }
}