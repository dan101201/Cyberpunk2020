using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Markup;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cyberpunk2020CharacterCreator
{
    static class Utility
    {

        static public XmlNode RemoveAllChildren(XmlNode node)
        {
            foreach (XmlNode child in node)
            {
                node.RemoveChild(child);
            }
            return node;
        }

        //Finds all nodes inside the XmlDocument with the name given, and removes all children
        static public XmlNode XmlRemoveAllChildren(XmlNode node, string name)
        {
            node = node.SelectSingleNode(name);
            foreach (XmlNode child in node)
            {
                node.RemoveChild(child);
            }
            return node;
        }

        public static T DeepCopy<T>(T element)
        {
            var xaml = XamlWriter.Save(element);
            var xamlString = new StringReader(xaml);
            var xmlTextReader = new XmlTextReader(xamlString);
            var deepCopyObject = (T)XamlReader.Load(xmlTextReader);
            return deepCopyObject;
        }

        public static int[] GetSlots(int slots, int max)
        {
            return new Random().Values(1, max)
                               .Take(slots - 1)
                               .Append(0, max)
                               .OrderBy(i => i)
                               .Pairwise((x, y) => y - x)
                               .ToArray();
        }

        public static IEnumerable<int> Values(this Random random, int minValue, int maxValue)
        {
            while (true)
                yield return random.Next(minValue, maxValue);
        }

        public static IEnumerable<TResult> Pairwise<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
        {
            TSource previous = default(TSource);

            using (var it = source.GetEnumerator())
            {
                if (it.MoveNext())
                    previous = it.Current;

                while (it.MoveNext())
                    yield return resultSelector(previous, previous = it.Current);
            }
        }

        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, params T[] args)
        {
            return source.Concat(args);
        }

    }

}
