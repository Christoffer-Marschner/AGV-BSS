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

  public int getX()
  {
    return this.x;
  }

  public int getY()
  {
    return this.y;
  }

  public agvStatus_n getStatus()
  {
    return this.status;
  }

  public void setStatus(agvStatus_n neuerStatus)
  {
    this.status = neuerStatus;
  }

  public int removeAuftrag()
  {
    // TODO auftrag entfernen - return erfolgsstatus 
  }

  public int auftragZuweisen(acKartenlement[] karte, cAuftrag auftrag)
  {
    // TODO auftrag speichen - route berechnen - return erfolgsstatus
  }

  private int besteRouteBerechnen(acKartenlement[] karte, cAuftrag auftrag)
  {
    // TODO route aus dem auftrag und kartenelement mit dem a* ähnlichen algorithmus berechnen - return erfolgsstatus
  }

  private void fahrtInitialisieren()
  {
    // TODO status auf fahren setzen - initialisierung, bevor die route abgefahren wird
  }

  public void fahrtAbbrechen()
  {
    // TODO agv anhalten
  }

  public void fahrtZurLadestation()
  {
    // TODO route zur ladestation berechen - fahrt zur ladestation einleiten
  }

  public void navigieren()
  {
    // TODO nächsten punkt in der route anfahren
  }

}
