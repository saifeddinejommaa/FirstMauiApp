using SQLite;

namespace domain.models
{
    [Table("weather")]
    public class Weather
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        private  string _main;
        private string _description;
        private string _icon;

        public string Main { get => _main; set => _main = value; }
        public string Description { get => _description; set => _description = value; }

        public string Icon { get => _icon; set => _icon = value; }
      
    }
}