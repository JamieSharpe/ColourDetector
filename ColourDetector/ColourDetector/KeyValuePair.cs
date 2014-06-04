using System;

namespace ColourDetector
{
    [Serializable]
    public class KeyValuePair<TK, TV>
    {
        public KeyValuePair()
        {
        }

        public KeyValuePair(TK k, TV v)
        {
            this.Key = k;
            this.Value = v;
        }

        public TK Key { get; set; }
        public TV Value { get; set; }
    }
}
