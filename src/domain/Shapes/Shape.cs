using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain
{
    public abstract class Shape
    {       
        public Shape() { }
        
        public virtual string Draw(char fillCharacter) 
        {
            return string.Empty;
        }
    }
}