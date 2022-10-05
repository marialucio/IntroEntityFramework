using IntroEntityFramework.Models;

Console.WriteLine("Hello, World!");

SystemContext context = new SystemContext();

context.Database.EnsureCreated();

// Criar ('C'RUD)
// Computer c1 = new Computer(1, "16gb", "intel");
// context.Computers.Add(c1);
// context.SaveChanges();

// Computer c2 = new Computer(2, "6gb", "intel");
// context.Computers.Add(c2);
// context.SaveChanges();

// Computer c3 = new Computer(3, "4gb", "intel");
// context.Computers.Add(c3);
// context.SaveChanges();

// Ler (C'R'UD)
IEnumerable<Computer> computers = context.Computers.ToList();

foreach (var comp in computers)
{
    Console.WriteLine($"{comp.Id}, {comp.Ram}, {comp.Processador}");
}

//Ler (C'R'UD)
Computer encontrado = context.Computers.Find(3);
Console.WriteLine($"Encontrado com id 3: {encontrado.Ram}, {encontrado.Processador}");

//Atualizar (CR'U'D)
encontrado.Ram = "10gb";
encontrado.Processador = "amd";
context.Computers.Update(encontrado);
context.SaveChanges();

Computer atualizado = context.Computers.Find(3);
Console.WriteLine($"Encontrado com id 3: {atualizado.Ram}, {atualizado.Processador}");

//Remover (CRU'D')
context.Computers.Remove(atualizado);
context.SaveChanges();

