namespace Nvipt.Core
{
    public enum HairDyeType
    {
        /// <summary>
        /// No hair dye
        /// </summary>
        None = 0,

        /// <summary>
        /// HP-based hair dye
        /// </summary>
        LifeDye = 1,

        /// <summary>
        /// Mana-based hair dye
        /// </summary>
        ManaDye = 2,

        /// <summary>
        /// World depth-based hair dye
        /// </summary>
        DepthDye = 3,

        /// <summary>
        /// Player inventory coins-based hair dye
        /// </summary>
        MoneyDye = 4,

        /// <summary>
        /// World time-based hair dye
        /// </summary>
        TimeDye = 5,

        /// <summary>
        /// Player team-based hair dye
        /// </summary>
        TeamDye = 6,

        /// <summary>
        /// Player current biome-based hair dye
        /// </summary>
        BiomeDye = 7,

        /// <summary>
        /// Pink hair dye with confetti
        /// </summary>
        PartyDye = 8,

        /// <summary>
        /// Rainbow cycle hair dye
        /// </summary>
        RainbowDye = 9,

        /// <summary>
        /// Player velocity-based hair dye
        /// </summary>
        SpeedDye = 10,

        /// <summary>
        /// Cyan hair dye that glows brighter in the dark
        /// </summary>
        MartianDye = 11,

        /// <summary>
        /// Realistic space-like hair [dye]
        /// </summary>
        TwilightDye = 12,

        /// <summary>
        /// Represents amnount of dyes
        /// </summary>
        Count = TwilightDye
    }
}
