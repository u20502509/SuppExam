using System;

namespace INF272EXAM20221206.OOP_Models
    {
    public class Werewolf : Enemy
        {
        private DateTime _dateOfNextTurning;

        public Werewolf(double speed, int health, int gems, DateTime dateOfNextTurning) : base(speed, health, gems)
            {
            _dateOfNextTurning = dateOfNextTurning;
            }

        public override string Stats()
            {
            if (_dateOfNextTurning.AddDays(1).Date == DateTime.Now.AddDays(1).Date)
                {
                return $"I am turning tomorrow. My stats are: Speed: {speed}, Health: {health} X 2 = {health * 2}, Gems: {gems}";
                }
            else
                {
                return $"I am not turning tomorrow.  My stats are: {base.Stats()}";
                }
            }

        // Player health is 100
        public override double Damage()
            {
            if (_dateOfNextTurning.AddDays(1).Date == DateTime.Now.AddDays(1).Date)
                {
                return (health * speed) * 1.3;
                }
            else
                {
                return health * speed;
                }
            }
        }
    }