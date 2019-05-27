using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPET.DadosEnvio
{
    class DistanciaPercorrida
    {
        //sempre [0] ==> Latitude
        //       [1] ==> Longitude

        const int RAIODATERRA = 6371; //Raio da Terra em m 6371km = 6371000 m
        const double CONSTANTERADIANOS = Math.PI / 180;
        const double FATORDEARREDONDAMENTO = 1.07;
        public List<double> CoordenadaAnterior = new List<double>();
        private double distanciaPercorrida { get; set; }

        /* public double Distancia
         {
             get { return distanciaPercorrida; }
         }*/

        public double CalcularDistanciaPercorrida(List<double> novaCoordenada)
        {
            if (novaCoordenada.Count != 0)
            {
                if (CoordenadaAnterior.Count == 0)
                {                    
                    distanciaPercorrida = 0;
                    CoordenadaAnterior.AddRange(novaCoordenada);
                }
                else if(!CoordenadaAnterior.Contains(novaCoordenada[0]) || !CoordenadaAnterior.Contains(novaCoordenada[1]))
                {
                    double primeiraLatitudeEmRadianos = (90 - CoordenadaAnterior[0]) * CONSTANTERADIANOS;
                    double segundaLatitudeEmRadianos = (90 - novaCoordenada[0]) * CONSTANTERADIANOS;
                    double radianosLongitude = (CoordenadaAnterior[1] - novaCoordenada[1]) * CONSTANTERADIANOS;

                    //fórmula para calcular a distancia percorrida conforme a geoLocalização
                    distanciaPercorrida += Math.Round((RAIODATERRA * Math.Acos(Math.Cos(primeiraLatitudeEmRadianos) * Math.Cos(segundaLatitudeEmRadianos) + Math.Sin(primeiraLatitudeEmRadianos) * Math.Sin(segundaLatitudeEmRadianos) * Math.Cos(radianosLongitude)) )*1000, 8); //estou arredondando para 2 casas decimais a distancia percorrida.

                    CoordenadaAnterior.Clear();
                    CoordenadaAnterior.InsertRange(0, novaCoordenada);
                }
                return distanciaPercorrida;
            }
            else
            {
                return distanciaPercorrida;
            }
        }

        /*  public DistanciaPercorrida(List<double> CoordenadaInit)
          {
              CoordenadaAnterior = CoordenadaInit;
          }*/
    }
}
