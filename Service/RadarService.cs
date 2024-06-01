using Model;
using Repository;

namespace Service
{
    public class RadarService
    {
        private RadarRepository radarRepository;

        public RadarService()
        {
            radarRepository = new RadarRepository();
        }

        public bool TransferirDadosParaMongo()
        {
            Console.WriteLine("Camada Service");
            return radarRepository.TransferirDadosParaMongo();
        }




    }
}
