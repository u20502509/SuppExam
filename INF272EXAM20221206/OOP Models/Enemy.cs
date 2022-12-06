namespace INF272EXAM20221206.OOP_Models
    {
    public abstract class Enemy
        {
        // Complete the details below. Please refer to the sample output to note the required details.
        // Take note of the relationships as found in the provided class diagram.
        // Take note of the base classes and how the overrides function in the base classes.
        // Details from the base classes will inform you as to the structure, sequence, properties etc of this abstract class.
        // Take note – the player health starts out as 100.
        // ------------------------------------------------------------------------------------------

        public int _health { get; set; } = 100;
        public double _speed { get; set; }

        public int _gems { get; set; }


        public Enemy()
        {

        }


        public Enemy(int Health, double Speed, int Gems )
        {
            _health = Health;
            _speed = Speed;
            _gems = Gems;
        }

        public abstract string Damage()
        {

        }

        public abstract string Stats()
        {

        }



    }
    }