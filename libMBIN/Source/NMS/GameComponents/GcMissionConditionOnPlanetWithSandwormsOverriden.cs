using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF75A70C05C76AA44, NameHash = 0xA65D2D8631795E30)]
    public class GcMissionConditionOnPlanetWithSandwormsOverriden : NMSTemplate
    {
        public bool AllowInShip;
        public bool AcceptMatchingSystem;
    }
}
