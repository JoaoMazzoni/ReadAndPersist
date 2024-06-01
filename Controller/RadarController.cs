using Model;
using Service;


namespace Controller
{
    public class RadarController
    {
        private RadarService radarService;

        public RadarController()
        {
            radarService = new RadarService();
        }

        public bool TransferirDadosParaMongo()
        {
            Console.WriteLine("\nCamada Controller");
            return radarService.TransferirDadosParaMongo();
        }


    }
}
