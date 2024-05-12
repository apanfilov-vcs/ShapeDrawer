using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain
{
    public abstract class Shape
    {
        public Action<string>? OutputHandler { private get; set; }

        public string Output { get; set; } = string.Empty;

        public Shape() { }
        
        public virtual string Draw(char fillCharacter) 
        {
            if (OutputHandler is null)
            {
                throw new InvalidOperationException("Output handler must be set.");
            }

            OutputHandler(Output);
            
            return Output;
        }
    }
}