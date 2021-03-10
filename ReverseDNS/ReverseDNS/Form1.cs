using System;
using System.Windows.Forms;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ReverseDNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string domainList;
        public static string ipList;
        public static string notMatchingIPs;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IPAddress.Text))
            {
                MessageBox.Show("Please enter an IP Address!");
                return;
            }
            
            List<string> ipsQueried = new List<string>();
            List<string> ipsResolved = new List<string>();

            foreach (var ip in IPAddress.Lines)
            {
                if (!IsValidIP(ip))
                {
                    MessageBox.Show("You have entered an Invalid IP Address!!!");
                    return;
                }
                               
                if (noBlanks(ip))
                {
                    try {

                        IPHostEntry value = Dns.GetHostEntry(ip);
                        string hName = value.HostName;
                        ipsQueried.Add(ip);

                        domainList += hName + Environment.NewLine;
                    }
                    catch
                    {
                        MessageBox.Show("IP is not setup!!", ip);
                    }

                }
            }

            Domain.Text = domainList;
            DomCheck.Text = Domain.Text;


            foreach (var domain in DomCheck.Lines)
            {
                //try/catch placed inside foreach loop so if an exception occurs, the loop will continue

                try
                {
                    if (noBlanks(domain))
                    {
                        IPHostEntry finalIP = Dns.GetHostEntry(domain);
                        string ipResolvedFromDomain = finalIP.AddressList[0].ToString();
                        ipsResolved.Add(ipResolvedFromDomain);
                        ipList += ipResolvedFromDomain + Environment.NewLine;
                    }
                }
    
            catch
            {

            }
            IPResolve.Text = ipList;
        }  

            var firstNotSecond = ipsQueried.Except(ipsResolved).ToList();
            notMatching.Text = displayNonResolvingIps(firstNotSecond);
    }


        private void WriteText_Click(object sender, EventArgs e)
        {
                string path = @"c:\testing\IPsNotResolving.txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(notMatching.Text);
                }

                written.Visible = true;
                written.Text = "complete";
                written.ForeColor = System.Drawing.Color.Green;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public static string displayNonResolvingIps(List<string> notResolving)
        {
            return string.Join(Environment.NewLine, notResolving.ToArray());
        }

        public bool TheyMatch(string a, string b)
            {
                if (a == b)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

        public bool IsValidIP(string text)
        {
            if (text != "")
            {


                IPAddress test;
                return System.Net.IPAddress.TryParse(text, out test);
            }

            else
            {
                return true;
            }
        }

        public bool noBlanks(string word)
            {
                if (word != "")
                {
                    return true;
                }

                else
                {
                    return false;
                }
             }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearForm(this);
            domainList = "";
            ipList = "";
        }
       
        private void clearForm(Control control)
        {
            foreach(Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                    written.Visible = false;
                }
            }
        }  
    }
}



   




