using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x4D2440DFB146AE13, NameHash = 0xF839343C27983F1A)]
    public class GcPlayerCommunicatorMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Dialog;
        /* 0x20 */ public bool ShowHologram;
        // size: 0x8
		public enum CommunicatorTypeEnum { HoloExplorer, HoloSceptic, HoloNoone, Generic, PlayerFreighterCaptain, Polo, Nada, QuicksilverBot }
		public CommunicatorTypeEnum CommunicatorType;
        /* 0x28 */ public GcAlienRace RaceOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        /* 0x30 */ public NMSString0x20 ShipHUDOverride;
    }
}
