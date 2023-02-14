using SQLite;

namespace domain.models
{
    [Table("weather_state")]
    public class WeatherState
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        private long _dt;
       
        private long _sunrise;
        private long _sunset ;
        private double _temp;
        
       private int _pressure;
       private int _humidity;
       private float _dewPoprivate;
       private float _uvi;
       private int _clouds;
       private float _wind_speed;
       private int _wind_deg;
       private int _weatherDetailsId;
     //  private Rain? _rain;
       private double _feels_like;
     //  private IList<Weather>? _weather;
       

        
        public int WeatherDetailsId { get => _weatherDetailsId; set => _weatherDetailsId = value; }
        public int Wind_Deg { get => _wind_deg; set => _wind_deg = value; }
        public float Wind_Speed { get => _wind_speed; set => _wind_speed = value; }
        public int Clouds { get => _clouds; set => _clouds = value; }
        public float Uvi { get => _uvi; set => _uvi = value; }
        public float DewPoprivate { get => _dewPoprivate; set => _dewPoprivate = value; }
        public int Humidity { get => _humidity; set => _humidity = value; }
        public int Pressure { get => _pressure; set => _pressure = value; }
         
        public long Sunset { get => _sunset; set => _sunset = value; }
        public long Sunrise { get => _sunrise; set => _sunrise = value; }
        
       
        public long Dt { get => _dt; set => _dt = value; }
        //  [Ignore]
        //  public IList<Weather>? Weather { get => _weather; set => _weather = value; }
      //  [Ignore]
        public double Temp { get => _temp; set => _temp = value; }
       // [Ignore]
       // public Rain Rain { get => _rain; set => _rain = value; }
       // [Ignore]
       // public long Feels_like { get => _feels_like; set => _feels_like = value; }
    }
}