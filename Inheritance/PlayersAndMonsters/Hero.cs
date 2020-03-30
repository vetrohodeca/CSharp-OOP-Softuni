using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public abstract class Hero
    {
        private int level;
        private string username;
        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }
        public string Username
        {
            get
            {
                return this.username;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username can not be null or whitespace! ");
                }
                else this.username = value;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Level can not be negative number");
                }
                else this.level = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }

    }
}
