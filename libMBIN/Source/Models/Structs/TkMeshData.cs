using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA0)]
    public class TkMeshData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string IdString;
        /* 0x80 */ public ulong Hash;
        /* 0x88 */ public int VertexDataSize;
        /* 0x8C */ public int IndexDataSize;
        /* 0x90 */ public byte[] MeshDataStream;

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                case nameof(MeshDataStream):
                    long listPosition = reader.BaseStream.Position;
                    //DebugLog($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32();
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1)
                        throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");
                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    byte[] data = new byte[numEntries];
                    data = reader.ReadBytes(numEntries);
                    reader.BaseStream.Position = listEndPosition;
                    return data;
            }
            return null;
        }
    }

}
