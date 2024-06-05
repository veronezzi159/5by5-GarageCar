using Services;
namespace Controllers
{
    public class CarController
    {
        CarService CarService;
        public CarController()
        {
            CarService = new CarService();
        }

        public void GenerateXmlRed()
        {
            int op = 1; 
            var lst = CarService.GetAllRed();
            Console.WriteLine(CarService.GenerateXml(lst, op)? "Xml de carros gerado com sucesso" : "Xml de servicos nao gerado");
        }
        public void GenerateSpecYearXml()
        {
            int op = 2; 
            var lst = CarService.GetSpecYear();
            Console.WriteLine(CarService.GenerateXml(lst, op)? "Xml de carros gerado com sucesso" : "Xml de servicos nao gerado");
        }
    }
}
