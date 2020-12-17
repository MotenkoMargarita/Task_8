using System;
using System.Linq;

namespace sharp_3
{
    public class Cosmonaut
    {
        public string Name { get; set; }

        public static Cosmonaut GetCosmonaut()
        {
            return new Cosmonaut() { Name =  string.Join("", Enumerable.Range(1, 6).Select(x => Rocket.random.Next(64, 90)).Select(x => (char)x))};
        }
    }
}