
using Controller;

Console.WriteLine("Iniciando Transferência de Dados do SQL para o Mongo");

RadarController controller = new RadarController();

controller.TransferirDadosParaMongo();

