using System;

public class Vino : IEsLiquido, IConDescuento
{
    private double Descuento;
    public double Volumen = 0;
    public string Envase = string.Empty;
    public string TipoVino { get; set; }
    public double Grados { get; set; }
    public string Marca { get; set; }
    public double Precio { get; set; }


    public Vino(string marca, double precio, string tipoVino, double grados)
    {
        this.Marca = marca;
        this.TipoVino = tipoVino;
        this.Precio = precio;
        this.Grados = grados;    
    }

    public void setDescuento(double des)
    {
        Descuento = des;
    }

    public double getDescuento()
    {
        return Descuento;
    }

    public double getPrecioDescuento()
    {
        return Precio - (Precio * Descuento / 100);
    }

    public void setVolumen(double vol)
    {
        Volumen = vol;
    }

    public double getVolumen()
    {
        return Volumen;
    }

    public void setTipoEnvase(string env)
    {
        Envase = env;
    }

    public string getTipoEnvase()
    {
        return Envase;
    }

    public double getCaloriasTotales()
    {
        return (Grados * 10);
    }

    public override string ToString()
    {
        return $"Este es un producto {Marca}, \nTipo de Vino: {TipoVino},  \nGrados de Alcohol: {Grados}% vol ,\nCalorias: {getCaloriasTotales()}, \nVolumen: {Volumen}CC, \nTipo de Envase: {Envase} \nPrecio: ${Precio},\nDescuento: ${Descuento}, \nValor Final: ${getPrecioDescuento()}";
    }
}