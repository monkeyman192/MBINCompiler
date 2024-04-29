using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDF5154A393B47BBB, NameHash = 0xF671716161E708E3)]
    public class TkMeshData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public byte[] MeshDataStream;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong Hash;
        [NMS(Index = 3)]
        /* 0x18 */ public int IndexDataSize;
        [NMS(Index = 2)]
        /* 0x1C */ public int VertexDataSize;
        [NMS(Index = 0, Size = 0x80, Padding = 0xFE)]
        /* 0x20 */ public string IdString;

        public override object CustomDeserialize( BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo ) {
            var fieldName = fieldInfo.Name;
            switch (fieldName)
                {
                case nameof(MeshDataStream):
                    long listPosition = reader.BaseStream.Position;

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32();
                    uint listMagic = reader.ReadUInt32();
                    if ( (listMagic & 0xFF) != 1 ) throw new InvalidListException( listMagic, reader.BaseStream.Position );
                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    byte[] data = new byte[numEntries];
                    data = reader.ReadBytes(numEntries);
                    reader.BaseStream.Position = listEndPosition;
                    return data;
            }
            return null;
        }

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
            {
            var fieldName = fieldInfo.Name;
            switch (fieldName)
                {
                case nameof(MeshDataStream):
                    writer.Align(8, fieldName );

                    // write empty list header
                    long listPos = writer.BaseStream.Position;
                    writer.Write((Int64) 0); // listPosition
                    writer.Write((Int32) (MeshDataStream?.Length ?? 0)); // size of data chunk in bytes
                    writer.Write((UInt32) 0xFEFEFE01);

                    additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, fieldData));
                    addtDataIndex++;
                    return true;
            }
            return false;
        }
    }

}
