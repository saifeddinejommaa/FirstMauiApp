using SQLite;
namespace domain.models
{
    [Table("weather_sequence")]
    public class WeathlySequence
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }

        private int _stateId;
        private float _day;
        private float _min;
        private float _max;
        private float _night;
        private float _eve;
        private float _morn;

        public int StateId { get => _stateId; set => _stateId = value; }
        public float Day { get => _day; set => _day = value; }
        public float Min { get => _min; set => _min = value; }
        public float Max { get => _max; set => _max = value; }
        public float Night { get => _night; set => _night = value; }
        public float Eve { get => _eve; set => _eve = value; }
        public float Morn { get => _morn; set => _morn = value; }
    }
}