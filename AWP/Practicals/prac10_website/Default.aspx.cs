using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //xmlTextReadermethod();
    }

    //---------------------WHEN FETCH BUTTON FOR METHOD1 IS CLICKED-----------------------
    protected void btnFetchMethod1_Click(object sender, EventArgs e)
    {
        xmlTextReadermethod();
    }
    //---------------------WHEN WRITE BUTTON FOR METHOD1 IS CLICKED-----------------------
    protected void btnWriteMethod1_Click(object sender, EventArgs e)
    {
        xmlTextWriterMethod();
    }
    //---------------------WHEN FETCH BUTTON FOR METHOD2 IS CLICKED-----------------------
    protected void btnFetchMethod2_Click(object sender, EventArgs e)
    {

    }
    //---------------------WHEN WRITE BUTTON FOR METHOD2 IS CLICKED-----------------------

    protected void btnWriteMethod2_Click(object sender, EventArgs e)
    {

    }


    //-----------------------CUSTOM FUNCTIONS---------------------------
    
    //1.fetch from xml using xmlreadermethod()

    protected void xmlTextReadermethod()
    {
        //get the absolute path of the xml file
        string file = Path.Combine(Request.PhysicalApplicationPath,"cars_xml.xml"); 

        //open the file
        FileStream fs = new FileStream(file, FileMode.Open);

        //create object of XmlTextReader 
        XmlTextReader r = new XmlTextReader(fs);

        //an object to combine the strings
        StringWriter writer = new StringWriter();

        //read the xml file
        while (r.Read())
        {
            //check if the nodetype is a whitespace character
            if (r.NodeType == XmlNodeType.Whitespace)
            {
                continue;
            }

            //if the character is not whitespace

            //if the nodetype is a element
            if(r.Name != "")
            {
                writer.Write("<b>Type:</b>");
                writer.Write(r.NodeType.ToString());
                writer.Write("<br/>");
                writer.Write("<b>Tag Name:</b>");
                writer.Write(r.Name);
            }

            //if the TAG has a value such as text
            if (r.Value != "")
            {
                writer.Write("<br/>");
                writer.Write("<b>Type:</b>");
                writer.Write(r.NodeType.ToString());
                writer.Write("<br/>");
                writer.Write("<b>Value of tag:</b>");
                writer.Write(r.Value);
            }

            //if the tag has attributes

            if (r.AttributeCount > 0)
            {
                
                //loop through all the attributes

                for (int i = 0; i < r.AttributeCount; i++)
                {
                    writer.Write("<br/>");
                    writer.Write("<b>Attribute :</b>");
                     
                    //move to the attribute
                    r.MoveToAttribute(i);

                    //get the name and value of attribute
                    writer.Write("attribute name: " + r.Name);
                    writer.Write("<br/> attribute value :" + r.Value);

                    //or simply get the value of attribute without moving to it
                    writer.Write(r.GetAttribute(i));

                }
                writer.Write("</br>");
            }

            writer.Write("</br>");
        }
        
        fs.Close();

        lbDetails.Text = writer.ToString();
    }


    //2. Write to an XML file using XMLTextWriter

    protected void xmlTextWriterMethod()
    {
        string file = Path.Combine(Request.PhysicalApplicationPath, "XMLfile_to_write_to_method_1.xml");
        FileStream fs = new FileStream(file, FileMode.Create);
        XmlTextWriter w = new XmlTextWriter(fs, null); //2nd parameter is encoding

        w.WriteStartDocument();

        w.WriteStartElement("All_Cars");

        w.WriteComment(" This is the root tag");

        //first car
        w.WriteStartElement("car");
        w.WriteAttributeString("is_Convertible", "false");
        w.WriteAttributeString("Car_type", "sedan");

        w.WriteStartElement("Brand");
        w.WriteString("Porsche");
        w.WriteEndElement();

        w.WriteStartElement("Model");
        w.WriteString("Panamera");
        w.WriteEndElement();

        w.WriteStartElement("hp");
        w.WriteString("500hp");
        w.WriteEndElement();

        w.WriteEndElement();


        //second car
        w.WriteStartElement("Brand");
        w.WriteString("Ferrari");
        w.WriteEndElement();

        w.WriteStartElement("Model");
        w.WriteString("296 GTS");
        w.WriteEndElement();

        w.WriteStartElement("hp");
        w.WriteString("800hp");
        w.WriteEndElement();


        //end the <All Cars> tag
        w.WriteEndElement();

        //end the document
        w.WriteEndDocument();

        //close the stream
        w.Close();

        //Display message when written successfully
        Response.Write("Written Successfully");
    }

}