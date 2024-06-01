using System.Text;

namespace Model
{
    public class Radar
    {

        public static readonly string SELECT = "SELECT Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve FROM Radar";

        public string Concessionaria { get; set; }
        public string AnoDoPnvSnv { get; set; }
        public string TipoDeRadar { get; set; }
        public string Rodovia { get; set; }
        public string Uf { get; set; }
        public string KmM { get; set; }
        public string Municipio { get; set; }
        public string TipoPista { get; set; }
        public string Sentido { get; set; }
        public string Situacao { get; set; }
        public List<string> DataDaInativacao { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string VelocidadeLeve { get; set; }
        public string DataDaInativacaoString => DataDaInativacao != null ? string.Join(",", DataDaInativacao) : null;


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Concessionaria: {Concessionaria}");
            sb.AppendLine($"Ano do PNV/SNV: {AnoDoPnvSnv}");
            sb.AppendLine($"Tipo de Radar: {TipoDeRadar}");
            sb.AppendLine($"Rodovia: {Rodovia}");
            sb.AppendLine($"UF: {Uf}");
            sb.AppendLine($"KM/M: {KmM}");
            sb.AppendLine($"Municipio: {Municipio}");
            sb.AppendLine($"Tipo de Pista: {TipoPista}");
            sb.AppendLine($"Sentido: {Sentido}");
            sb.AppendLine($"Situação: {Situacao}");
            sb.AppendLine($"Data da Inativação: {DataDaInativacao}");
            sb.AppendLine($"Latitude: {Latitude}");
            sb.AppendLine($"Longitude: {Longitude}");
            sb.AppendLine($"Velocidade Leve: {VelocidadeLeve}");
            return sb.ToString();
        }
    }
}
