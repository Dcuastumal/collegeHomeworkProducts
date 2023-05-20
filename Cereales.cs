using System;

public class Cereales : IEsAlimento
{
    public DateTime fechaCaducidad;
    public int Calorias;
    public string TipoCereal { get; set; }
    public string Marca { get; set; }
    public double Precio { get; set; }


    public Cereales(string marca, double precio, string tipoCereal)
    {
        this.Marca = marca;
        this.Precio = precio;
        this.TipoCereal = tipoCereal;
    }

    public void setCaducidad(DateTime fc)
    {
      fechaCaducidad = fc;
    }
  
    public DateTime getCaducidad()
    {
      return fechaCaducidad;
    }

    public void setCalorias(int c)
    {
        if (TipoCereal == "espelta" || TipoCereal == "Espelta")
        {
          c = 5;
        } else if (TipoCereal == "maiz" || TipoCereal == "Maiz")
        {
          c = 8;
        } else if (TipoCereal == "trigo" || TipoCereal == "Trigo")
        {
          c = 12;
        } else 
        {
          c = 15;
        }
        Calorias = c;
    }
  
    public int getCalorias()
    {
      return Calorias;
    }
    
    public override string ToString()
    {
        return $"Este es un producto {Marca}, \nCalorias: {Calorias}, \nCaducidad: {fechaCaducidad}, \nPrecio: ${Precio},\nDescuento: No tiene,\nValor Final: ${Precio}";
    }


}