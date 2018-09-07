using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMissionPageHint : NMSTemplate
    {
		public enum MissionPageHintEnum { None, Suit, Ship, Weapon, Vehicle, Freighter, Wiki, MissionLog, Discovery, Journey }
		public MissionPageHintEnum MissionPageHint;
    }
}
