using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class DuplicateIdentifier<T> where T : IEquatable<T>
    {
        public static void IdentifyDuplicates(List<T> collectionA, List<T> collectionS)
        {
            HashSet<T> setA = new HashSet<T>(collectionA);

            foreach (var element in collectionS)
            {
                bool isPresent = setA.Contains(element);
                Console.WriteLine($"{element}:{isPresent.ToString().ToLower()}");
            }
        }
    }
}
