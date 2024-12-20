using System;

class cAuftrag 
{
  private int id;
  private int[] endPosition = new int[2];
  private auftragStatus_n status;
  private int pritoritaet;

  public cAuftrag(int Id, int[] EndPosition, int prioritaet)
  {
    this.id = Id;
    this.endPosition[0] = EndPosition[0];
    this.endPosition[1] = EndPosition[1];
    this.status = auftragStatus_n.offen;
    this.prioritaet = Prioritaet;
  }

  public int getId()
  {
    return id;
  }
  
  public int getEndPosition()
  {
    return endPosition;
  }
  
  public auftragStatus_n getStatus()
  {
    return status;
  }
  
  public int getPrioritaet()
  {
    return priotitaet;
  }
  
  public void setStatus(auftragStatus_n neuerStatus)
  {
    status = neuerStatus;
  }
  
}
