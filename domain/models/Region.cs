using SQLite;

namespace domain.models
{
    [Table("region")]
    public class Region
    {
        string? _name;
        double _lat;
        double _lng;
        int _id;

        WeatherDetails? _townWeatherDetails;

        public double Lat { get => _lat; set => _lat = value; }
        public double Lng { get => _lng; set => _lng = value; }

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get => _id; set => _id = value; }

        [Ignore]
        public WeatherDetails? TownWeatherDetails { get => _townWeatherDetails; set => _townWeatherDetails = value; }
        public string? Name { get => _name; set => _name = value; }

        public Region(string name, double lat, double lng)
        {
            Lat = lat;
            Lng = lng;
            Name = name;
        }

        public Region()
        {

        }
    }
}
