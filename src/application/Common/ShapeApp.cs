using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain;
using domain.Shapes;

namespace application.Common
{
    public partial class ShapeApp
    {
        public Action<string> OutputHandler { get; private set; }
        public ShapeApp(Action<string> outputHandler)
        {
            OutputHandler = outputHandler;
        }
    }
}