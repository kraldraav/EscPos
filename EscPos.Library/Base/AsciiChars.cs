using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscPos.Library.Base
{
    /// <summary> ASCII stands for American Standard Code for Information Interchange. </summary>
    public sealed class AsciiChars
    {
        /// <summary> null </summary>
        public const char NUL = (char)0x00;

        /// <summary> Start of heading </summary>
        public const char SOH = (char)0x01;

        /// <summary> Start of text </summary>
        public const char STX = (char)0x02;

        /// <summary> End of text </summary>
        public const char ETX = (char)0x03;

        /// <summary> End of transmission </summary>
        public const char EOT = (char)0x04;

        /// <summary> enquiry </summary>
        public const char ENQ = (char)0x05;

        /// <summary> Acknowledge </summary>
        public const char ACK = (char)0x06;

        /// <summary> Bell </summary>
        public const char BEL = (char)0x07;

        /// <summary> Backspace </summary>
        public const char BS = (char)0x08;

        /// <summary> Horizontal tab </summary>
        public const char HT = (char)0x09;

        /// <summary> NL line feed, new line </summary>
        public const char LF = (char)0x0A;

        /// <summary> Vertical tab </summary>
        public const char VT = (char)0x0B;

        /// <summary> NP form feed, new page </summary>
        public const char FF = (char)0x0C;

        /// <summary> Carriage return </summary>
        public const char CR = (char)0x0D;

        /// <summary> Shift out </summary>
        public const char SO = (char)0x0E;

        /// <summary> Shift in </summary>
        public const char SI = (char)0x0F;

        /// <summary> Data link escape </summary>
        public const char DLE = (char)0x10;

        /// <summary> Device control 1 </summary>
        public const char DC1 = (char)0x11;

        /// <summary> Device control 2 </summary>
        public const char DC2 = (char)0x12;

        /// <summary> Device control 3 </summary>
        public const char DC3 = (char)0x13;

        /// <summary> Device control 4 </summary>
        public const char DC4 = (char)0x14;

        /// <summary> Negative acknowledge </summary>
        public const char NAK = (char)0x15;

        /// <summary> Synchoronous idle </summary>
        public const char SYN = (char)0x16;

        /// <summary> End of trans. block </summary>
        public const char ETB = (char)0x17;

        /// <summary> Cancel </summary>
        public const char CAN = (char)0x18;

        /// <summary> End of medium </summary>
        public const char EM = (char)0x19;

        /// <summary> Subtitute </summary>
        public const char SUB = (char)0x1A;

        /// <summary> Escape </summary>
        public const char ESC = (char)0x1B;

        /// <summary> File separator </summary>
        public const char FS = (char)0x1C;

        /// <summary> Group separator </summary>
        public const char GS = (char)0x1D;

        /// <summary> Record separator </summary>
        public const char RS = (char)0x1E;

        /// <summary> Unit separator </summary>
        public const char US = (char)0x1F;

        /// <summary> Space </summary>
        public const char SPACE = (char)0x20;

        /// <summary> Delete </summary>
        public const char DEL = (char)0x7F;
    }
}
