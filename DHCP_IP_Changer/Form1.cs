using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace DHCP_IP_Changer
{
    public partial class IP_Changer_Form : Form
    {
        string []used_IP = new string[3];
        string new_IP;
        static int index=0;
        public IP_Changer_Form()
        {
            InitializeComponent();
            used_IP[0] = "";used_IP[1] = "";//assign null values to old IP during start of application
        }

       

        private  void IP_Changer_Form_Load(object sender, EventArgs e)
        {
            used_IP[index] = GetLocalIPv4(NetworkInterfaceType.Ethernet);//store current IP as old IP for further comparison
            lbl_old_IP.Text = used_IP[index];

            lbl_wifi_IP.Text = GetLocalIPv4(NetworkInterfaceType.Wireless80211);//show wifi IP
            lease_info("lz_ob.bat","Lease Obtained At",lbl_leaseObtained);//for old IP
            lease_info("lz_ex.bat", "Lease Expires At ", lbl_leaseEnds);//for old IP

        }

        static int count_ethernet = 0;
        int i;
        private async void btn_change_ethernet_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "change_IP";

            process.StartInfo = startInfo;
            process.Start();

            await Task.Delay(10000);
            new_IP = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            lbl_newIP.Text = new_IP;//load the new IP
            lbl_old_IP.Text = "";//de-allocate old IP to avoid text_overlapping
            string text = "";
            for (i = 0; i < used_IP.Length; i++)
            {
                text += (used_IP[i] + ",\n");
                if (new_IP.Equals(used_IP[i]))//IP  renewed to already-used IP
                   break;
            }
            text = text.Substring(0, text.LastIndexOf(','));//remove comma from the last-entered-IP
            lbl_old_IP.Text = text;
            if (i < used_IP.Length)//loop exited before completion
            {// MessageBox.Show("Ethernet IP refreshed to already-used IP");
            }
            else//loop executed without "break"
            {
                used_IP[++index] = new_IP;
                MessageBox.Show("Ethernet IP Changed successfully");
            }

            //reload lease info for the new IP
            lease_info("lz_ob.bat", "Lease Obtained", lbl_leaseObtained);
            lease_info("lz_ex.bat", "Lease Expires", lbl_leaseEnds);
                
            Cursor = Cursors.Default;
            checkIP(sender, e);
        }

        private void checkIP(object sender, EventArgs e)
        {
            if ((i < used_IP.Length) && (++count_ethernet < 4))
                btn_change_ethernet_Click(sender, e);
            else
                MessageBox.Show("No new IP found,please reset the router device");
        }
        private async void btn_change_wifi_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "change_IP";

            process.StartInfo = startInfo;
            process.Start();

            await Task.Delay(10000);
            lbl_wifi_IP.Text = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            lbl_old_IP.Text = lbl_newIP.Text;
            lbl_newIP.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            //reload lease info for the new IP
            lease_info("lz_ob.bat", "Lease Obtained", lbl_leaseObtained);
            lease_info("lz_ex.bat", "Lease Expires", lbl_leaseEnds);

            Cursor = Cursors.Default;
        }
       

        private void pB_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //----------------------function to get IP ,on passing "network type" as argument------------//
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();//check whether network is available....but this code is not used in the program
            string output = "Connection Error";
        
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                             output = ip.Address.ToString();
                    }
                }
            }
            return output;
        }
        
        public void lease_info(string filename,string searchStr,Label lbl)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;//necessary
            startInfo.FileName = filename;

            process.StartInfo = startInfo;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            string text = process.StandardOutput.ReadToEnd();
            int a = text.LastIndexOf(". . . . . . . . . . :");
            int b = text.IndexOf(":\\", text.IndexOf(":\\")+1);
            if(a>0)
            lbl.Text = searchStr+ text.Substring(a, b - a - 1);
        }









        //-----------------------to enable drag drop of the borderless form-----------------//
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void startDrag(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        
    }
}
