using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscPos.Library.Base.Commands
{
    /// <summary> Esc/Pos Base command class </summary>
    public class EscPosBaseCommand
    {
        /// <summary> Create byte sequence from object array </summary>
        /// <param name="parameters">Chars, integers or else</param>
        /// <returns>Byte sequence</returns>
        public static byte[] CreateCommand(params object[] parameters)
        {
            var command = new List<byte>();

            foreach (var parameter in parameters)
            {
                if (parameter is object[])
                {
                    command.AddRange(from param in (object[]) parameter select Convert.ToByte(param));
                    continue;
                }

                command.Add(Convert.ToByte(parameter));
            }

            return command.ToArray();
        }
    }
}
