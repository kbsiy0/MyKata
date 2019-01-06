using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            if (String.IsNullOrEmpty(ants))
                return 0;

            var antsList = ants.Replace("ant", "").ToCharArray().ToList();

            int antHead = antsList.Count(c => c.Equals('a'));
            int antBody = antsList.Count(c => c.Equals('n'));
            int antFoot = antsList.Count(c => c.Equals('t'));

            return new int[] {antHead, antBody, antFoot}.Max();
        }
    }
}
