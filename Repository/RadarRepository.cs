using Microsoft.Data.SqlClient;
using Model;
using MongoDB.Driver;
using System.Text;


namespace Repository
{
    public class RadarRepository
    {
        static string sqlConnectionString = "Server=127.0.0.1; Database=DBRadar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        static string mongoConnectionString = "mongodb://root:Mongo%402024%23@localhost:27017";
        static string mongoDatabaseName = "DBRadar";
        static string mongoCollectionName = "Radar";
        SqlConnection conn;

        public RadarRepository()
        {

        }

        public bool TransferirDadosParaMongo()
        {
            try
            {
                Console.WriteLine("Camada Repository");
                var mongoClient = new MongoClient(mongoConnectionString);
                var mongoDatabase = mongoClient.GetDatabase(mongoDatabaseName);
                var mongoCollection = mongoDatabase.GetCollection<Radar>(mongoCollectionName);

                using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
                {
                    sqlConnection.Open();
      
                    using (SqlCommand sqlCommand = new SqlCommand(Radar.SELECT, sqlConnection))
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var radar = new Radar
                            {
                                Concessionaria = reader["Concessionaria"].ToString(),
                                AnoDoPnvSnv = reader["AnoDoPnvSnv"].ToString(),
                                TipoDeRadar = reader["TipoDeRadar"].ToString(),
                                Rodovia = reader["Rodovia"].ToString(),
                                Uf = reader["Uf"].ToString(),
                                KmM = reader["KmM"].ToString(),
                                Municipio = reader["Municipio"].ToString(),
                                TipoPista = reader["TipoPista"].ToString(),
                                Sentido = reader["Sentido"].ToString(),
                                Situacao = reader["Situacao"].ToString(),
                                DataDaInativacao = reader["DataDaInativacao"].ToString().Split(',').ToList(),
                                Latitude = reader["Latitude"].ToString(),
                                Longitude = reader["Longitude"].ToString(),
                                VelocidadeLeve = reader["VelocidadeLeve"].ToString()
                            };

                            mongoCollection.InsertOne(radar);
                        }
                    }
                }

                Console.WriteLine("Dados transferidos para o MongoDB com sucesso.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro durante a transferência de dados para o MongoDB: {ex.Message}");
                return false;
            }
        }


        
    }
}

