using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F8E41B9C240E358, NameHash = 0xF839343C27983F1A)]
    public class GcPlayerCommunicatorMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Dialog;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x20A ShipHUDOverride;
        // size: 0xC
        public enum CommunicatorTypeEnum : uint {
            HoloExplorer,
            HoloSceptic,
            HoloNoone,
            Generic,
            PlayerFreighterCaptain,
            Polo,
            Nada,
            QuicksilverBot,
            PlayerSettlementResident,
            CargoScanDrone,
            Tethys,
            FleetExpeditionCaptain,
        }
        [NMS(Index = 2)]
        /* 0x40 */ public CommunicatorTypeEnum CommunicatorType;
        [NMS(Index = 5)]
        /* 0x44 */ public GcAudioWwiseEvents HailAudioOverride;
        [NMS(Index = 3)]
        /* 0x48 */ public GcAlienRace RaceOverride;
        [NMS(Index = 1)]
        /* 0x4C */ public bool ShowHologram;
    }
}
