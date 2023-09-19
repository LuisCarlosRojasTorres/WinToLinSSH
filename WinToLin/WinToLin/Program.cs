// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using WinToLin;

Dictionary<string, string> ihmProperties;

using (StreamReader file = File.OpenText(Path.Combine("LinuxDeviceConfig.json")))
{
    ihmProperties = JsonConvert.DeserializeObject<Dictionary<string, string>>(file.ReadToEnd());
    Console.WriteLine("Lobo");
}

