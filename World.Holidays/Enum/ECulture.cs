using System;

namespace World.Holidays.Enum
{
    /// <summary>
    /// Culture accepted
    /// </summary>
    public class Culture
    {
        /// <summary>
        /// Enum culture
        /// </summary>
        [Flags]
        public enum ECulture
        {
            /// <summary>
            /// The none
            /// </summary>
            None = 0x0,
            /// <summary>
            /// The pt br
            /// </summary>
            ptBR = 0x10,
            /// <summary>
            /// The pt pt
            /// </summary>
            ptPT = 0x20,
            /// <summary>
            /// The en ca
            /// </summary>
            enCA = 0x40,
            /// <summary>
            /// The en us
            /// </summary>
            enUS = 0x01,//some values need be lower than value above, else they could impact the correct work of the package.
        }

        /// <summary>
        /// All Cultures
        /// </summary>
        internal const ECulture AllCultures = ECulture.enCA | ECulture.enUS | ECulture.ptBR | ECulture.ptPT;

        /// <summary>
        /// The easter day culture
        /// </summary>
        internal const ECulture EasterDayCulture = ECulture.enUS | ECulture.ptBR | ECulture.ptPT;

        /// <summary>
        /// The valentine day
        /// </summary>
        internal const ECulture ValentineDayCulture = ECulture.enCA | ECulture.enUS | ECulture.ptPT;

        /// <summary>
        /// The en culture
        /// </summary>
        internal const ECulture EnCulture = ECulture.enCA | ECulture.enUS;

        /// <summary>
        /// The pt culture
        /// </summary>
        internal const ECulture PtCulture = ECulture.ptBR | ECulture.ptPT;
    }
}