using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace application.Common
{
    public partial class ShapeBuilder
    {
        public class Options
        {
            private Action<string>? _outputHandler;
            public Options WithOutputHandler(Action<string> outputHandler)
            {
                _outputHandler = outputHandler;
                return this;
            }

            public ShapeApp Build()
            {
                if (_outputHandler is null)
                {
                    throw new InvalidOperationException("Output handler must be set.");
                }

                return new ShapeApp(_outputHandler);
            }
        }
    }
}