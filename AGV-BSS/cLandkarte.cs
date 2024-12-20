public class cLandkarte 
{
  private acKartenelement[] karte = [];

  public acKartenelement[] getLandkarte() 
  {
    return karte;
  }

  public void aktualisiereKarte() 
  {
    // TODO Für alle AGVs x,y,status über getAGVX/Y/Status() abrufen und in der Karte speichern. Am Ende karteAnzeigen() aufrufen
  }

  public void landkarteLaden(String karte_csv) 
  {
    // TODO CSV Datei auslesen und in karte speichern
  }
}