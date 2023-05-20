public class Detergente : IConDescuento
{
    private double descuento;
    public double volumen = 0;
    public string envase = string.Empty;
    public string Marca { get; set; }
    public double Precio { get; set; }


    public Detergente(string marca, double precio)
    {
        this.Marca = marca;
        this.Precio = precio;
    }

    public void setDescuento(double des)
    {
        descuento = des;
    }

    public double getDescuento()
    {
        return descuento;
    }

    public double getPrecioDescuento()
    {
        return Precio - (Precio * descuento / 100);
    }

    public void setVolumen(double vol)
    {
        volumen = vol;
    }

    public double getVolumen()
    {
        return volumen;
    }

    public void setTipoEnvase(string env)
    {
        envase = env;
    }

    public string getTipoEnvase()
    {
        return envase;
    }

    public override string ToString()
    {
        return $"Este es un producto {Marca},\nPrecio: ${Precio},\nDescuento: {descuento}%,\nvalor Final ${getPrecioDescuento()},\nVolumen: {volumen}CC,\nTipo de Envase: {envase}";
    }

}