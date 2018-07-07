using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2016
{
    class UsingProperties
    {
        private string _name = "default";
        private Thingy _thingy;

        // set allows for validation logic(set)
        public string Name
        {
            get { return _name; }
            set {
                var formattedName = value?.Trim();
                _name = formattedName;
            }
        }

        //get allows for lazy loading a 'Thingy' object using the getter
        // used for Singleton Design Pattern
        public Thingy AThingy
        {
            get
            {
                if (_thingy == null)
                {
                    _thingy = new Thingy();
                }
                return _thingy;
            }
            set { _thingy = value; }
        }

    }

    class Thingy {
        public string Name;
        public string Value;
    }

}
