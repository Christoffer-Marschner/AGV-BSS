using System;

class cAuftrag 
{
  private int id;
  private int[] endPosition = new int[2];
  private auftragStatus_n status;
  private int prioritaet;

  public cAuftrag(int id, int[] endPosition, int prioritaet)
  {
    this.id = id;
    this.endPosition[0] = endPosition[0];
    this.endPosition[1] = endPosition[1];
    this.status = auftragStatus_n.offen;
    this.prioritaet = prioritaet;
  }

  public int getId()
  {
    return id;
  }
  
  public int[] getEndPosition()
  {
    return endPosition;
  }
  
  public auftragStatus_n getStatus()
  {
    return status;
  }
  
  public int getPrioritaet()
  {
    return prioritaet;
  }
  
  public void setStatus(auftragStatus_n neuerStatus)
  {
    status = neuerStatus;
  }
  
}
