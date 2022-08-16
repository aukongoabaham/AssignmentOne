using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2_ass1_
{
    internal class Container
    {
        private string colour;
        private string shape;
        private double volume;

        public Container(string colour, string shape, double volume)
        {
            this.colour= colour;
            this.shape= shape;
            this.volume= volume;
            
        }

        public Container(string colour, double volume, string shape)
        {
            this.colour = colour;
            this.volume = volume;
            this.shape = shape;
        }

        public string getColour()
        {
            return colour;
        }
        public double getVolume()
        {
            return volume;
        }
        public string getShape()
        {
            return shape;
        }
    }   
}
