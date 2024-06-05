using Controllerss;

CarController carController = new CarController();
CarServiceController carServiceController = new CarServiceController();
ServiceController serviceController = new ServiceController();
//string carPlate = carController.Insert();
//if (carPlate != null) Console.WriteLine($"Carro de placa: {carPlate}");
//    else Console.WriteLine("Erro ao inserir carro");

//carController.GetAll();

//serviceController.Insert();
//serviceController.GetAll();

//carServiceController.Insert();
carServiceController.Update();
