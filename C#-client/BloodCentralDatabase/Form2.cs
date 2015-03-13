using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;

namespace BloodCentralDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bloodGroup = "";
            switch (comboBox1.Text)
            {
                case "A1 Negative (A1 -ve)": bloodGroup = "a1nve";
                    break;
                case "A1 Positive (A1 +ve)": bloodGroup = "a1pve";
                    break;
                case "A1B Negative (A1B -ve)": bloodGroup = "a1Bnve";
                    break;
                case "A1B Positive (A1B +ve)": bloodGroup = "a1Bpve";
                    break;
                case "A2 Negative (A2 -ve)": bloodGroup = "a2nve";
                    break;
                case "A2 Positive (A2 +ve)": bloodGroup = "a2pve";
                    break;
                case "A2B Negative (A2B -ve)": bloodGroup = "a2Bnve";
                    break;
                case "A2B Positive (A2B +ve)": bloodGroup = "a2Bpve";
                    break;
                case "B Negative (B -ve)": bloodGroup = "bnve";
                    break;
                case "B Positive (B +ve)": bloodGroup = "bpve";
                    break;
                case "B1 Positive (B1 +ve)": bloodGroup = "b1pve";
                    break;
                case "O Negative (O -ve)": bloodGroup = "onve";
                    break;
                case "O Positive (O +ve)": bloodGroup = "opve";
                    break;
                default: bloodGroup = "opve";
                    break;

                    
            }
            getRequest(bloodGroup);
        }

        public void getRequest(string bloodGroup)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create("http://localhost:8080/BloodCentralDatabase/webresources/bcd.bloodbanks/PRA001");
            req.ContentType = "application/xml";
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string responseString = sr.ReadToEnd().Trim();
            System.IO.File.WriteAllText(@"receivedData.xml", responseString);

            XmlTextReader reader = new XmlTextReader("receivedData.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == bloodGroup)
                        {
                            //int value = Convert.ToInt32(reader.Value);
                            //value += 1;
                        }

                        break;
                }

            }
            WebRequest request = WebRequest.Create("http://192.168.0.118:8080/BloodCentralDatabase/webresources/bcd.bloodbanks");
            // Set the Method property of the request to POST.
            request.Method = "PUT";
            // Create POST data and convert it to a byte array.
            //string postData = "";
            //string postData = System.IO.File.ReadAllText("send.xml");
            string postData = "{\"a1Bnve\":5,\"a1Bpve\":8,\"a1nve\":2,\"a1pve\":4,\"a2Bnve\":6,\"a2Bpve\":8,\"a2nve\":6,\"a2pve\":8,\"address\":\"cgroad\",\"area\":\"abc\",\"b1pve\":6,\"bnve\":6,\"bpve\":9,\"city\":\"Surat\",\"contactDetails\":\"9727604855\",\"id\":\"PRA001\",\"incharge\":\"Nirav\",\"name\":\"lionsclub\",\"onve\":8,\"opve\":6,\"state\":\"Gujarat\"}";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/json";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            //WebResponse response = request.GetResponse();
            // Display the status.
            //label5.Text = ((HttpWebResponse)response).StatusDescription;
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            //response.Close();


        }
    }
}
