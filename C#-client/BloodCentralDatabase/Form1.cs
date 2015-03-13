using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace BloodCentralDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bloodbanksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bloodbanksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bloodcentraldatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodcentraldatabaseDataSet.bloodbanks' table. You can move, or remove it, as needed.
            this.bloodbanksTableAdapter.Fill(this.bloodcentraldatabaseDataSet.bloodbanks);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //postRequest();
        }

        public void postRequest()
        {
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create("http://192.168.0.118:8080/BloodCentralDatabase/webresources/bcd.bloodbanks");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "";
            //string postData = System.IO.File.ReadAllText("send.xml");
           // string postData = "{\"a1Bnve\":5,\"a1Bpve\":8,\"a1nve\":2,\"a1pve\":4,\"a2Bnve\":6,\"a2Bpve\":8,\"a2nve\":6,\"a2pve\":8,\"address\":\"cgroad\",\"area\":\"abc\",\"b1pve\":6,\"bnve\":6,\"bpve\":8,\"city\":\"Surat\",\"contactDetails\":\"9727604855\",\"id\":\"LIO007\",\"incharge\":\"Nirav\",\"name\":\"lionsclub\",\"onve\":8,\"opve\":6,\"state\":\"Gujarat\"}";
            postData = "{";
            postData += "\"a1Bnve\":" + a1B_veTextBox.Text +",";
            postData += "\"a1Bpve\":" + a1B_veTextBox1.Text + ",";
            postData += "\"a1nve\":" + a1_veTextBox.Text + ",";
            postData += "\"a1pve\":" + a1_veTextBox1.Text + ",";
            postData += "\"a2Bnve\":" + a2B_veTextBox.Text + ",";
            postData += "\"a2Bpve\":" + a2B_veTextBox1.Text + ",";
            postData += "\"a2nve\":" + a2_veTextBox.Text + ",";
            postData += "\"a2pve\":" + a2_veTextBox1.Text + ",";
            postData += "\"address\":" + "\"" + addressTextBox.Text + "\"" + ",";
            postData += "\"area\":" + "\"" + areaTextBox.Text + "\"" + ",";
            postData += "\"b1pve\":" + b1_veTextBox.Text + ",";
            postData += "\"bnve\":" + b_veTextBox.Text + ",";
            postData += "\"bpve\":" + b_veTextBox1.Text + ",";
            postData += "\"city\":" + "\"" + cityTextBox.Text + "\"" + ",";
            postData += "\"contactDetails\":" + "\"" + contactDetailsTextBox.Text + "\"" + ",";

            string id = "";
            if (nameTextBox.Text != "")
            {
                id = nameTextBox.Text.Substring(0, 3);
                id += "001";
                id = id.ToUpper();
            }

            postData += "\"id\":" + "\"" + id + "\"" + ",";
            postData += "\"incharge\":" + "\"" + inchargeTextBox.Text + "\"" + ",";
            postData += "\"name\":" + "\"" + nameTextBox.Text + "\"" + ",";
            postData += "\"onve\":" + o_veTextBox.Text + ",";
            postData += "\"opve\":" + o_veTextBox1.Text + ",";
            postData += "\"state\":" + "\"" + stateTextBox.Text + "\"" ;
            postData += "}";

            System.IO.File.WriteAllText(@"received.json", postData);

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
            WebResponse response = request.GetResponse();
            // Display the status.
            //label5.Text = ((HttpWebResponse)response).StatusDescription;
            responseBox.Text = ((HttpWebResponse)response).StatusDescription + "   ";
            if (responseBox.Text == "No Content") responseBox.Text = "Data Reached!";
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            responseBox.Text += responseFromServer;
            if (responseBox.Text == "No Content") responseBox.Text = "Data Reached!";
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            postRequest();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2().ShowDialog();
            this.Dispose();    
        }

    }
}
