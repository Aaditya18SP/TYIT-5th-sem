using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml.Linq;
using System.Xml;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /*---------------------------------------------------------------------------------------
     * USING XML TEXT READER AND WRITER
     ---------------------------------------------------------------------------------------*/

    // Write to XML
    protected void btnWriteToXml_Click(object sender, EventArgs e)
    {
        string file = Path.Combine(Request.PhysicalApplicationPath, "method1xml.xml");
        FileStream fs = new FileStream(file, FileMode.Create);

        XmlTextWriter w = new XmlTextWriter(fs,null);

        w.WriteStartDocument();

        w.WriteStartElement("All_Cars");

        w.WriteStartElement("car");

        w.WriteAttributeString("is_covertible", "false");
        w.WriteComment("THIS IS A COMMENT");

        w.WriteStartElement("brand");
        w.WriteString("Porsche");
        w.WriteEndElement();

        w.WriteStartElement("model");
        w.WriteString("gt3");
        w.WriteEndElement();

        w.WriteEndElement();


        w.WriteEndElement();
        w.WriteEndDocument();

        w.Close();

    }

    //Fetch from XML
    protected void btnFetchXml_Click(object sender, EventArgs e)
    {
        string file = Path.Combine(Request.PhysicalApplicationPath, "method1xml.xml");
        FileStream fs = new FileStream(file, FileMode.Open);
        XmlTextReader r = new XmlTextReader(fs);

        StringWriter writer = new StringWriter();

        while (r.Read())
        {
            if (r.NodeType == XmlNodeType.Whitespace) continue;

            if (r.Name != "")
            {
                writer.Write("<b>Type:</b>" + r.NodeType.ToString() + "<br/>");

                writer.Write("<b>Name of Tag:</b>" + r.Name +"<br/>");
            }

            if (r.Value != null)
            {
                writer.Write("<b>Type:</b>" + r.NodeType.ToString() + "<br/>");
                writer.Write("<b>Name of Tag:</b>" + r.Name + "<br/>");
                writer.Write("<b>Value of Tag:</b>" + r.Value + "<br/>");
            }

            if (r.AttributeCount > 0)
            {
                int i=0;
                while(i<r.AttributeCount){
                    r.MoveToAttribute(i);
                    writer.Write("<b>Attribute:</b>" + r.Name + " <b>Its Value</b>" +r.Value+"<br/>");
                    i++;
                }
            }


        }

        fs.Close();

        lbXmlDisp1.Text = writer.ToString();

    }


    /*---------------------------------------------------------------------------------------
     * USING XDOCUMENT
     ---------------------------------------------------------------------------------------*/

    //Write to xml
    protected void Button1_Click(object sender, EventArgs e)
    {
        string file=Path.Combine(Request.PhysicalApplicationPath,"xmlmethod2.xml");
        XDocument doc = new XDocument(
             new XDeclaration("1.0", "utf-8", null),
             new XElement("All_Cars",
                 new XComment("This is a comment"),
                 new XElement("Car",
                     new XAttribute("is_covertible","false"),
                     new XElement("brand","Porsche"),
                     new XElement("model","GT3")
                     )
                     )

            );
        doc.Save(file);
        
    }

    //fetch from xml
    protected void Button2_Click(object sender, EventArgs e)
    {
        string file = Path.Combine(Request.PhysicalApplicationPath, "xmlmethod2.xml");
        XDocument doc=XDocument.Load(file);

        List<Cars> all_cars = new List<Cars>();

        foreach (XElement ele in doc.Element("All_Cars").Elements("Car"))
        {
            Cars c1 = new Cars();
            c1.brand = (string)ele.Element("brand");
            c1.model = (string)ele.Element("model");

            all_cars.Add(c1);
        }

        GridView1.DataSource = all_cars;
        GridView1.DataBind();

        

    }

    public class Cars
    {
        public string brand { get; set; }
        public string model { get; set; }
    }
}