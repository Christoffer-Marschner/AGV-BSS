using System;

class cLogistiksystem 
{
  private cAuftrag[] auftragsListe = new cAuftrag[];

  public cAuftrag getAuftrag()
  {
    // TODO loop durch alle aufträge und gib den mit der höchsten prio zurück
  }
  
  public void addAuftrag(cAuftrag neuerAuftrag)
  {
    // TODO auftrag an die liste anhängen
  }
  
  public void deleteAuftrag(int auftragsId)
  {
    // TODO auftrag an einer id entfernen
  }
  
  public void setAuftragStatus(int auftragsId, int neuerStatus)
  {
    // TODO loop durch alle aufträge bis die id gefunden wird, dann wird der status gesetzt
  }
  
}
