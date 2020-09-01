using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace Scapple_Real_Final
{
    public partial class Form1 : Form
    {
        private XmlDocument doc;
        private string path;
        private Dictionary<string, TextBox> textBoxs; //记录新增的<Note>，<id, Note>
        private bool isMouseDown = false;
        private Point mouseOffset; //记录鼠标指针的坐标
        private TextBox current_textBox;
        private int id = -1; //记录Note的ID，本程序为用户创建的Note自动分配ID
        private Dictionary<string, ArrayList> connects; //记录节点间的关系，<id, connect_id>，为每个节点创建一个ArrayList，记录其关联节点的id
        private Graphics g; //画布
        private Pen pen;
        private Label label; //在未新建文件时显示

        public Form1()
        {
            InitializeComponent();
            textBoxs = new Dictionary<string, TextBox>();
            connects = new Dictionary<string, ArrayList>();   
            
            g = Graphics.FromHwnd(this.Handle);
            pen = new Pen(Color.Gray, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            
            label = new Label();
            label.Text = "Please create a file.";
            label.Location = new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width/4, Screen.PrimaryScreen.WorkingArea.Height/4);
            label.Size = new Size(200, 30);
            this.Controls.Add(label);
        }

        private void New_Click(object sender, EventArgs e)
        {
            label.Hide();

            //创建XML文档
            doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "no");
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
        }

        private void choose_path()
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Scapple File|*.scap"; //筛选：允许类型为.scap的文件
            saveFileDialog.Title = "Save a Scapple File";
            saveFileDialog.RestoreDirectory = true; //保存对话框是否记忆上次打开的目录
            saveFileDialog.CheckPathExists = true; //检查目录
            saveFileDialog.FileName = "Untitled"; //设置默认文件名

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                doc.Save(path);
                MessageBox.Show(this, "保存成功！", "提示");
            }
        }

        private void add_note()
        {
            //在XML里新建节点，写Note
            XmlNode scappleDocument = doc.SelectSingleNode("ScappleDocument");  //查找<ScappleDocument>
            XmlNode notes = scappleDocument.SelectSingleNode("Notes");

            //清空<Notes>的子节点
            notes.RemoveAll();

            //创建<Note>节点
            foreach (var item in textBoxs)
            {
                XmlElement note = doc.CreateElement("Note"); //创建一个<Note>节点

                //设置该节点属性
                note.SetAttribute("Width", item.Value.Size.Width.ToString());
                note.SetAttribute("FontSize", item.Value.Font.Size.ToString());
                note.SetAttribute("ID", item.Value.Name);
                note.SetAttribute("Position", item.Value.Location.X.ToString() + "," + item.Value.Location.Y.ToString());

                XmlElement appearance = doc.CreateElement("Appearance");

                XmlElement alignment = doc.CreateElement("Alignment");
                alignment.InnerText = "Left";

                XmlElement textColor = doc.CreateElement("TextColor");
                decimal textColor_r = (decimal)item.Value.ForeColor.R / 255;
                decimal textColor_g = (decimal)item.Value.ForeColor.G / 255;
                decimal textColor_b = (decimal)item.Value.ForeColor.B / 255;
                string textColorR, textColorG, textColorB;
                if (textColor_r == (int)textColor_r) textColorR = textColor_r.ToString() + ".0";
                else textColorR = Math.Round(textColor_r, 6, MidpointRounding.ToEven).ToString();
                if (textColor_g == (int)textColor_g) textColorG = textColor_g.ToString() + ".0";
                else textColorG = Math.Round(textColor_g, 6, MidpointRounding.ToEven).ToString();
                if (textColor_b == (int)textColor_b) textColorB = textColor_b.ToString() + ".0";
                else textColorB = Math.Round(textColor_b, 6, MidpointRounding.ToEven).ToString();
                textColor.InnerText = textColorR + " " + textColorG + " " + textColorB;

                XmlElement fill = doc.CreateElement("Fill");
                decimal fill_r = (decimal)item.Value.BackColor.R / 255;
                decimal fill_g = (decimal)item.Value.BackColor.G / 255;
                decimal fill_b = (decimal)item.Value.BackColor.B / 255;
                string fillR, fillG, fillB;
                if (fill_r == (int)fill_r) fillR = fill_r.ToString() + ".0";
                else fillR = Math.Round(fill_r, 6, MidpointRounding.ToEven).ToString();
                if (fill_g == (int)fill_g) fillG = fill_g.ToString() + ".0";
                else fillG = Math.Round(fill_g, 6, MidpointRounding.ToEven).ToString();
                if (fill_b == (int)fill_b) fillB = fill_b.ToString() + ".0";
                else fillB = Math.Round(fill_b, 6, MidpointRounding.ToEven).ToString();
                fill.InnerText = fillR + " " + fillG + " " + fillB;

                XmlElement border = doc.CreateElement("Border");
                border.SetAttribute("Weight", "0");
                border.SetAttribute("Style", "Rounded");

                appearance.AppendChild(alignment); //添加到<Appearance>节点中
                appearance.AppendChild(textColor);
                appearance.AppendChild(fill);
                appearance.AppendChild(border);

                XmlElement _string = doc.CreateElement("String");
                _string.InnerText = item.Value.Text;

                XmlElement connectedNoteIDs = doc.CreateElement("ConnectedNoteIDs");
                connectedNoteIDs.InnerText = string.Join(",", connects[item.Key].ToArray());

                note.AppendChild(appearance);
                note.AppendChild(_string);
                note.AppendChild(connectedNoteIDs);

                notes.AppendChild(note);
            }

            scappleDocument.AppendChild(notes);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            add_note();

            if (path == null)
            {
                choose_path();
            }
            else
            {
                doc.Save(path);
                MessageBox.Show(this, "保存成功！", "提示");
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            add_note();
            choose_path();
        }

        private void textBox_MouseDown(object sender, MouseEventArgs e) //选中当前节点，屏幕显示当前节点的数据
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset.X = e.X;
                mouseOffset.Y = e.Y;
                isMouseDown = true;

                //跳转到当前节点
                TextBox _textBox = (TextBox)sender;
                current_textBox = textBoxs[_textBox.Name];

                //显示当前节点的Position
                label_Location.Text = current_textBox.Location.ToString();
            }
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int left = current_textBox.Left + e.X - mouseOffset.X;
                int top = current_textBox.Top + e.Y - mouseOffset.Y;
                current_textBox.Location = new Point(left, top);
                label_Location.Text = current_textBox.Location.ToString();
                
                draw_line();
            }
        }

        private void textBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;

                //修改节点的位置信息
                textBoxs[current_textBox.Name].Location = current_textBox.Location;
                label_Location.Text = current_textBox.Location.ToString();

            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBoxs[current_textBox.Name].Text = current_textBox.Text;
            //MessageBox.Show(current_textBox.Text);
        }
        
        private void draw_line()
        {
            g.Clear(this.BackColor);

            foreach (var item in connects)
            {
                foreach (object o in item.Value)
                {
                    Point a = new Point();
                    Point b = new Point();
                    a.X = textBoxs[item.Key].Location.X + textBoxs[item.Key].Size.Width / 2;
                    a.Y = textBoxs[item.Key].Location.Y + textBoxs[item.Key].Size.Height / 2;
                    b.X = textBoxs[o.ToString()].Location.X + textBoxs[o.ToString()].Size.Width / 2;
                    b.Y = textBoxs[o.ToString()].Location.Y + textBoxs[o.ToString()].Size.Height / 2;
                    g.DrawLine(pen, a, b);
                }

            }
        }

        private void new_note(int location_x, int location_y)
        {
            current_textBox = new TextBox();
            id += 1;
            current_textBox.Name = id.ToString(); //textBox的Name属性就是Note的id字符串
            current_textBox.Text = "New Note";
            current_textBox.Size = new System.Drawing.Size(90, 26);
            current_textBox.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            current_textBox.Location = new System.Drawing.Point(location_x, location_y);
            current_textBox.TabStop = false;

            //新建空关联节点ArrayList，并插入节点关系Dictionary
            ArrayList array = new ArrayList();
            connects.Add(current_textBox.Name, array);

            current_textBox.MouseDown += new MouseEventHandler(textBox_MouseDown);
            current_textBox.MouseMove += new MouseEventHandler(textBox_MouseMove);
            current_textBox.MouseUp += new MouseEventHandler(textBox_MouseUp);
            current_textBox.TextChanged += new EventHandler(textBox_TextChanged);

            label_Location.Text = current_textBox.Location.ToString();

            this.Controls.Add(current_textBox);
            textBoxs.Add(current_textBox.Name, current_textBox);
        }

        private void NewNote_Click(object sender, EventArgs e)
        {
            new_note(150, 150);
            current_textBox.Location = new System.Drawing.Point(150, 150);
        }
        
        private void ChangeTextColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            current_textBox.ForeColor = colorDialog.Color;
            textBoxs[current_textBox.Name].ForeColor = current_textBox.ForeColor;
        }

        private void changeFillColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            current_textBox.BackColor = colorDialog.Color;
            textBoxs[current_textBox.Name].BackColor = current_textBox.BackColor;
        }

        private void OnLeft_Click(object sender, EventArgs e)
        {
            TextBox old_textBox = current_textBox;

            new_note(old_textBox.Location.X - 100, old_textBox.Location.Y);

            connects[old_textBox.Name].Add(current_textBox.Name);
            connects[current_textBox.Name].Add(old_textBox.Name);

            draw_line();
        }

        private void OnRight_Click(object sender, EventArgs e)
        {
            TextBox old_textBox = current_textBox;

            new_note(old_textBox.Location.X + 200, old_textBox.Location.Y);

            connects[old_textBox.Name].Add(current_textBox.Name);
            connects[current_textBox.Name].Add(old_textBox.Name);

            draw_line();
        }

        private void Above_Click(object sender, EventArgs e)
        {
            TextBox old_textBox = current_textBox;

            new_note(old_textBox.Location.X, old_textBox.Location.Y - 40);

            connects[old_textBox.Name].Add(current_textBox.Name);
            connects[current_textBox.Name].Add(old_textBox.Name);

            draw_line();
        }

        private void Below_Click(object sender, EventArgs e)
        {
            TextBox old_textBox = current_textBox;

            new_note(old_textBox.Location.X, old_textBox.Location.Y + 40);

            connects[old_textBox.Name].Add(current_textBox.Name);
            connects[current_textBox.Name].Add(old_textBox.Name);

            draw_line();
        }

        private void Bigger_Click(object sender, EventArgs e)
        {
            current_textBox.Font = new Font("Times New Roman", current_textBox.Font.Size + 1, FontStyle.Regular);
        }

        private void Smaller_Click(object sender, EventArgs e)
        {
            current_textBox.Font = new Font("Times New Roman", current_textBox.Font.Size - 1, FontStyle.Regular);
        }
    }
}
