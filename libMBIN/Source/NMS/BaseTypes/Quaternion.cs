using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    public class Quaternion : NMSTemplate
    {
        public double x;
        public double y;
        public double z;
        public double w;
        public int dropComponent;

        public Quaternion(double x, double y, double z, double w, int dropComponent)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
            this.dropComponent = dropComponent;
        }

        public Quaternion() { }

        /// <summary>
        /// Returns a formatted string for this quaternion.
        /// <br/>Format: (x, y, z, w)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({this.x}, {this.y}, {this.z}, {this.w})";
        }

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
            {
            if (field == null || fieldInfo == null)
                return false;

            switch (fieldInfo.Name)
                {
                case nameof(dropComponent):
                    // Do nothing...
                    return true;
            }

            return false;
        }
    }
}
