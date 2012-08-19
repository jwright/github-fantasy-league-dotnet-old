using System;
using System.Collections.Generic;
using System.Linq;
using WatiN.Core;

namespace GitHubFantasyLeauge.Specs.Support
{
    public class Engine
    {
        private static Engine _current;
        private Browser _browser;

        public static Engine Current
        {
            get
            {
                if (_current == null)
                    _current = new Engine();
                return _current;
            }
        }

        public Browser Browser
        {
            get { return _browser; }
        }

        private Engine()
        {
            // TODO: Create a simple way to switch from Firefox and IE
            _browser = new IE();
        }
    }
}
