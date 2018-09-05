namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3)]
    public class GcMissionConditionWeather : NMSTemplate
    {
        public bool IsExtreme;
        public bool StormActive;
        public bool IgnoreStormIfInShip;
    }
}
