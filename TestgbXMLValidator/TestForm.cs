﻿using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace TestgbXMLValidator
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        { 
            //validate gbxml file against the 6.01 gbXML XSD
            ValidategbXML_601();
        }


        /// <summary>
        /// Validate gbxml file against the 6.01 gbXML XSD
        /// </summary>
        private void ValidategbXML_601()
        {
            XmlDocument xml = new XmlDocument();
            //Overwrite the following test gbXML file with yours
            xml.Load(@"data/TestgbXML.xml");
            //leave the following as is
            xml.Schemas.Add(null, @"data/GreenBuildingXML_Ver6.01.xsd");
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            xml.Validate(eventHandler);
        }
           

        /// <summary>
        /// Output the validation results (errors) to the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }
}
