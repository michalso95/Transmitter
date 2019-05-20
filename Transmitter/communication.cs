using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Transmitter
{
    class communication
    {
        internal UInt16 crc16(Byte[] packet, UInt32 nBytes)
        {
            UInt16 crc = 0;
            for (UInt32 bajt = 0; bajt < nBytes; bajt++)
            {
                crc = (UInt16)(crc ^ ((packet[bajt] << 8)));
                for (Byte bit = 0; bit < 8; bit++)
                    if ((crc & 0x8000) > 0)
                    {
                        crc = (UInt16)((crc << 1) ^ 0x1021);
                    }
                    else
                    {
                        crc = (UInt16)(crc << 1);
                    }
            }
            return crc;
        }

        internal UInt32 numdat_calc(int markers_count)
        {
            UInt32 numdat = (UInt32)((10 * markers_count) + 4);
            return (numdat);
        }

        internal Byte[] Com_PrepareFrameGPS(double yawx, double pitchx, double rollx, double lonx, double latx, int statex)
        {
            Int16 yaw = (Int16)(yawx * 10.0);
            Int16 pitch = (Int16)(pitchx * 10.0);
            Int16 roll = (Int16)(rollx * 10.0);
            Int16 lon = (Int16)(lonx * 10000000.0);
            Int16 lat = (Int16)(latx * 10000000.0);
            int state=0;

            if (statex == 0) { state = 0; }
            if (statex == 1) { state = 245; }
            if (statex == 2) { state = 246; }
            if (statex == 3) { state = 247; }
            if (statex == 4) { state = 248; }
            if (statex == 5) { state = 249; }
            if (statex == 6) { state = 250; }
            if (statex == 7) { state = 251; }

            Byte[] buf = new Byte[21];
            buf[0] = 155;
            buf[1] = 9;
            buf[2] = (Byte)(yaw >> 8);
            buf[3] = (Byte)yaw;
            buf[4] = (Byte)(pitch >> 8);
            buf[5] = (Byte)pitch;
            buf[6] = (Byte)(roll >> 8);
            buf[7] = (Byte)roll;
            buf[8] = (Byte)(lon >> 32);
            buf[9] = (Byte)(lon >> 24);
            buf[10] = (Byte)(lon >> 16);
            buf[11] = (Byte)(lon >> 8);
            buf[12] = (Byte)lon;
            buf[13] = (Byte)(lat >> 32);
            buf[14] = (Byte)(lat >> 24);
            buf[15] = (Byte)(lat >> 16);
            buf[16] = (Byte)(lat >> 8);
            buf[17] = (Byte)lat;
            buf[18] = (Byte)state;
            UInt16 crc = (Byte)(crc16(buf, 19));
            buf[19] = (Byte)(crc >> 8);
            buf[20] = (Byte)crc;

            return buf;
        }
    }
}
