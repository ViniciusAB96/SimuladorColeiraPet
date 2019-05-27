using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorPET.DadosEnvio;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace SimuladorPET
{
    public partial class Simulador : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        private double distanciaTotal = 0;
        private GeoLocalizacao geo = new GeoLocalizacao();
        private DistanciaPercorrida distancia = new DistanciaPercorrida();
        private List<Double> novasCoordenadas = new List<double>();

        public Simulador()
        {
            InitializeComponent();

            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.CanDragMap = true;
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 18;
            gMapControl.AutoScroll = true;

            labelTemp.Text = tempBar.Value.ToString();
            labelBatmCard.Text = batmCardBar.Value.ToString();
            //iniciando a primeira leitura da localização do device
            //essa primeira leitura é necessária pois caso contrário eu não consigo ler a mudança dela.

            List<Double> primeirasCoordenadas = geo.Lacalizacao();
            distanciaTotal = distancia.CalcularDistanciaPercorrida(primeirasCoordenadas);
            TimerAplicacao.Start();
        }


        private void TimerAplicacao_Tick(object sender, EventArgs e)
        {
           // novasCoordenadas.Clear();
            novasCoordenadas =  geo.Lacalizacao();
         
            distanciaTotal = distancia.CalcularDistanciaPercorrida(novasCoordenadas);
            if(novasCoordenadas.Count != 0)
            {
                gMapControl.Position = new PointLatLng(novasCoordenadas[0], novasCoordenadas[1]);
                gMapControl.Overlays.Clear();

                //Marcador no mapa
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(gMapControl.Position, GMarkerGoogleType.blue_dot);
                markerOverlay.Markers.Add(marker);//Estou juntando o marcador do google ao mapa

                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Localidade: \n Latitude: {0} \n Longitude: {1}", novasCoordenadas[0].ToString(), novasCoordenadas[1].ToString());
                textDistancia.Text = distanciaTotal.ToString();
                gMapControl.Overlays.Add(markerOverlay);

                //MessageBox.Show("Latitude" + novasCoordenadas[0].ToString() + Environment.NewLine + "Longitude" + novasCoordenadas[1].ToString() + Environment.NewLine + "Distancia: "+ distanciaTotal.ToString());
            }
          // MessageBox.Show("Latitude" + novasCoordenadas[0].ToString() + Environment.NewLine + "Longitude" + novasCoordenadas[1].ToString() + distanciaTotal.ToString());

        }

        private void batmCardBar_Scroll(object sender, EventArgs e)
        {
            labelBatmCard.Text = batmCardBar.Value.ToString();
        }

        private void tempBar_Scroll(object sender, EventArgs e)
        {
            labelTemp.Text = tempBar.Value.ToString();
        }
    }
}
