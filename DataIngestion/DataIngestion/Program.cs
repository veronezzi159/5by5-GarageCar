using Models;
using Controllers;

string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\DadosGarage/\\";
string file = "garage_data.json";

var cars = new ReadFile().GetData(path, file);

Console.WriteLine(new CarController().Insert(cars) ? "Inseridos no Banco com sucesso" : "Nao foi possivel inserir" );
