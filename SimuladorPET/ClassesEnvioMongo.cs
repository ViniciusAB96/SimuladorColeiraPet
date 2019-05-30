using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace SimuladorPET
{
        public class DadosPet
        {
            //O fornecedor será parte do produto, logo ele não será um documento 
            public ObjectId _id { get; set; }
            public int Temperatura { get; set; }
            public double DistanciaPercorrida { get; set; }
            public double Longitude { get; set; }
            public double Latidude { get; set; }
            public int BatimentosCardiacos { get; set; }
           // public double CaloriasGastas { get; set; }  Não sei como calcular.
            public double LatidosHertz { get; set; }
            public Coleira Coleira { get; set; }
        }
        public class Coleira
        {
            public ObjectId _id { get; set; }//essa informação é gerada automaticamente quando o documento é criado no MongoDAO

            //Geralmente eu crio outro código para identificar o documento, um pouco mais parecido com o relacional, ou seja eu acabo tendo 2 ids, 1 para manter a estrutura do Mongo e outro para que eu mesmo consiga identificar de forma mais fácil, em vez de utilizar o ObjectID do Mongo.
            public string CodigoColeira { get; set; }
            public bool Ativo { get; set; }
        }
}
