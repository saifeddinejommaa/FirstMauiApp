using Newtonsoft.Json;
using SQLite;

namespace domain.models
{
    [Table("weather_details")]
    public class WeatherDetails
    {
      
        int _id;
        int _regionId;
        double _lat;
        double _lng;
        string _timezone;

        
        int _timezone_offset;
        
        WeatherState? _current;
        IList<WeatherState>? _minutely;
        IList<WeatherState>? _daily;
        IList<WeatherState>? _hourly;
        

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get => _id; set => _id = value; }
        public int regionId { get => _regionId; set => _regionId = value; }
        public double Lat { get => _lat; set => _lat = value; }
        public double Lng { get => _lng; set => _lng   = value; }
        public string Timezone { get => _timezone; set => _timezone = value; }

        
        public int Timezone_Offset { get => _timezone_offset; set => _timezone_offset = value; }
        
       [Ignore]
       [JsonProperty("current")]
       public WeatherState Current { get => _current; set => _current = value; }
        /*
       [Ignore]
       public IList<WeatherState>? Minutely { get => _minutely; set => _minutely = value; }
       [Ignore]
       public IList<WeatherState>? Daily { get => _daily; set => _daily = value; }
       [Ignore]
       public IList<WeatherState> Hourly { get => _hourly; set => _hourly = value; }
       */
    }
}
