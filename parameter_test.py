from xml.dom.minidom import parse
import xml.dom.minidom

# 使用minidom解析器打开 XML 文档
DOMTree = xml.dom.minidom.parse("C:/Users/Regen/Desktop/Scapple-learning/xmlFiles/test1.scap")
scappleDocument = DOMTree.documentElement
if scappleDocument.hasAttribute("ID"):
    print("Root element : %s" % scappleDocument.getAttribute("ID"))

if scappleDocument.getElementsByTagName("Notes"): # <ScappleDocument>中有<Notes>
    wnotes = scappleDocument.getElementsByTagName("Notes") # 在集合中获取所有<Notes>

    # 遍历集合中所有<Note>
    for _n in wnotes:
        if _n.getElementsByTagName("Note"): # <Notes>中有<Note>
            notes = _n.getElementsByTagName("Note")
            print("***Notes:")

            for note in notes:
                print("******Note:")

                if note.hasAttribute("Width"):
                    print("******(Width: %s" % note.getAttribute("Width"))
                if note.hasAttribute("FontSize"):
                    print("******(FontSize: %s" % note.getAttribute("FontSize"))
                if note.hasAttribute("Position"):
                    print("******(Position: %s" % note.getAttribute("Position"))

                if note.getElementsByTagName("Appearance"):
                    appearance = note.getElementsByTagName('Appearance')[0]
                    print("*********Appearance:")
                    if appearance.getElementsByTagName("Alignment"):
                        alignment = appearance.getElementsByTagName('Alignment')[0]
                        print("************Alignment: %s" % alignment.childNodes[0].data)
                    if appearance.getElementsByTagName("TextColor"):
                        textColor = appearance.getElementsByTagName('TextColor')[0]
                        print("************TextColor: %s" % textColor.childNodes[0].data)
                    if appearance.getElementsByTagName("Border"):
                        border = appearance.getElementsByTagName('Border')[0]
                        print("************Border:")
                        if border.hasAttribute("Weight"):
                            print("************(Weight: %s" % border.getAttribute("Weight"))
                        if border.hasAttribute("Style"):
                            print("************(Style: %s" % border.getAttribute("Style"))
                
                if note.getElementsByTagName("String"):
                    string = note.getElementsByTagName('String')[0]
                    print("*********String: %s" % string.childNodes[0].data)

                if note.getElementsByTagName("ConnectedNoteIDs"):
                    connectedNoteIDs = note.getElementsByTagName('ConnectedNoteIDs')[0]
                    print("*********ConnectedNoteIDs: %s" % connectedNoteIDs.childNodes[0].data)