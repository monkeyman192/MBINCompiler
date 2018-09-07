namespace libMBIN.Models.Structs
{
    public class GcJourneyMedalType : NMSTemplate
    {
		public enum MedalTypeEnum { Standings, Missions, Words, Systems, Sentinels, Pirates, Plants, Units, RaceCreatures, DistanceWarped }
		public MedalTypeEnum MedalType;
    }
}
