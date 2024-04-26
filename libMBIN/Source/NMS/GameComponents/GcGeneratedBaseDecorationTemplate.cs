using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x320EC0C308ECA15C, NameHash = 0x6370110DC5DC47D2)]
    public class GcGeneratedBaseDecorationTemplate : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 5)]
        /* 0x10 */ public List<int> InvalidRoomIndexes;
        [NMS(Index = 1)]
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
        [NMS(Index = 4)]
        /* 0xA4 */ public DecorationLayerEnum DecorationLayer;
        [NMS(Index = 3)]
        /* 0xA8 */ public int MaxPerRoom;
        [NMS(Index = 2)]
        /* 0xAC */ public float Probability;
    }
}
