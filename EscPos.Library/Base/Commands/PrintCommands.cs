using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EscPos.Library.Base.Commands
{
    /// <summary>  </summary>
    public class PrintCommands: EscPosBaseCommand
    {
        /// <summary> Prints the data in the print buffer and feeds one line, based on the current line spacing. </summary>
        public static byte[] PrintAndLineFeed() => CreateCommand(AsciiChars.LF);

        /// <summary> in Page mode, prints all the data in the print buffer collectively and switches from Page mode to Standard mode. </summary>
        public static byte[] PrintAndReturnToStandartMode() => CreateCommand(AsciiChars.FF);

        /// <summary> "Printing is completed" in Standard mode. </summary>
        public static byte[] EndJob() => CreateCommand(AsciiChars.FF);

        /// <summary> Executes one of the following operations. <br/>
        /// Horizontal alignment - This command is ignored. <br/>
        /// Vertical alignment   - In Standard mode, prints the data in the print buffer and moves the print position to the beginning of the print line. <br/>
        /// in Page mode, moves the print position to the beginning of the print line.
        /// </summary>
        public static byte[] PrintAndCarriageReturn() => CreateCommand(AsciiChars.CR);

        /// <summary> in Page mode, prints the data in the print buffer collectively. </summary>
        public static byte[] PrintDataInPageMode() => CreateCommand(AsciiChars.ESC, AsciiChars.FF);

        /// <summary> Prints the data in the print buffer and feeds the paper [n × (vertical or horizontal motion unit)]. </summary>
        /// <param name="moutionUnit">vertical or horizontal motion unit <br/> Range 0 - 255 </param>
        public static byte[] PrintAndFeedPaper(int moutionUnit) => CreateCommand(AsciiChars.ESC, 'J', moutionUnit);

        /// <summary> Prints the data in the print buffer and feeds the paper n × (vertical or horizontal motion unit) in the reverse direction. </summary>
        /// <param name="moutionUnit">vertical or horizontal motion unit <br/> Range different depending on the printers</param>
        public static byte[] PrintAndReverseFeed(int moutionUnit) => CreateCommand(AsciiChars.ESC, 'K', moutionUnit);

        /// <summary> Prints the data in the print buffer and feeds n lines. </summary>
        /// <param name="linesCount">Range 0 - 255</param>
        public static byte[] PrintAndFeedNLines(int linesCount) => CreateCommand(AsciiChars.ESC, 'd', linesCount);

        /// <summary> Prints the data in the print buffer and feeds n lines in the reverse direction. </summary>
        /// <param name="linesCount">Range different depending on the printers</param>
        public static byte[] PrintAndReverseFeedNLines(int linesCount) => CreateCommand(AsciiChars.ESC, 'e', linesCount);
    }
}
