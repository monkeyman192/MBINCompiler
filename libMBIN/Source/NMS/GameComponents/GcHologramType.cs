namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCEA435787118C2DE, NameHash = 0xEB288EEB07D9E790)]
    public class GcHologramType : NMSTemplate
    {
        // size: 0x4
        public enum HologramTypeEnum : uint {
            Mesh,
            PlayerCharacter,
            PlayerShip,
            PlayerMultiTool,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HologramTypeEnum HologramType;
    }
}
