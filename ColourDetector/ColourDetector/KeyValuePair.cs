using System;

namespace ColourDetector
{
    /// <summary>
    /// A key/value generic wrapper that can be serialised
    /// for XML storage.
    /// </summary>
    /// <typeparam name="TK">Type of key</typeparam>
    /// <typeparam name="TV">Type of Value</typeparam>
    [Serializable]
    public class KeyValuePair<TK, TV>
    {
        #region Properties
        public TK Key { get; set; }
        public TV Value { get; set; }
        #endregion Properties

        #region Constructors
        public KeyValuePair()
        {
        }

        public KeyValuePair(TK k, TV v)
        {
            this.Key = k;
            this.Value = v;
        }
        #endregion Constructors
    }
}
