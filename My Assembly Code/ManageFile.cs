using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//
// This saves and loads variables in an xml format
//


namespace My_Assembly_Code
{
    internal class ManageFile
    {
        public static void Save( string fileName, List<CharV> charList, List<IntV> intList )
        {
            XmlDocument AssemblyInstructions = new XmlDocument();
            XmlNode Variables = AssemblyInstructions.CreateElement("Variables");
            AssemblyInstructions.AppendChild(Variables);

            foreach (CharV chars in charList)
            {
                XmlNode variable = AssemblyInstructions.CreateElement("Variable");

                XmlNode type = AssemblyInstructions.CreateElement("Type");
                type.InnerText = "CHAR";
                variable.AppendChild(type);

                XmlNode name = AssemblyInstructions.CreateElement("Name");
                name.InnerText = chars.name;
                variable.AppendChild(name);

                XmlNode value = AssemblyInstructions.CreateElement("Value");
                value.InnerText = chars.value.ToString();
                variable.AppendChild(value);

                Variables.AppendChild(variable);
            }


            foreach (IntV ints in intList)
            {
                XmlNode variable = AssemblyInstructions.CreateElement("Variable");

                XmlNode type = AssemblyInstructions.CreateElement("Type");
                type.InnerText = "INT";
                variable.AppendChild(type);

                XmlNode name = AssemblyInstructions.CreateElement("Name");
                name.InnerText = ints.name;
                variable.AppendChild(name);

                XmlNode value = AssemblyInstructions.CreateElement("Value");
                value.InnerText = ints.value.ToString();
                variable.AppendChild(value);

                Variables.AppendChild(variable);
            }
            AssemblyInstructions.Save(fileName);
        }

        public static void LoadXML(string fileName, List<CharV> charList, List<IntV> intList)
        {
            XmlDocument AssemblyInstructions = new XmlDocument();
            AssemblyInstructions.Load(fileName);

            XmlNode Variables = AssemblyInstructions.DocumentElement;
            foreach (XmlNode vars in Variables.ChildNodes)
            {
                string nodeType = vars["Type"].InnerText;
                string nodeName = vars["Name"].InnerText;
                string nodeValue = vars["Value"].InnerText;

                if (nodeType == "CHAR")
                {
                    CharV c = new CharV();
                    c.name = nodeName;
                    c.value = char.Parse(nodeValue);
                    charList.Add(c);
                    MessageBox.Show(c.name.ToString() + " " + c.value.ToString());
                }
                else if (nodeType == "INT")
                {
                    IntV i = new IntV();
                    i.name = nodeName;
                    i.value = double.Parse(nodeValue);
                    intList.Add(i);
                    MessageBox.Show(i.name.ToString() + " " + i.value.ToString());
                }
            }
        }
    }   

}
