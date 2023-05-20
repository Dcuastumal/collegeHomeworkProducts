using System;

class Program
{
    public static void Main(string[] args)
    {
        var jabonPompita = new Detergente("Pompita", 200);
        jabonPompita.setDescuento(15);
        jabonPompita.setTipoEnvase("Botella");
        jabonPompita.setVolumen(580);
        Console.WriteLine(jabonPompita);

        Console.WriteLine(" ");
        Console.WriteLine("================================");
        Console.WriteLine(" ");

        var cereal = new Cereales("Quaker", 55, "Maiz");
        cereal.setCaducidad(new DateTime(2023, 12, 31));
        cereal.setCalorias(145);
        Console.WriteLine(cereal);

        Console.WriteLine(" ");
        Console.WriteLine("================================");
        Console.WriteLine(" ");

        var vinito = new Vino("Catena", 7480, "Malbec", 14.5);
        vinito.setDescuento(15);
        vinito.setVolumen(3);
        vinito.setTipoEnvase("Botella de Vidrio");
        Console.WriteLine(vinito);
    }
}