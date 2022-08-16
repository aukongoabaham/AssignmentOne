using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2_ass1_
{
    internal class Rectangular : Container
    {
        public Rectangular(string colour, double volume, string shape) : base(colour, volume, shape)
        {
            string [] recContainer = new recContainer [100];  
            double [] volumes = new volumes [recContainer.Length];
            int count = -1;
            
             
             
             
             for (int iCount = 0; iCount < volumes.Lenght;iCount++)
             {
                  if (volumes[iCount] > iMaxValue)
                  {
                    count = iCount;
                    iMaxValue = volumes[iCount];
                    console.WriteLine("the highest volume is" + volumes[icount] + count + "& the rectagler shape is" +recContainer[count]);
                    console.ReadLine();
                    
                  }
             
             
             
             }

       
        }
    }
}
