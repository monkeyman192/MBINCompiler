using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x320EC0C308ECA15C, NameHash = 0x6370110DC5DC47D2)]
    public class GcGeneratedBaseDecorationTemplate : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<int> InvalidRoomIndexes;
        /* 0x20 */ public TkModelResource TemplateScene;
        // size: 0x8
        public enum DecorationLayerEnum : uint {
            Stairs,
            Corridor,
            Room,
            Door,
            Decoration1,
            Decoration2,
            Decoration3,
            DecorationCorridor,
        }
        /* 0xA4 */ public DecorationLayerEnum DecorationLayer;
        /* 0xA8 */ public int MaxPerRoom;
        /* 0xAC */ public float Probability;
    }
}
