using System.IO;
using System.Text.Json;
using ReadFile.Entity;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("            Lista de clientes");
        Console.WriteLine("---------------------------------------");
        LerArquivos(1);

    }
    private static void LerArquivos(int numeroArquivo)
    {

        var path = @$"C:\Users\I\source\repos\ReadFile\ReadFile\imports\cliente{numeroArquivo}.json";

        if (File.Exists(path))
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var cliente = JsonSerializer.Deserialize<Cliente>(json);
                Console.WriteLine($"Nome: {cliente.nome} ||| Telefone: {cliente.telefone}");
                Console.WriteLine("---------------------------------------");
            }
        }
         path = @$"C:\Users\I\source\repos\ReadFile\ReadFile\imports\cliente{numeroArquivo + 1}.json";
        if (File.Exists(path))
        {
            LerArquivos(numeroArquivo + 1);
        }
    }

//    var path = @"C:\Users\I\source\repos\ReadFile\ReadFile\imports\cliente1.json";

//    List<Cliente> clientes = new List<Cliente>();

//        for(var i = 2; i <= 6; i++)
//        {
//        using (StreamReader r = new StreamReader(path))
//        {
//            string json = r.ReadToEnd();
//    var cliente = JsonSerializer.Deserialize<Cliente>(json);
//    clientes.Add(cliente);
//        }
//path = @$"C:\Users\I\source\repos\ReadFile\ReadFile\imports\cliente{i}.json";
//        }
//            foreach (var cliente in clientes)
//{
//    Console.WriteLine($"Nome: {cliente.nome} ||| Telefone: {cliente.telefone}");
//    Console.WriteLine("----------------------------------------------------");
//}
        
}