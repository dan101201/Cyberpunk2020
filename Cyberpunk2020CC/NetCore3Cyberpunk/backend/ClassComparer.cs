using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore3Cyberpunk.Backend
{
    class ClassComparer : IComparer<IItem>
    {
        public int Compare(IItem x, IItem y)
        {
            if (x.Name == y.Name || x.Name != "" && y.Name == " " || y.Name != "" && x.Name == " ")
            {
                return 0;
            }
            else if (x.Name[0] != y.Name[0])
            {
                return FindNumberInAlphabet(x.Name[0]) - FindNumberInAlphabet(y.Name[0]);
            }
            else
            {
                for (int i = 0; i < x.Name.Length && i < y.Name.Length; i++)
                {
                    if (x.Name[i] != y.Name[i])
                    {
                        return FindNumberInAlphabet(x.Name[0]) - FindNumberInAlphabet(y.Name[0]);
                    }
                    else if (i+1 == x.Name.Length && i+1 != y.Name.Length)
                    {
                        return -1;
                    }
                    else if (i + 1 != x.Name.Length && i + 1 == y.Name.Length)
                    {
                        return +1;
                    }
                }
                return 0;
            }
        }

        public IItem[] SortIItems(IItem[] items)
        {
            List<IItem> itemsList = new List<IItem>(items);
            ClassComparer comparer = new ClassComparer();
            itemsList.Sort(comparer);
            return itemsList.ToArray();
        }

        int FindNumberInAlphabet(char c)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for(int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == c)
                {
                    return i;
                }
            }
            throw new Exception();
        }

    }

    

}
