using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscPos.Library.Base.Commands
{
    public class LineSpacingCommands: EscPosBaseCommand
    {
        /// <summary> Sets the line spacing to the "default line spacing." </summary>
        public static byte[] SelectDefaultLineSpacing() => CreateCommand(AsciiChars.ESC, 2);

        /// <summary> Sets the line spacing to n × (vertical or horizontal motion unit). </summary>
        /// <param name="motionUnit">vertical or horizontal motion unit <br/> Range 0 - 255</param>
        public static byte[] SetLineSpacing(int motionUnit) => CreateCommand(AsciiChars.ESC, 3, motionUnit);
    }
}
