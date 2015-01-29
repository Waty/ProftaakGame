namespace ProftaakGame
{
    public class Level
    {
        public string[] MapData;
        public int MapId;
        public string MapName;

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return MapName;
        }
    }
}