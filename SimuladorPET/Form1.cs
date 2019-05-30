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
using SimuladorPET.MongoDAO;

namespace SimuladorPET
{
    public partial class Simulador : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        private double distanciaTotal = 0;
        private double latidosHz = 0;
        private int temperatura = 36;
        private int batimentosCardiaco = 100;
        private string codigoColeiraSelecionado;
        private GeoLocalizacao geo = new GeoLocalizacao();
        private DistanciaPercorrida distancia = new DistanciaPercorrida();
        private List<Double> novasCoordenadas = new List<double>();
        private List<Double> coordenadasAnterior = new List<double>();
        public Simulador()
        {
            InitializeComponent();

            btnDesligar.Visible = false;


            //Coleiras exemplo.
            /*MongoDAOSimula mongoSimula = new MongoDAOSimula();
            Coleira coleira = new Coleira();
            coleira.CodigoColeira = "COL9842";
            coleira.Ativo = false;
            mongoSimula.AdicionarColeira(coleira);
            
            Coleira coleira2 = new Coleira();
            coleira2.CodigoColeira = "COL8450";
            coleira2.Ativo = false;
            mongoSimula.AdicionarColeira(coleira2);

            Coleira coleira3 = new Coleira();
            coleira3.CodigoColeira = "COLBacana";
            coleira3.Ativo = true;
            mongoSimula.AdicionarColeira(coleira3);*/

            PopulaComboBoxColeira();

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

            coordenadasAnterior = geo.Lacalizacao();
            distanciaTotal = distancia.CalcularDistanciaPercorrida(coordenadasAnterior);

        }


        private void TimerAplicacao_Tick(object sender, EventArgs e)
        {
            // novasCoordenadas.Clear();
            novasCoordenadas = geo.Lacalizacao();

            distanciaTotal = distancia.CalcularDistanciaPercorrida(novasCoordenadas);
            if (novasCoordenadas.Count != 0)
            {
                if (!(coordenadasAnterior.Contains(novasCoordenadas[0]) && coordenadasAnterior.Contains(novasCoordenadas[1])));
                {
                    gMapControl.Position = new PointLatLng(novasCoordenadas[0], novasCoordenadas[1]);
                    gMapControl.Overlays.Clear();

                    //Marcador no mapa
                    markerOverlay = new GMapOverlay("Marcador");
                    marker = new GMarkerGoogle(gMapControl.Position, GMarkerGoogleType.blue_dot);
                    markerOverlay.Markers.Add(marker);//Estou juntando o marcador do google ao mapa

                    marker.ToolTipMode = MarkerTooltipMode.Always;
                    marker.ToolTipText = string.Format("Localidade: \n Latitude: {0} \n Longitude: {1}", novasCoordenadas[0].ToString(), novasCoordenadas[1].ToString());
                    textDistancia.Text = string.Format("{0} m", distanciaTotal.ToString());
                    gMapControl.Overlays.Add(markerOverlay);

                    GravaDadorPet(this.temperatura, this.distanciaTotal, this.novasCoordenadas[0], this.novasCoordenadas[1], this.batimentosCardiaco, this.latidosHz, this.codigoColeiraSelecionado);
                }
            }
        }

        private void batmCardBar_Scroll(object sender, EventArgs e)
        {
            if (TimerAplicacao.Enabled == true)
            {
                batimentosCardiaco = batmCardBar.Value;
                labelBatmCard.Text = temperatura.ToString();
                GravaDadorPet(this.temperatura, this.distanciaTotal, this.novasCoordenadas[0], this.novasCoordenadas[1], this.batimentosCardiaco, this.latidosHz, this.codigoColeiraSelecionado);
            }

        }

        private void tempBar_Scroll(object sender, EventArgs e)
        {
            if (TimerAplicacao.Enabled == true)
            {
                temperatura = tempBar.Value;
                labelTemp.Text = batimentosCardiaco.ToString();
                GravaDadorPet(this.temperatura, this.distanciaTotal, this.novasCoordenadas[0], this.novasCoordenadas[1], this.batimentosCardiaco, this.latidosHz, this.codigoColeiraSelecionado);
            }
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && comboColeiras.SelectedIndex != 0)
            {
                MongoDAOSimula mongoSimula = new MongoDAOSimula();

                btnDesligar.Location = btnLigar.Location;
                btnLigar.Visible = false;
                btnDesligar.Visible = true;
                comboColeiras.Enabled = false;
                mongoSimula.AtualizaColeira(codigoColeiraSelecionado, true);
                TimerAplicacao.Start();
            }
            else
            {
                MessageBox.Show("Verifique o combobox", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.None);

            TimerAplicacao.Stop();
            MongoDAOSimula mongoSimula = new MongoDAOSimula();
            mongoSimula.AtualizaColeira(codigoColeiraSelecionado, false);

            comboColeiras.Items.Clear();
            PopulaComboBoxColeira();
            comboColeiras.SelectedIndex = 0;

            codigoColeiraSelecionado = "";
            //atribuir os outros campos...
            btnDesligar.Location = btnLigar.Location;
            btnDesligar.Visible = false;
            btnLigar.Visible = true;
            comboColeiras.Enabled = true;

        }

        private void PopulaComboBoxColeira()
        {
            comboColeiras.Items.Add("Escolha uma coleira");
            MongoDAOSimula mongoSimula = new MongoDAOSimula();
            IList<Coleira> coleiras = mongoSimula.BuscarColeiras();
            foreach (Coleira coleira in coleiras)
            {
                comboColeiras.Items.Add(coleira.CodigoColeira);
            }
        }

        private void comboColeiras_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(codigoColeiraSelecionado))
            {
                e.Cancel = true;
                errorProvider.SetError(comboColeiras, "A coleira não foi selecionada.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(comboColeiras, null);
            }
        }

        private void comboColeiras_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoColeiraSelecionado = comboColeiras.SelectedItem.ToString();
        }

        private void Simulador_FormClosing(object sender, FormClosingEventArgs e)
        {
            ValidateChildren(ValidationConstraints.None);
            e.Cancel = false;
            if (TimerAplicacao.Enabled == true && this.novasCoordenadas.Count != 0)
            {
                GravaDadorPet(this.temperatura, this.distanciaTotal, this.novasCoordenadas[0], this.novasCoordenadas[1], this.batimentosCardiaco, this.latidosHz, this.codigoColeiraSelecionado);
            }
            MongoDAOSimula mongoSimula = new MongoDAOSimula();
            mongoSimula.AtualizaColeira(codigoColeiraSelecionado, false);
        }

        private void GravaDadorPet(int temp, double distanciaPerc, double latitude, double longitude, int batimentosCardi, double latidosHertz, string codigoColeira)
        {
            DadosPet dadosPet = new DadosPet();
            dadosPet.Temperatura = temp;
            dadosPet.DistanciaPercorrida = distanciaPerc;
            dadosPet.Latidude = latitude;
            dadosPet.Longitude = longitude;
            dadosPet.BatimentosCardiacos = batimentosCardi;
            dadosPet.LatidosHertz = latidosHertz;

            MongoDAOSimula mongoSimula = new MongoDAOSimula();
            dadosPet.Coleira = mongoSimula.BuscarColeira(codigoColeira);
            mongoSimula.AdicionarDadosPet(dadosPet);
        }
    }
}
