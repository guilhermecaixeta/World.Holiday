using System;

namespace World.Holidays.Enum
{
    /// <summary>
    /// Culture accepted
    /// </summary>
    public class Culture
    {
        /// <summary>
        /// All Cultures
        /// </summary>
        internal const ECulture AllCultures = ECulture.enCA | ECulture.enUS | ECulture.ptBR | ECulture.ptPT | ECulture.esES;

        /// <summary>
        /// The culturept ptes
        /// </summary>
        internal const ECulture CultureptPTES = ECulture.ptPT | ECulture.esES;

        /// <summary>
        /// The easter day culture
        /// </summary>
        internal const ECulture EasterDayCulture = ECulture.enUS | ECulture.ptBR | ECulture.ptPT;

        /// <summary>
        /// The easter monday
        /// </summary>
        internal const ECulture EasterMonday = ECulture.enCA | ECulture.ptPT | ECulture.esES;

        /// <summary>
        /// The en culture
        /// </summary>
        internal const ECulture EnCulture = ECulture.enCA | ECulture.enUS;

        /// <summary>
        /// The pt culture
        /// </summary>
        internal const ECulture PtCulture = ECulture.ptBR | ECulture.ptPT;

        /// <summary>
        /// The valentine day
        /// </summary>
        internal const ECulture ValentineDayCulture = ECulture.enCA | ECulture.enUS | ECulture.ptPT;

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

            /// <summary>
            /// The es es
            /// </summary>
            esES = 0x06,
        }
    }
}