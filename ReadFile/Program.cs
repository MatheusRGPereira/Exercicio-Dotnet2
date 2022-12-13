

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ReadFile.Entity;

internal class Program
{
    private static void Main(string[] args)
    {

        var path = @"C:\Users\I\source\repos\ReadFile\ReadFile\imports\cliente1.json";

        List<Cliente>clientes = new List<Cliente>();

        for(var i = 2; i <= 6; i++)
        {
        using (StreamReader r = new StreamReader(path))
        {
            string json = r.ReadToEnd();
            var cliente = JsonSerializer.Deserialize<Cliente>(json);
                clientes.Add(cliente);
        }
            path = @$"C:\Users\I\source\repos\ReadFile\ReadFile\imports\cliente{i}.json";
        }
            foreach(var cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.nome} ||| Telefone: {cliente.telefone}");
                Console.WriteLine("----------------------------------------------------");
            }
        


    }
}