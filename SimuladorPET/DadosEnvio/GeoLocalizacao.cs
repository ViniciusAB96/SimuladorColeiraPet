using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace SimuladorPET.DadosEnvio
{
    class GeoLocalizacao
    {
        private static List<Double> Location = new List<double>();


        public List<Double> Lacalizacao()
        {

            GeoCoordinateWatcher _watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
           // _watcher.Start();
            // 
            _watcher.TryStart(true, TimeSpan.FromMilliseconds(600));

            _watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(LocationWatcher_PositionChanged);


            //Console.WriteLine(_watcher.Position.Location.Latitude.ToString());
            // Console.WriteLine(coord.Longitude.ToString());

            return Location;
        }

        static void LocationWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            
            if (e.Position.Location != GeoCoordinate.Unknown)
            {
                
                //Console.WriteLine((sender as GeoCoordinateWatcher).MovementThreshold);

                Location.Clear();
                Location.Add(e.Position.Location.Latitude);//[0] Latitude
                Location.Add(e.Position.Location.Longitude);//[1] Longitude
                return;               
            }

        }

    }
}
