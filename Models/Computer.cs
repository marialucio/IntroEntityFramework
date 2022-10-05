namespace IntroEntityFramework.Models;

public class Computer
{
    public int Id { get; set; }
    public string Ram { get; set; }
    public string Processador { get; set; }

    public Computer() {}
    public Computer(int id, string ram, string processador)
    {
        Id = id;
        Ram = ram;
        Processador = processador;
    }
}