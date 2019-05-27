using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson;

namespace SimuladorPET.MongoDAO
{
    /// <summary>
    /// Verificar essa classe depois, talvez tenha algo que não esteja correto.
    /// </summary>
    class MongoDB
    {
        static MongoClient client = new MongoClient(ConfigurationManager.AppSettings["ConexaoSimulador"]);//conectando ao mongo
        static IMongoDatabase dbDadosPet = client.GetDatabase("DBDadosPet"); //criando a collection DBDadosPet
        static IMongoDatabase dbColeira = client.GetDatabase("DBDadosColeira"); //criando a collection DBDadosColeira
        static IMongoCollection<Coleira> collectionColeiras = dbColeira.GetCollection<Coleira>("DadosColeira"); //
        public void AdicionarDadosPet(DadosPet pet)
        {
            var petsData = dbDadosPet.GetCollection<DadosPet>("DadosPet");
            petsData.InsertOne(pet);
        }
        public void BuscarDadosColeira(Coleira coleira)
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["ConexaoSimulador"]);
            var coleiraData = dbColeira.GetCollection<Coleira>("DadosColeira");
            // coleiraData.Find()
           
        }
        public List<Coleira> BuscarColeiras()
        {
            //retornando todas as coleiras.
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["ConexaoSimulador"]);
            IMongoDatabase db = client.GetDatabase("DBDadosPet");
           

            List<Coleira> listColeiras = collectionColeiras.AsQueryable().ToList<Coleira>();
            return listColeiras;
        }

        public void AtualizaColeira(ObjectId _idColeira, bool estado)
        {
            var updateDef = Builders<Coleira>.Update.Set("Ativo", estado);
            collectionColeiras.UpdateOne(coleira => coleira._id == _idColeira, updateDef);
            
        }
    }
}
