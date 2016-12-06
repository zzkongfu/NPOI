﻿using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Wordprocessing
{
    public class FootnotesDocument
    {
        private CT_Footnotes footnotes = null;

        public FootnotesDocument()
        {
            footnotes = new CT_Footnotes();
        }

        public static FootnotesDocument Parse(XDocument doc, XmlNamespaceManager namespaceMgr)
        {
            CT_Footnotes obj = CT_Footnotes.Parse(doc.Document.Root, namespaceMgr);
            return new FootnotesDocument(obj);
        }

        public FootnotesDocument(CT_Footnotes footnotes)
        {
            this.footnotes = footnotes;
        }

        public CT_Footnotes Footnotes
        {
            get
            {
                return this.footnotes;
            }
        }

        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                this.footnotes.Write(sw);
            }
        }
    }
}