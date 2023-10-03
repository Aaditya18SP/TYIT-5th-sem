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
        xmlTextReadermethod();
    }

    //-----------------------CUSTOM EVENTS---------------------------
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
                writer.Write("<b>Tag Name:</b>");
                writer.Write(r.Name);
            }

            //if the TAG has a value such as text
            if (r.Value != "")
            {
                writer.Write("<b>Type:</b>");
                writer.Write(r.NodeType.ToString());
                writer.Write("<b>Value of tag:</b>");
                writer.Write(r.Value);
            }

            //if the tag has attributes

            if (r.AttributeCount > 0)
            {
                
                //loop through all the attributes

                for (int i = 0; i < r.AttributeCount; i++)
                {
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
}