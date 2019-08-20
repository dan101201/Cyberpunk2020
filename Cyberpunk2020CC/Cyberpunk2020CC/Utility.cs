using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cyberpunk2020CharacterCreator
{
    class Utility
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
        static public XmlNode XmlFindFirstNodeAndRemoveAllChildren(XmlDocument doc, string name)
        {

            XmlNodeList nodes = doc.SelectNodes(name);
            XmlNode node = nodes[0];

            foreach (XmlNode child in node)
            {
                node.RemoveChild(child);
            }
            return node;
        }

    }
}
