using Models;
using Newtonsoft.Json;

void VerifyDirectory(string path, string file)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    if (!File.Exists(path + file))
    {
        File.Create(path + file).Close();
    }

}

Console.WriteLine( "Inicio do processamento");

string[] colors = new string[] { "Red", "Blue", "Green", "Yellow", "Black", "White", "Silver", "Gray", "Brown", "Orange" };

string[] carNames = new string[] { "Civic", "Accord", "CR-V", "HR-V", "Fit", "City", "Odyssey", "Pilot", "Ridgeline", "Passport" };
string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string numbers = "0123456789";
string[] plates = new string[30];

for (int i = 0; i < 30; i++)
{
    string plate;
    do
    {
        plate = new string(Enumerable.Repeat(letters, 3).Select(s => s[new Random().Next(s.Length)]).ToArray()) + '-' +
        new string(Enumerable.Repeat(numbers, 4).Select(s => s[new Random().Next(s.Length)]).ToArray());

    } while (plates.Contains(plate));
     
    plates[i] = plate;
}

List <Car> lst = new List<Car>();

for (int i = 0; i < 30; i++)
{
    lst.Add(new Car {
        Plate = plates[i],
        Name = carNames[new Random().Next(0, carNames.Length)],
        ModelYear = new Random().Next(2000, 2022),
        ManufactureYear = new Random().Next(2000, 2022),
        Color = colors[new Random().Next(0, colors.Length)]
    });
}

if (lst.Count > 0)
{
    
    string parth = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\DadosGarage/\\";
    string fileName = "garage_data.json";

    VerifyDirectory(parth, fileName);

    string fullPath = parth + fileName;

    StreamWriter sw = new StreamWriter(fullPath);

    sw.Write(JsonConvert.SerializeObject(lst));
    sw.Close();

    Console.WriteLine("Json gerado com sucesso!");

}
else
{
    Console.WriteLine("sem dados");
}
