using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E8F97E2BA46BB89, NameHash = 0xF839343C27983F1A)]
    public class GcPlayerCommunicatorMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Dialog;
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
        /* 0x40 */ public CommunicatorTypeEnum CommunicatorType;
        /* 0x44 */ public GcAudioWwiseEvents HailAudioOverride;
        /* 0x48 */ public GcAlienRace RaceOverride;
        /* 0x4C */ public bool ShowHologram;
    }
}
