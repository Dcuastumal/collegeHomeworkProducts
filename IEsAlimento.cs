using System;

public interface IEsAlimento
{
    public void setCaducidad(DateTime fc);
    public DateTime getCaducidad();
    public int getCalorias();
}
