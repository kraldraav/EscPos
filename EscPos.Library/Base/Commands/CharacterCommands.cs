using EscPos.Library.Base.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscPos.Library.Base.Commands
{
    public class CharacterCommands : EscPosBaseCommand
    {
        /// <summary> in Page mode, deletes all the print data in the current print area. </summary>
        public static byte[] CancelPrintDataInPageMode() => CreateCommand(AsciiChars.CAN);

        /// <summary> Sets the right-side character spacing to n × (horizontal or vertical motion unit). </summary>
        /// <param name="moutionUnit">horizontal or vertical motion unit <br/> Range 0 - 255 </param>
        public static byte[] SetRightSideCharacterSpacing(int moutionUnit) => CreateCommand(AsciiChars.ESC, AsciiChars.SPACE, moutionUnit);

        /// <summary>  </summary>
        /// <param name="bit">0 – 255 different depending on the printers</param>
        public static byte[] SelectPrintModes(int bit) => CreateCommand(AsciiChars.ESC, '!', bit);

        /// <summary> Turns underline mode on or off using n as follows: </summary>
        /// <param name="n">
        /// 0, 48 - Turns off underline mode <br/>
        /// 1, 49 - Turns on underline mode(1-dot thick) <br/>
        /// 2, 50 - Turns on underline mode(2-dots thick) <br/>
        /// </param>
        public static byte[] TurnUnderlineMode(int n) => CreateCommand(AsciiChars.ESC, '-', n);

        /// <summary> Turns emphasized mode on or off. <br/>
        /// When the LSB of n is 0, emphasized mode is turned off.<br/>
        /// When the LSB of n is 1, emphasized mode is turned on. </summary>
        /// <param name="n">0 – 255</param>
        public static byte[] TurnEmphasizedMode(int n) => CreateCommand(AsciiChars.ESC, 'E', n);

        /// <summary> Turns double-strike mode on or off. <br/>
        /// When the LSB of n is 0, double-strike mode is turned off. <br/>
        /// When the LSB of n is 1, double-strike mode is turned on. </summary>
        /// <param name="n">0-255</param>
        public static byte[] TurnDoubleStrikeMode(int n) => CreateCommand(AsciiChars.ESC, 'G', n);

        /// <summary> Selects a character font </summary>
        /// <param name="n">
        /// 0, 48 - Font A <br/>
        /// 1, 49 - Font B <br/>
        /// 2, 50 - Font C <br/>
        /// 3, 51 - Font D <br/>
        /// 4, 52 - Font E <br/>
        /// 97 - Special font A <br/>
        /// 98 - Special font B <br/>
        ///</param>
        public static byte[] SelectCharacterFont(int n) => CreateCommand(AsciiChars.ESC, 'M', n);

        /// <summary> Selects an international character set </summary>
        /// <param name="internationalCharacterSet">International character set</param>
        public static byte[] SelectInternationalCharacterSet(InternationalCharacterSet internationalCharacterSet) => CreateCommand(AsciiChars.ESC, 'R', internationalCharacterSet);

        /// <summary> In Standard mode, turns 90° clockwise rotation mode on or off for characters </summary>
        /// <param name="n">
        /// 0, 48 - Turns off 90° clockwise rotation mode <br/>
        /// 1, 49 - Turns on 90° clockwise rotation mode(1-dot character spacing) <br/>
        /// 2, 50 - Turns on 90° clockwise rotation mode(1.5-dot character spacing)
        /// </param>
        public static byte[] TurnRotationMode(int n) => CreateCommand(AsciiChars.ESC, 'V', n);

        /// <summary> Selects a print color </summary>
        /// <param name="n">
        /// 0, 48 - Black <br/>
        /// 1, 49 - Red
        /// </param>
        public static byte[] SelectPrintColor(int n) => CreateCommand(AsciiChars.ESC, 'r', n);

        /// <summary> Selects a page from the character code table  </summary>
        /// <param name="characterCodeTable">character code table</param>
        public static byte[] SelectCharacterCodeTable(CharacterCodeTable characterCodeTable) => CreateCommand(AsciiChars.ESC, 't', characterCodeTable);

        /// <summary> In Standard mode, turns upside-down print mode on or off. </summary>
        /// <param name="n">
        /// When the LSB of n is 0, upside-down print mode is turned off. <br/>
        /// When the LSB of n is 1, upside-down print mode is turned on.
        /// </param>
        /// <returns></returns>
        public static byte[] TurnUpsideDownPrintMode(int n) => CreateCommand(AsciiChars.ESC, '{', n);

        /// <summary> Selects character size (height magnification and width magnification). </summary>
        /// <param name="n">
        /// n = 0xxx0xxxb (n = 0 – 7, 16 – 23, 32 – 39, 48 – 55, 64 – 71, 80 – 87, 96 – 103, 112 – 119) <br/>
        /// (Enlargement in vertical direction: 1–8, Enlargement in horizontal direction: 1–8)
        /// </param>
        /// <returns></returns>
        public static byte[] SelectCharacterSize(int n) => CreateCommand(AsciiChars.GS, '!', n);

        /// <summary> Turns white/black reverse print mode on or off. </summary>
        /// <param name="n">
        /// When the LSB of n is 0, white/black reverse print mode is turned off. <br/>
        /// When the LSB of n is 1, white/black reverse print mode is turned on.
        /// </param>
        /// <returns></returns>
        public static byte[] TurnWhiteBlackReversePrintingMode(int n) => CreateCommand(AsciiChars.GS, 'B', n);

        /// <summary> Turns smoothing mode on or off. </summary>
        /// <param name="n">
        /// When the LSB of n is 0, smoothing mode is turned off. <br/>
        /// When the LSB of n is 1, smoothing mode is turned on.
        /// </param>
        /// <returns></returns>
        public static byte[] TurnSmoothingMode(int n) => CreateCommand(AsciiChars.GS, 'b', n);

        /// <summary> Selects the character style </summary>
        /// <param name="pL">pL and pH specify the number of bytes following fn as (pL + pH × 256).</param>
        /// <param name="pH">pL and pH specify the number of bytes following fn as (pL + pH × 256).</param>
        /// <param name="fn">
        /// 48 - Select character color
        /// 49 - Select background color
        /// 50 - Turn shading mode on/off
        /// </param>
        public static byte[] SelectCharacterEffects(int pL, int pH, int fn, params object[] parameters) => CreateCommand(AsciiChars.GS, '(', 'N', pL, pH, fn, parameters);

        /// <summary> Selects character color </summary>
        public static byte[] SelectCharacterColor(CharacterColor characterColor) => SelectCharacterEffects(2, 0, 48, characterColor);

        /// <summary> Selects background color </summary>
        public static byte[] SelectBackgroundColor(CharacterColor characterColor) => SelectCharacterEffects(2, 0, 49, characterColor);

        /// <summary> Turns the character shadow mode on or off </summary>
        /// <param name="m">
        /// 0, 48 - Character shadow mode is turned off. <br/>
        /// 1, 49 - Character shadow mode is turned on.
        /// </param>
        /// <param name="characterColor">Prints the character shadow in the color specified</param>
        public static byte[] TurnShadingMode(int m, CharacterColor characterColor) => SelectCharacterEffects(3, 0, 50, m, characterColor);

        /// <summary> Selects or cancels the user-defined character set. </summary>
        /// <param name="n">
        /// When the LSB of n is 0, the user-defined character set is canceled. <br/>
        /// When the LSB of n is 1, the user-defined character set is selected.
        /// </param>
        public static byte[] SelectOrCancelUserDefinedCharacterSet(int n) => CreateCommand(AsciiChars.ESC, '%', n);

        /// <summary> Defines the user-defined character pattern for the specified character codes. </summary>
        /// <param name="y">specifies the number of bytes in the vertical direction.</param>
        /// <param name="x">specifies the number of dots in the horizontal direction from the left. Any remaining dots on the right side are blank.</param>
        /// <param name="c1">specifies the beginning character code for the definition</param>
        /// <param name="c2">specifies the final code</param>
        /// <param name="d"> specifies the definition data (column format)</param>
        /// <returns></returns>
        public static byte[] DefineUserDefinedCharacters(int y, int x, char c1, char c2, int d)
        {
            int k = (int)c2 - (int)c1 + 1;

            // TODO 


            return null; // CreateCommand(AsciiChars.ESC, '&', y, c1, c2);
        }

        /// <summary> Deletes the user-defined character pattern specified by character code n </summary>
        /// <param name="n">Character code in range 32 – 126</param>
        public static byte[] CancelUserDefinedCharacters(int n) => CreateCommand(AsciiChars.ESC, '?', n);

        /// <summary> Specifies processing concerning setting of encode method. </summary>
        /// <param name="pL">pL and pH specify the number of bytes following fn as (pL + pH × 256).</param>
        /// <param name="pH">pL and pH specify the number of bytes following fn as (pL + pH × 256).</param>
        /// <param name="fn">
        /// 48 - Select character encode system <br/>
        /// 60 - Set font priority
        /// </param>
        /// <param name="parameters"></param>
        public static byte[] SelectCodeConversionMethod(int pL, int pH, int fn, params object[] parameters) => CreateCommand(AsciiChars.FS, '(', 'C', pL, pH, fn, parameters);

        /// <summary> Select encode method of character strings. </summary>
        /// <param name="m">1, 2, 49, 50</param>
        public static byte[] SelectCharacterEncodeSystem(int m) => SelectCodeConversionMethod(2, 0, 48, m);

        /// <summary> Select character encode system </summary>
        /// <param name="m">
        /// 0 - Specify font to be given 1st priority <br/>
        /// 1 - Specify font to be given 2nd priority
        /// </param>
        /// <param name="a">
        /// 0 - ANK font - Sans serif <br/>
        /// 11 - Japanese font - Gothic <br/>
        /// 20 - Simplified Chinese font - Mincho <br/>
        /// 30 - Traditional Chinese font - Mincho <br/>
        /// 41 - Korean font - Gothic
        /// </param>
        /// <returns></returns>
        public static byte[] SetFontPriority(int m, int a) => SelectCodeConversionMethod(3, 0, 60, m, a);

        // TODO: FS ( L - Select label and black mark control function(s)
    }
}
