using EV3_Examen_Ejercicio_02.Models;
using System.Text.Json;

namespace EV3_Examen_Ejercicio_02
{
     
    internal class Program
    {
        private static string _jsonPath = Path.Combine(Environment.CurrentDirectory, "Data", "AppConfig.json");

        private static void Main(string[] args)
        {

            string jsonText = File.ReadAllText(_jsonPath);
            ConfigModel config = JsonSerializer.Deserialize<ConfigModel>(jsonText);

            Console.WriteLine(config.Enabled);
            
            Console.WriteLine($"Esta es la Raw {config.RawNextBackup}");
            Console.WriteLine($"Este es el string {config.NextBackup}");


            Console.WriteLine($"Esta es la Raw {config.RawModeForCreatingFiles}");
            Console.WriteLine($"Este es el string {config.ModeForCreatingFiles}");

        }
    }
}