namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81F5954B1FDD5152, NameHash = 0xCA859438252A0A4E)]
    public class GcScanType : NMSTemplate
    {
        // size: 0xB
        public enum ScanTypeEnum : uint {
            Tool,
            Beacon,
            RadioTower,
            Observatory,
            DistressSignal,
            Waypoint,
            Ship,
            DebugPlanet,
            DebugSpace,
            VisualOnly,
            VisualOnlyAerial,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScanTypeEnum ScanType;
    }
}
