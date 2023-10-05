using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using System.Diagnostics;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //xmlTextReadermethod();
    }

    //---------------------WHEN FETCH BUTTON FOR METHOD1 IS CLICKED-----------------------
    protected void btnFetchMethod1_Click(object sender, EventArgs e)
    {
        readUsingXmlTextReader();
    }
    //---------------------WHEN WRITE BUTTON FOR METHOD1 IS CLICKED-----------------------
    protected void btnWriteMethod1_Click(object sender, EventArgs e)
    {
        writeUsingXmlTextWriter();
    }
    //---------------------WHEN FETCH BUTTON FOR METHOD2 IS CLICKED-----------------------
    protected void btnFetchMethod2_Click(object sender, EventArgs e)
    {
        readUsingXDocument();
    }
    //---------------------WHEN WRITE BUTTON FOR METHOD2 IS CLICKED-----------------------

    protected void btnWriteMethod2_Click(object sender, EventArgs e)
    {
        writeUsingXDocument();
    }


    //-----------------------CUSTOM FUNCTIONS---------------------------
    
    //1.fetch from xml using xmlreadermethod()

    protected void readUsingXmlTextReader()
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

    protected void writeUsingXmlTextWriter()
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

        w.WriteEndElement(); //ends the <car> tag

        //end the <All Cars> tag
        w.WriteEndElement();

        //end the document
        w.WriteEndDocument();

        //close the stream
        w.Close();

        //Display message when written successfully
        Response.Write("Written Successfully");
    }


    //3. Read XML file using XDocument

    protected void readUsingXDocument()
    {
        //absolute path of the file to read
        string file = Path.Combine(Request.PhysicalApplicationPath, "cars_xml.xml"); 

        //Create a list of Car objectS
        List<Car> all_cars = new List<Car>();
        

        //load the file
        XDocument doc = XDocument.Load(file);

        //WE CAN ALSO ADD ELEMENTS TO THE XML
        // this is not added to the file but its added in the memory
        XElement car_to_added = new XElement("car",
            new XAttribute("car_type", "race_car"),
            new XElement("brand", "Ferrari"),
            new XElement("hp", "900hp"),
            new XElement("name", "FXXK evo"),
            new XElement("color", "Blue")
            );
        doc.Element("All_cars").Add(car_to_added);


        //Loop through the elements in <car> tag which is under the <All_cars> tag
        foreach (XElement element in doc.Element("All_cars").Elements("car"))
        {
            //create an object of CAR class
            Car newcar = new Car();

            //set the values of the attribute
            newcar.brand = (string) element.Element("brand");
            newcar.hp = (string) element.Element("hp");
            newcar.color = (string) element.Element("color"); //dont use ToString() else it gives null reference here
            newcar.car_type = (string)element.Element("car_type");

            if (element.Attribute("car_type") != null)
            {
                newcar.car_type = (string)element.Attribute("car_type");
            }

            //add the object to the list
            all_cars.Add(newcar);
        }

        //Bind the data to the gridview
        gridCars.DataSource = all_cars;
        gridCars.DataBind();
  
    }

    //4. Write to XML file using XDocument

    protected void writeUsingXDocument()
    {
        //absolute path of the file to read
        string file = Path.Combine(Request.PhysicalApplicationPath, "XMLfile_writeUsingXDOC_method2.xml");


        XDocument doc = new XDocument(
            new XDeclaration("1.0", null, "yes"),
            new XElement("All_Cars",
                new XComment("Above tag is the Root Tag"),
                new XElement("car",
                    new XAttribute("is_Convertible", "false"),
                    new XAttribute("Car_type", "sports_car"),
                    new XElement("Brand", "Porsche"),
                    new XElement("Model", "911 Carrera 4S"),
                    new XElement("hp", "400hp")
                ),
                new XComment("second car"),
                new XElement("car",
                    new XAttribute("is_Convertible", "true"),
                    new XAttribute("Car_type", "race_car"),
                    new XElement("Brand", "Pagani"),
                    new XElement("Model", "Zonda R"),
                    new XElement("hp", "700hp")
                    )
                )
                );

        //save the file--> the stream is opened automatically, data is written and stream is closed automatically
        doc.Save(file);

        //Display message when written successfully
        Response.Write("Written Successfully");
   
    }


}

//--------------------------------------------------CUSTOM CLASSES------------------------------------------
public class Car
{
    //These should be ATTRIBUTES and NOT VARIABLES;
    public string brand{get; set;}
    public string hp{get; set;}
    public string color{get; set;}
    public string car_type{get; set;}

   
}