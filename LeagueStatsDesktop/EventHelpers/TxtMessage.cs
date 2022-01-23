using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsDesktop.EventHelpers
{
    internal class TxtMessage
    {
        private string _message;
        private string _value;

        public TxtMessage(string message, string value)
        {
            _message = message;
            _value = value;
        }

        public override string ToString()
        {
            return "\n" + _message + ":" + " " + _value;
        }
    }
}
