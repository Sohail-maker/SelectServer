using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QBPOSXMLRPLib;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace SelectServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnfindServers_Click(object sender, EventArgs e)
        {
            string serverName;
            string DataName;
            string version;
            List<string> servers = new List<string>();
            RequestProcessor rp = new RequestProcessor();

            XDocument document = XDocument.Parse(rp.POSServers(false));
            foreach (XElement element in document.Descendants("POSServer"))
            {
                serverName = element.Element("ServerName").Value;
                DataName = element.Element("CompanyName").Value;
                version = element.Element("Version").Value;
                servers.Add($"{serverName} - {DataName} - {version}");
            }
            CboxServers.DataSource = servers;
            btnPosSave.Enabled = true;

        }

        private void btnPosSave_Click(object sender, EventArgs e)
        {
            string[] selected = CboxServers.SelectedItem.ToString().Split('-');
            string connectionString = ($"Computer Name={selected[0].Trim()};Company Data={selected[1].Trim()};Version={selected[2].Trim()};");
            string path = Environment.CurrentDirectory + @"\source\config";
            XDocument document;
            try
            {
                if (File.Exists(path))
                {
                    document = XDocument.Load(path);

                }
                else document = new XDocument();

                XElement elconfig = document.Element("Configurations");
                if (checkelemnt(elconfig) == false)
                {
                    document.Add(new XElement("Configurations", new XElement("POSServer",connectionstring)));
                    document.Save(path);
                }
                 else
                 {

                if (elconfig.Element("POSServer") == null)
                {
                    elconfig.Add(new XElement("POSServer", connectionString));
                }
                else elconfig.Element("POSServer").Value = connectionString;
}
                document.Save(path);

            }
            catch (NullReferenceException)
            {

            }



        }

        bool checkelemnt(XElement element)
        {
            bool ret;
            if (element != null)
            {
                ret = true;
            }
            else ret = false;

            return ret;


    }


    }
}

