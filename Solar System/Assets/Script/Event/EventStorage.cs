using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script.Event
{
    public static class EventStorage
    {
        private static Dictionary<string, int> Flags = new Dictionary<string, int>();

        public static void setFlag(string key, int value)
        {
            Flags[key] = value;
        }

        public static int getFlag(string key)
        {
            key = key.ToLower();
            if (!Flags.ContainsKey(key))
                return 0;
            return Flags[key];
        }

    }
}
