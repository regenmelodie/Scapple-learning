using System;

namespace Scapple_write_xml
{
    class WriteXML
    {
        private void WriteToScap(string str)
        {
            Console.Write(str);
            return;
        }

        public void ScappleDocument()
        {
            WriteToScap("<ScappleDocument>\n");
            Notes();
            WriteToScap("\n");
            UISettings();
            WriteToScap("</ScappleDocument>\n");
            return;
        }

        private void Notes()
        {
            WriteToScap("<Notes>\n");
            Note();
            WriteToScap("</Notes>\n");
            return;
        }

        private void Note()
        {
            double width;
            int fontSize;
            int id;
            double position_x, position_y;

            width = 52.2827;
            fontSize = 13;
            id = 0;
            position_x = 331.2;
            position_y = 202.0;

            string widthString = "Width='" + width.ToString() + "' ";
            string fontSizeString = "FontSize='" + fontSize.ToString() + "' ";
            string idString = "ID='" + id.ToString() + "' ";
            string positionString = "Position='" + position_x.ToString() + "," + position_y.ToString() + "'";

            string str = "<Note " + widthString + fontSizeString + idString + positionString + ">\n";
            WriteToScap(str);

            Appearance();
            String();

            WriteToScap("</Note>\n");
            return;
        }

        private void Appearance()
        {
            WriteToScap("<Appearance>\n");
            Alignment();
            TextColor();
            Fill();
            Border();
            WriteToScap("</Appearance>\n");
            return;
        }

        private void Alignment()
        {
            WriteToScap("<Alignment>");
            string str = "Left";
            WriteToScap(str);
            WriteToScap("</Alignment>\n");
            return;
        }

        private void TextColor()
        {
            WriteToScap("<TextColor>");
            double a, b, c;

            a = 0.666667;
            b = 0.666667;
            c = 1.0;

            string str = a.ToString() + " " + b.ToString() + " " + c.ToString();
            WriteToScap(str);
            WriteToScap("</TextColor>\n");
            return;
        }

        private void Fill()
        {
            WriteToScap("<Fill>");
            double a, b, c;

            a = 0.941176;
            b = 1.0;
            c = 0.396078;

            string str = a.ToString() + " " + b.ToString() + " " + c.ToString();
            WriteToScap(str);
            WriteToScap("</Fill>\n");
            return;
        }

        private void Border()
        {
            double weight;
            string style;

            weight = 7;
            style = "Rounded";

            string weightString = "Weight='" + weight.ToString() + "' ";
            string styleString = "Style='" + style + "'";

            string str1 = "<Border " + weightString + styleString + ">";
            WriteToScap(str1);

            double a, b, c;

            a = 0.0;
            b = 1.0;
            c = 1.0;

            string str2 = a.ToString() + " " + b.ToString() + " " + c.ToString();
            WriteToScap(str2);

            WriteToScap("</Border>\n");
            return;
        }

        private void String()
        {
            WriteToScap("<String>");
            string str = "new";
            WriteToScap(str);
            WriteToScap("</String>\n");
            return;
        }


        private void UISettings()
        {
            WriteToScap("<UISettings>\n");
            BackgroundColor();
            DefaultFont();
            DefaultTextColor();
            WriteToScap("</UISettings>\n");
            return;
        }

        private void BackgroundColor()
        {
            WriteToScap("<BackgroundColor>");

            double a, b, c;
            a = 1.0;
            b = 0.988006;
            c = 0.945006;

            string str = a.ToString() + " " + b.ToString() + " " + c.ToString();
            WriteToScap(str);

            WriteToScap("</BackgroundColor>\n");
            return;
        }

        private void DefaultFont()
        {
            WriteToScap("<DefaultFont>");
            string str;
            str = "Helvetica";
            WriteToScap(str);
            WriteToScap("</DefaultFont>\n");
            return;
        }

        private  void DefaultTextColor()
        {
            WriteToScap("<DefaultTextColor>");
            double a, b, c;
            a = 0.0;
            b = 0.0;
            c = 0.0;
            string str = a.ToString() + " " + b.ToString() + " " + c.ToString();
            WriteToScap(str);
            WriteToScap("</DefaultTextColor>\n");
            return;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteXML writeXML = new WriteXML();
            writeXML.ScappleDocument();
            Console.ReadKey();
        }
    }
}
