class cGerade : acKartenelement 
{
  private richtung_n ausrichtung;

  public cGerade(int x, int y, int id, richtung_n ausrichtung) : base(x, y, id)
  {
    this.ausrichtung = ausrichtung;
  }

  public richtung_n getAusrichtung()
  {
    return ausrichtung;
  }
}