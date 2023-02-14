using SQLite;

namespace domain.models
{
    [Table("rain")]
    public class Rain
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        private int _stateId;
        private float _oneOur;

        public int StateId { get => _stateId; set => _stateId = value; }
        public float OneOur { get => _oneOur; set => _oneOur = value; }
    }
}