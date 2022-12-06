namespace INF272EXAM20221206.OOP_Models
    {
    public class Vampire : Enemy
        {
        private bool _canSeeAtNight;

        public Vampire(double speed, int health, int gems, bool canSeeAtNight) : base(speed, health, gems)
            {
            _canSeeAtNight = canSeeAtNight;
            }

        public override string Stats()
            {
            if (_canSeeAtNight == true)
                {
                return $"Since I can see at night my speed increases by a factor of x2. My stats are: Speed: {speed} X 2 = {speed * 2}, Health: {health}, Gems: {gems}";
                }
            else
                {
                return $"I can't see at night. No increase in stats.  My stats are: {base.Stats()}";
                }
            }

        // Player health is 100
        public override double Damage()
            {
            if (_canSeeAtNight == true)
                {
                return (health * speed) * 1.2;
                }
            else
                {
                return health * speed;
                }
            }
        }
    }