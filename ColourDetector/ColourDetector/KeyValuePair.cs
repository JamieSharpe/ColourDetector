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
        /// <summary>
        /// Gets/Sets the Key
        /// </summary>
        public TK Key { get; set; }
        /// <summary>
        /// Gets/Sets the Value
        /// </summary>
        public TV Value { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <remarks>Required for serialisation.</remarks>
        public KeyValuePair()
        {
        }

        /// <summary>
        /// Constructor for a key/value.
        /// </summary>
        /// <param name="k">Key</param>
        /// <param name="v">Value</param>
        public KeyValuePair(TK k, TV v)
        {
            this.Key = k;
            this.Value = v;
        }
        #endregion Constructors
    }
}
