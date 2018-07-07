using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Dashboard
    {
        private static Dashboard _instance;
        private string _name = "Dashboard._name";
        public string GetName() => _name;

        public static Dashboard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dashboard();
                }
                return _instance;
            }
        }



        public void SetDashName(string name)
        {
            _name = name;
        }

        public string GetDashName()
        {
            return _name;
        }

    }
}
