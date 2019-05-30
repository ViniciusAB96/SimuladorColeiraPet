using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace SimuladorPET.MongoDAO
{
    /// <summary>
    /// Verificar essa classe depois, talvez tenha algo que não esteja correto.
    /// </summary>
    class MongoDAOSimula
    {
        static MongoClient client = new MongoClient(ConfigurationManager.AppSettings["ConexaoSimulador"]);//conectando ao mongo
        static IMongoDatabase dbDadosPet = client.GetDatabase("DBDadosPet"); //criando a collection DBDadosPet
        static IMongoDatabase dbColeira = client.GetDatabase("DBDadosColeira"); //criando a collection DBDadosColeira
        static IMongoCollection<DadosPet> collectionDadosPet = dbDadosPet.GetCollection<DadosPet>("DadosPet");
        static IMongoCollection<Coleira> collectionColeiras = dbColeira.GetCollection<Coleira>("DadosColeira"); //

        public void AdicionarDadosPet(DadosPet pet)//OK
        {
            collectionDadosPet.InsertOne(pet); //adicionando um novo Pet
        }

        public void AdicionarColeira(Coleira coleira)//OK
        {
            collectionColeiras.InsertOne(coleira);//utilizado para criar as coleiras iniciais.
        }

        public IList<Coleira> BuscarColeiras()//OK
        {
            Expression<Func<Coleira, bool>> filter = x => x.Ativo.Equals(false);

            IList<Coleira> listColeiras = collectionColeiras.Find(filter).ToList();
            return listColeiras;
        }

        public void AtualizaColeira(string codigoColeira, bool estado)
        {
            Expression<Func<Coleira, bool>> filter = x => x.CodigoColeira.Equals(codigoColeira);

            Coleira coleira = collectionColeiras.Find(filter).FirstOrDefault();
            if (coleira != null)
            {
                coleira.Ativo = estado;
                ReplaceOneResult result = collectionColeiras.ReplaceOne(filter, coleira);
            }
        }

        public Coleira BuscarColeira(string codigoColeira)
        {
            Coleira col = new Coleira();
            Expression<Func<Coleira, bool>> filter = x => x.CodigoColeira.Equals(codigoColeira);
            return col = collectionColeiras.Find(filter).FirstOrDefault();
        }
    }
}
