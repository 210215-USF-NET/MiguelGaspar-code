using System;

namespace ToHModels
{

    public class Hero
    {
        private string heroName;

        public string HeroName
        {
            get { return heroName; }
            set
            {
                if (value.Equals(null))
                { //TODO: throw exception 
                }
                heroName = value;

            }
        }
        public int HP { get; set; }
        public Element ElementType { get; set; }
        public SuperPower SuperPower { get; set; }
    }
}
