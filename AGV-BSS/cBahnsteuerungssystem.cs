public class cBahnsteuerungssystem 
{
  private cAGV[] AGVs;
  private int agvCount;

  public agvStatus_n getAGVStatus(int agvIndex) 
  {
    return AGVs[agvIndex].getStatus();
  }

  public int getAGVX(int agvIndex) 
  {
    return AGVs[agvIndex].getX();
  }

  public int getAGVY(int agvIndex) 
  {
    return AGVs[agvIndex].getY();
  }

  public int getAGVCount(int agvIndex) 
  {
    return this.agvCount;
  }

  public void removeAGVAuftrag(int agvIndex) 
  {
    AGVs[agvIndex].removeAuftrag();
  }

  public void agvsNavigieren() 
  {
    // TODO Für alle AGVs einmal die navigieren()-Methode aufrufen
  }

  public void verfuegbareAuftraegeZuweisen() 
  {
    // TODO Prüfen ob ein AGV verfügbar ist, wenn ja Auftrag und Landkarte holen und übergeben. 
    //      Statusmeldung dann an Logistiksystem weitergeben mit setAuftragsStatus(auftragsId, auftragStatus_n)
  }
}