using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppTemporal.Model;

namespace AppTemporal.Services
{
    class DataService
    {
        public static async Task<Tempo> GetPrevisaoDoTempo(string cidade)
        {
            string appId = "6bc9fdf60e7df1500cab1643db19a682";

            string queryString = "https://home.openweathermap.org/api_keys" + cidade + "&units=metric" + "&appid=" + appId;
            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            if (resultado["weather"] != null)
            {
                Tempo previsao = new Tempo();
                previsao.Title = (string)resultado["name"];
                previsao.Temperature = (string)resultado["main"]["temp"] + " C";
                previsao.Wind = (string)resultado["wind"]["speed"] + " mph";
                previsao.Humidity = (string)resultado["main"]["humidity"] + " %";
                previsao.Visibility = (string)resultado["weather"][0]["main"] + " C";
                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0 );
                DateTime sunrise = time.AddSeconds((double)resultado["sys"]["sunrise"]);


            }
        }

    }
}
