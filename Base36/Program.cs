using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base36
{
    internal class Program
    {
        // for example, Poole 5883 is stored as 0x35335833;
        static UInt32 GetNlc(string s, int offset)
        {
            UInt32 result = 0;
            for(int i = 0; i < 4; i++)
            {
                result = (result << 8) + s[offset + i];
            }
            return result;
        }

        static IEnumerable<int> GetNext()
        {
            int i = 0;
            while (true)
            {
                yield return i++;
            }
        }
        private static void Main(string[] args)
        {
            try
            {
                string s = "DEADBEEF";
                var result = 0;
                foreach (var c in s)
                {
                    result = (result * 16) + ((c < 'A') ? c - '0' : c - 'A' + 10);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                var codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
