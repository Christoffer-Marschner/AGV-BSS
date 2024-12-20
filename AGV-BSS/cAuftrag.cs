using System;

class cAuftrag 
{
  private int id;
  private int[] endPosition = new int[2];
  private auftragStatus_n status;
  private int pritoritaet;

  public cAuftrag(int inputId, int[] inputEndPosition, int prioritaet)
  {
    id = inputId;
    endPosition[0] = inputEndPosition[0];
    endPosition[1] = inputEndPosition[1];
    status = auftragStatus_n.offen;
    prioritaet = inputPrioritaet;
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
