﻿using System;
using System.Xml;

namespace Scapple_Final
{
    class Program
    {
        private void AddNote(string note_width, string note_fontSize, string note_id, string note_position,
            string alignment_text, string border_weight, string border_style,
            string string_text, string connectedNoteIDs_text,
            string path) //在已有文件基础上新增一个节点
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode root = xmlDoc.SelectSingleNode("ScappleDocument"); //查找<ScappleDocument>
            XmlNode notes = root.SelectSingleNode("Notes");

            XmlElement note = xmlDoc.CreateElement("Note"); //创建一个<Note>节点
            //设置该节点属性
            note.SetAttribute("Width", note_width);
            note.SetAttribute("FontSize", note_fontSize);
            note.SetAttribute("ID", note_id);
            note.SetAttribute("Position", note_position);

            XmlElement appearance = xmlDoc.CreateElement("Appearance");

            XmlElement alignment = xmlDoc.CreateElement("Alignment");
            alignment.InnerText = alignment_text; //设置文本节点

            XmlElement border = xmlDoc.CreateElement("Border");
            border.SetAttribute("Weight", border_weight);
            border.SetAttribute("Style", border_style);

            appearance.AppendChild(alignment); //添加到<Appearance>节点中
            appearance.AppendChild(border);

            XmlElement _string = xmlDoc.CreateElement("String");
            _string.InnerText = string_text;

            XmlElement connectedNoteIDs = xmlDoc.CreateElement("ConnectedNoteIDs");
            connectedNoteIDs.InnerText = connectedNoteIDs_text;

            note.AppendChild(appearance);
            note.AppendChild(_string);
            note.AppendChild(connectedNoteIDs);

            notes.AppendChild(note);
            root.AppendChild(notes);
            xmlDoc.Save(path);

            return;
        }



        static void Main(string[] args)
        {
            Program program = new Program();
            string path = program.newXML();

            program.AddNote("39.7827", "13", "1", "368.3,90.6", "Left", "0", "Rounded", "第1", "0", path);
            program.AddNote("100.6943", "12", "0", "368.3,159.4", "Right", "0", "Rounded", "hello", "1", path);

            return;
        }


        private string newXML() //新建文件并写好框架
        {
            //创建XML文档，存在就删除再生成
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);

            //创建根结点
            XmlElement scappleDocument = doc.CreateElement("ScappleDocument");
            doc.AppendChild(scappleDocument);

            XmlElement notes = doc.CreateElement("Notes");
            scappleDocument.AppendChild(notes);
            XmlElement backgroundShapes = doc.CreateElement("BackgroundShapes");
            scappleDocument.AppendChild(backgroundShapes);

            XmlElement noteStyles = doc.CreateElement("NoteStyles");

            //style1
            XmlElement style1 = doc.CreateElement("Style");
            style1.SetAttribute("AffectFontStyle", "No");
            style1.SetAttribute("AffectAlignment", "No");
            style1.SetAttribute("Name", "Brown Bubble");
            style1.SetAttribute("ID", "F780D2BA-F2C6-4507-829C-2D475F0F90EB");
            style1.SetAttribute("AffectTextColor", "No");
            style1.SetAttribute("AffectNoteBody", "Yes");
            style1.SetAttribute("AffectSticky", "No");
            style1.SetAttribute("AffectSize", "No");
            style1.SetAttribute("AffectFade", "No");

            XmlElement borderThickness1 = doc.CreateElement("BorderThickness");
            borderThickness1.InnerText = "1";
            style1.AppendChild(borderThickness1);
            XmlElement borderColor1 = doc.CreateElement("BorderColor");
            borderColor1.InnerText = "0.269490 0.164034 0.186694";
            style1.AppendChild(borderColor1);
            XmlElement fillColor1 = doc.CreateElement("FillColor");
            fillColor1.InnerText = "0.934157 0.888319 0.785290";
            style1.AppendChild(fillColor1);

            noteStyles.AppendChild(style1);

            //style2
            XmlElement style2 = doc.CreateElement("Style");
            style2.SetAttribute("AffectFontStyle", "No");
            style2.SetAttribute("AffectAlignment", "No");
            style2.SetAttribute("Name", "Green Bubble");
            style2.SetAttribute("ID", "4D8F6A13-FF36-47F6-BE62-12A67B42A484");
            style2.SetAttribute("AffectTextColor", "No");
            style2.SetAttribute("AffectNoteBody", "Yes");
            style2.SetAttribute("AffectSticky", "No");
            style2.SetAttribute("AffectSize", "No");
            style2.SetAttribute("AffectFade", "No");

            XmlElement borderThickness2 = doc.CreateElement("BorderThickness");
            borderThickness2.InnerText = "1";
            style2.AppendChild(borderThickness2);
            XmlElement borderColor2 = doc.CreateElement("BorderColor");
            borderColor2.InnerText = "0.399100 0.583322 0.354864";
            style2.AppendChild(borderColor2);
            XmlElement fillColor2 = doc.CreateElement("FillColor");
            fillColor2.InnerText = "0.808835 0.872419 0.801343";
            style2.AppendChild(fillColor2);

            noteStyles.AppendChild(style2);

            //style3
            XmlElement style3 = doc.CreateElement("Style");
            style3.SetAttribute("AffectFontStyle", "No");
            style3.SetAttribute("AffectAlignment", "No");
            style3.SetAttribute("Name", "Pink Bubble");
            style3.SetAttribute("ID", "E39A706D-0F10-4321-8D7C-9534420BBB99");
            style3.SetAttribute("AffectTextColor", "No");
            style3.SetAttribute("AffectNoteBody", "Yes");
            style3.SetAttribute("AffectSticky", "No");
            style3.SetAttribute("AffectSize", "No");
            style3.SetAttribute("AffectFade", "No");

            XmlElement borderThickness3 = doc.CreateElement("BorderThickness");
            borderThickness3.InnerText = "1";
            style3.AppendChild(borderThickness3);
            XmlElement borderColor3 = doc.CreateElement("BorderColor");
            borderColor3.InnerText = "0.690303 0.407263 0.550912";
            style3.AppendChild(borderColor3);
            XmlElement fillColor3 = doc.CreateElement("FillColor");
            fillColor3.InnerText = "0.898329 0.817472 0.865339";
            style3.AppendChild(fillColor3);

            noteStyles.AppendChild(style3);

            //style4
            XmlElement style4 = doc.CreateElement("Style");
            style4.SetAttribute("AffectFontStyle", "No");
            style4.SetAttribute("AffectAlignment", "No");
            style4.SetAttribute("Name", "Blue Bubble");
            style4.SetAttribute("ID", "4B2F8D04-9780-4FF0-96A2-E40E82F4453F");
            style4.SetAttribute("AffectTextColor", "No");
            style4.SetAttribute("AffectNoteBody", "Yes");
            style4.SetAttribute("AffectSticky", "No");
            style4.SetAttribute("AffectSize", "No");
            style4.SetAttribute("AffectFade", "No");

            XmlElement borderThickness4 = doc.CreateElement("BorderThickness");
            borderThickness4.InnerText = "1";
            style4.AppendChild(borderThickness4);
            XmlElement borderColor4 = doc.CreateElement("BorderColor");
            borderColor4.InnerText = "0.485893 0.568933 0.756207";
            style4.AppendChild(borderColor4);
            XmlElement fillColor4 = doc.CreateElement("FillColor");
            fillColor4.InnerText = "0.844068 0.869596 0.923064";
            style4.AppendChild(fillColor4);

            noteStyles.AppendChild(style4);

            //style5
            XmlElement style5 = doc.CreateElement("Style");
            style5.SetAttribute("AffectFontStyle", "Yes");
            style5.SetAttribute("AffectAlignment", "Yes");
            style5.SetAttribute("Name", "Title Text");
            style5.SetAttribute("ID", "DD5C481A-6ADF-4F13-B6D9-6C743262BA39");
            style5.SetAttribute("AffectTextColor", "No");
            style5.SetAttribute("AffectNoteBody", "No");
            style5.SetAttribute("AffectSticky", "No");
            style5.SetAttribute("AffectSize", "No");
            style5.SetAttribute("AffectFade", "No");

            XmlElement isBold = doc.CreateElement("IsBold");
            isBold.InnerText = "Yes";
            style5.AppendChild(isBold);
            XmlElement fontSize = doc.CreateElement("FontSize");
            fontSize.InnerText = "12.0";
            style5.AppendChild(fontSize);

            noteStyles.AppendChild(style5);

            //style6
            XmlElement style6 = doc.CreateElement("Style");
            style6.SetAttribute("AffectFontStyle", "No");
            style6.SetAttribute("AffectAlignment", "No");
            style6.SetAttribute("Name", "Red Text");
            style6.SetAttribute("ID", "21A0294F-5BFE-4B05-86CE-55829FF709B1");
            style6.SetAttribute("AffectTextColor", "Yes");
            style6.SetAttribute("AffectNoteBody", "No");
            style6.SetAttribute("AffectSticky", "No");
            style6.SetAttribute("AffectSize", "No");
            style6.SetAttribute("AffectFade", "No");

            XmlElement textColor = doc.CreateElement("TextColor");
            textColor.InnerText = "1.0 0.0 0.0";
            style6.AppendChild(textColor);

            noteStyles.AppendChild(style6);

            //style7
            XmlElement style7 = doc.CreateElement("Style");
            style7.SetAttribute("AffectFontStyle", "No");
            style7.SetAttribute("AffectAlignment", "No");
            style7.SetAttribute("Name", "Yellow Bubble");
            style7.SetAttribute("ID", "1B254D45-C971-4054-AE33-706BF3F4DAD5");
            style7.SetAttribute("AffectTextColor", "No");
            style7.SetAttribute("AffectNoteBody", "Yes");
            style7.SetAttribute("AffectSticky", "No");
            style7.SetAttribute("AffectSize", "No");
            style7.SetAttribute("AffectFade", "No");

            XmlElement borderThickness7 = doc.CreateElement("BorderThickness");
            borderThickness7.InnerText = "1";
            style7.AppendChild(borderThickness7);
            XmlElement borderColor7 = doc.CreateElement("BorderColor");
            borderColor7.InnerText = "0.769436 0.762219 0.390143";
            style7.AppendChild(borderColor7);
            XmlElement fillColor7 = doc.CreateElement("FillColor");
            fillColor7.InnerText = "0.912963 0.894118 0.644541";
            style7.AppendChild(fillColor7);

            noteStyles.AppendChild(style7);

            scappleDocument.AppendChild(noteStyles);


            XmlElement uiSettings = doc.CreateElement("UISettings");
            XmlElement backgroundColor = doc.CreateElement("BackgroundColor");
            backgroundColor.InnerText = "1.0 0.988006 0.945006";
            XmlElement defaultFont = doc.CreateElement("DefaultFont");
            defaultFont.InnerText = "Helvetica";
            XmlElement defaultTextColor = doc.CreateElement("DefaultTextColor");
            defaultTextColor.InnerText = "0.0 0.0 0.0";

            uiSettings.AppendChild(backgroundColor);
            uiSettings.AppendChild(defaultFont);
            uiSettings.AppendChild(defaultTextColor);
            scappleDocument.AppendChild(uiSettings);

            XmlElement printSettings = doc.CreateElement("PrintSettings");
            printSettings.SetAttribute("VerticalPagination", "Auto");
            printSettings.SetAttribute("HorizontalPagination", "Clip");
            printSettings.SetAttribute("Orientation", "Portrait");
            printSettings.SetAttribute("RightMargin", "12.000000");
            printSettings.SetAttribute("BottomMargin", "12.000000");
            printSettings.SetAttribute("HorizontallyCentered", "Yes");
            printSettings.SetAttribute("ScaleFactor", "1.000000");
            printSettings.SetAttribute("PagesAcross", "1");
            printSettings.SetAttribute("PaperType", "iso-a4");
            printSettings.SetAttribute("PagesDown", "1");
            printSettings.SetAttribute("TopMargin", "12.000000");
            printSettings.SetAttribute("Collates", "Yes");
            printSettings.SetAttribute("PaperSize", "-1.000000,-1.000000");
            printSettings.SetAttribute("LeftMargin", "12.000000");
            printSettings.SetAttribute("VerticallyCentered", "Yes");

            scappleDocument.AppendChild(printSettings);

            string path = "C:/Users/Regen/Desktop/Scapple-learning/xmlFiles/note.scap";
            doc.Save(path);
            return path;
        }
    }
}
