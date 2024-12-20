using System;

class cAGV 
{
  private int x;
  private int y;
  private agvStatus_n status;
  private richtung_n[] route;
  private richtung_n ausrichtung;
  private cAuftrag auftrag;

  public cAGV(int x, int y, richtung_n ausrichtung)
  {
    this.x = x;
    this.y = y;
    this.ausrichtung = ausrichtung;
    this.status = agvStatus_n.verfuegbar;
  }

}
