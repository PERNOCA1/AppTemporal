using System;
using System.Collections.Generic;
using System.Text;

namespace AppTemporal.Model
{
    class Tempo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }


        public Tempo()
        {
            this.Title = " ";
            this.Description = " ";
            this.Temperature = " ";
            this.Wind = " ";
            this.Humidity = " ";
            this.Visibility = " ";
            this.Sunrise = "";
            this.Sunset = " ";
        }
    }
}
