from xml.dom.minidom import parse
import xml.dom.minidom

# 使用minidom解析器打开 XML 文档
DOMTree = xml.dom.minidom.parse("C:/Users/Regen/Desktop/Scapple-learning/xmlFiles/test1.xml")
scappleDocument = DOMTree.documentElement
if scappleDocument.hasAttribute("ID"):
    print("Root element : %s" % scappleDocument.getAttribute("ID"))

# 在集合中获取所有<Notes>
wnotes = scappleDocument.getElementsByTagName("Notes")

# 在集合中获取所有<Note>
for _n in wnotes:
    notes = _n.getElementsByTagName("Note")
    print("*****Notes*****")

    for note in notes:
        print("[Note]")

        if note.hasAttribute("Width"):
            print("Width: %s" % note.getAttribute("Width"))
        if note.hasAttribute("FontSize"):
            print("FontSize: %s" % note.getAttribute("FontSize"))
        if note.hasAttribute("Position"):
            print("Position: %s" % note.getAttribute("Position"))

# 打印每个Note的详细信息

