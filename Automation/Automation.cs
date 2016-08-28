using MinimalisticTelnet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;

namespace Automation
{
    public partial class Automation : Form
    {
        //############################
        #region initialization
        public Automation()
        {
            InitializeComponent();
        }
        #endregion
        //############################

        //############################
        #region Project Static Integers
        //############################### //Message Delivery Delegate
        private delegate void Delegete();
        //###############################

        //############################### // TelNet and ADV Connections
        TelnetConnection Telnet1;
        TelnetConnection Telnet2;
        TelnetConnection Telnet3;
        TelnetConnection Telnet4;
        TelnetConnection Telnet5;
        TelnetConnection Telnet6;
        TelnetConnection Telnet7;
        TelnetConnection ADV1;
        TelnetConnection ADV2;
        TelnetConnection ADV3;
        TelnetConnection ADV4;
        TelnetConnection ADV5;
        TelnetConnection ADV6;
        TelnetConnection ADV7;
        //###############################

        //############################### // Request Stop operation
        bool StopOperation1 = false;
        bool StopOperation2 = false;
        bool StopOperation3 = false;
        bool StopOperation4 = false;
        bool StopOperation5 = false;
        bool StopOperation6 = false;
        bool StopOperation7 = false;
        //###############################
        string[,] Connections = new string[16, 6];
        #endregion
        //############################

        //############################
        #region  Try Establish Connection to Devices  
        public void Check_Online_Offline_State()
        {
            //############################ // Function integers
            bool Connected1 = false;
            bool Connected2 = false;
            bool Connected3 = false;
            bool Connected4 = false;
            bool Connected5 = false;
            bool Connected6 = false;
            bool Connected7 = false;
            //############################

            //################################ -=Check Connection with ADV Server=-
            try
            {
                Telnet1.Connect(1);
                ADV1.Connect(1);
                if (Telnet1.IsConnected == true)
                {
                    Connected1 = true;
                    Start1_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected1 = false;
                }
                if (ADV1.IsConnected == true)
                {
                    Connected1 = true;
                    Start1_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected1 = false;
                }
            }
            catch (Exception Ex)
            {
                ReportError(1, "EstablishConnection", Ex.ToString() + "The Error Could have happened because the Device is unpluged or the IP and Port provided are invalid");
                Start1_btn.BackColor = Color.Red;
                Start1_btn.Enabled = false;
            }
            //================================
            try
            {
                Telnet2.Connect(2);
                ADV2.Connect(2);
                if (Telnet2.IsConnected == true)
                {
                    Connected2 = true;
                    Start2_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected2 = false;
                }
                if (ADV2.IsConnected == true)
                {
                    Connected2 = true;
                    Start2_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected2 = false;
                }
            }
            catch (Exception Ex)
            {
                ReportError(2, "EstablishConnection", Ex.ToString() + "The Error Could have happened because the Device is unpluged or the IP and Port provided are invalid");
                Start2_btn.BackColor = Color.Red;
                Start2_btn.Enabled = false;
            }
            //================================
            try
            {
                Telnet3.Connect(3);
                ADV3.Connect(3);
                if (Telnet3.IsConnected == true)
                {
                    Connected3 = true;
                    Start3_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected3 = false;
                }
                if (ADV3.IsConnected == true)
                {
                    Connected3 = true;
                    Start3_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected3 = false;
                }
            }
            catch (Exception Ex)
            {
                ReportError(3, "EstablishConnection", Ex.ToString() + "The Error Could have happened because the Device is unpluged or the IP and Port provided are invalid");
                Start3_btn.BackColor = Color.Red;
                Start3_btn.Enabled = false;
            }
            //================================
            try
            {
                Telnet4.Connect(4);
                ADV4.Connect(4);
                if (Telnet4.IsConnected == true)
                {
                    Connected4 = true;
                    Start4_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected4 = false;
                }
                if (ADV4.IsConnected == true)
                {
                    Connected4 = true;
                    Start4_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected4 = false;
                }
            }
            catch (Exception Ex)
            {
                ReportError(4, "EstablishConnection", Ex.ToString() + "The Error Could have happened because the Device is unpluged or the IP and Port provided are invalid");
                Start4_btn.BackColor = Color.Red;
                Start4_btn.Enabled = false;
            }
            //================================
            try
            {
                Telnet5.Connect(5);
                ADV5.Connect(5);
                if (Telnet5.IsConnected == true)
                {
                    Connected5 = true;
                    Start5_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected5 = false;
                }
                if (ADV5.IsConnected == true)
                {
                    Connected5 = true;
                    Start5_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected5 = false;
                }
            }
            catch (Exception Ex)
            {
                ReportError(5, "EstablishConnection", Ex.ToString() + "The Error Could have happened because the Device is unpluged or the IP and Port provided are invalid");
                Start5_btn.BackColor = Color.Red;
                Start5_btn.Enabled = false;
            }
            //================================
            try
            {
                Telnet6.Connect(6);
                ADV6.Connect(6);
                if (Telnet6.IsConnected == true)
                {
                    Connected6 = true;
                    Start6_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected6 = false;
                }
                if (ADV6.IsConnected == true)
                {
                    Connected6 = true;
                    Start6_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected6 = false;
                }
            }
            catch (Exception Ex)
            {
                ReportError(6, "EstablishConnection", Ex.ToString() + "The Error Could have happened because the Device is unpluged or the IP and Port provided are invalid");
                Start6_btn.BackColor = Color.Red;
                Start6_btn.Enabled = false;
            }
            //================================
            try
            {
                Telnet7.Connect(7);
                ADV7.Connect(7);
                if (Telnet7.IsConnected == true)
                {
                    Connected7 = true;
                    Start7_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected7 = false;
                }
                if (ADV7.IsConnected == true)
                {
                    Connected7 = true;
                    Start7_btn.BackColor = Color.Lime;
                }
                else
                {
                    Connected7 = false;
                }
            }
            catch (Exception Ex)
            {
                ReportError(7, "EstablishConnection", Ex.ToString() + "The Error Could have happened because the Device is unpluged or the IP and Port provided are invalid");
                Start7_btn.BackColor = Color.Red;
                Start7_btn.Enabled = false;
            }
            //################################ 

            ///################################ // Display Status [Online/Offline]
            if (Connected1 == false)
            {
                Status1.Text = "Offline";
                Status1.ForeColor = Color.Red;
            }
            else
            {
                Status1.Text = "Online";
                Status1.ForeColor = Color.Green;
                Telnet1.Disconnect();
                ADV1.Disconnect();
            }
            //===================================
            if (Connected2 == false)
            {
                Status2.Text = "Offline";
                Status2.ForeColor = Color.Red;
            }
            else
            {
                Status2.Text = "Online";
                Status2.ForeColor = Color.Green;
                Telnet2.Disconnect();
                ADV2.Disconnect();
            }
            //===================================
            if (Connected3 == false)
            {
                Status3.Text = "Offline";
                Status3.ForeColor = Color.Red;
            }
            else
            {
                Status3.Text = "Online";
                Status3.ForeColor = Color.Green;
                Telnet3.Disconnect();
                ADV3.Disconnect();
            }
            //===================================
            if (Connected4 == false)
            {
                Status4.Text = "Offline";
                Status4.ForeColor = Color.Red;
            }
            else
            {
                Status4.Text = "Online";
                Status4.ForeColor = Color.Green;
                Telnet4.Disconnect();
                ADV4.Disconnect();
            }
            //===================================
            if (Connected5 == false)
            {
                Status5.Text = "Offline";
                Status5.ForeColor = Color.Red;
            }
            else
            {
                Status5.Text = "Online";
                Status5.ForeColor = Color.Green;
                Telnet5.Disconnect();
                ADV5.Disconnect();
            }
            //===================================
            if (Connected6 == false)
            {
                Status6.Text = "Offline";
                Status6.ForeColor = Color.Red;
            }
            else
            {
                Status6.Text = "Online";
                Status6.ForeColor = Color.Green;
                Telnet6.Disconnect();
                ADV6.Disconnect();
            }
            //===================================
            if (Connected7 == false)
            {
                Status7.Text = "Offline";
                Status7.ForeColor = Color.Red;
            }
            else
            {
                Status7.Text = "Online";
                Status7.ForeColor = Color.Green;
                Telnet7.Disconnect();
                ADV7.Disconnect();
            }
            //################################

        }
        #endregion
        //############################

        //#################################
        #region Load from XML Devices IP and Ports
        public void ConnectToDevices()
        {
            int SavingDataColum = 1;
            //######################################################################### // Read From Connections XML
            try
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                path += "\\Connections.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);


                foreach (XmlNode Element in xmlDoc.GetElementsByTagName("CinemaTheaters"))
                {
                    foreach (XmlNode Theaters in Element.ChildNodes)
                    {
                        foreach (XmlNode node in Theaters.ChildNodes)
                        {
                            if (node.Name == "CinemaNumber")
                            {
                                Connections[SavingDataColum, 1] = node.InnerText;
                            }
                            else if (node.Name == "TelNetIP")
                            {
                                Connections[SavingDataColum, 2] = node.InnerText;
                            }
                            else if (node.Name == "TelNetPort")
                            {
                                Connections[SavingDataColum, 3] = node.InnerText;
                            }
                            else if (node.Name == "AdvIP")
                            {
                                Connections[SavingDataColum, 4] = node.InnerText;
                            }
                            else if (node.Name == "AdvPort")
                            {
                                Connections[SavingDataColum, 5] = node.InnerText;
                            }

                        }
                        SavingDataColum++;
                    }
                }
                for (int i = 1; i < 8; i++)
                {
                    for (int Device = 1; Device < 3; Device++)
                    {
                        ConnectToDevices(i, Device);
                    }

                }
                Check_Online_Offline_State();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //#########################################################################

        //###################################################### // Set IP and Port Connection To devices
        public void ConnectToDevices(int CinemaNumber, int Device)
        {

            if (CinemaNumber == 1)
            {
                //====================================================================================================================================== 
                if (Device == 1)
                {
                    try
                    {
                        Telnet1 = new TelnetConnection(Connections[1, 2], Convert.ToInt32(Connections[1, 3])); // Set IP and port for Telnet device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
                if (Device == 2)
                {
                    try
                    {
                        ADV1 = new TelnetConnection(Connections[1, 4], Convert.ToInt32(Connections[1, 5]));    // Set IP and port for ADV device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
            }

            if (CinemaNumber == 2)
            {

                //===================================================================================== ================================================= 
                if (Device == 1)
                {
                    try
                    {
                        Telnet2 = new TelnetConnection(Connections[2, 2], Convert.ToInt32(Connections[2, 3])); // Set IP and port for Telnet device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
                if (Device == 2)
                {
                    try
                    {
                        ADV2 = new TelnetConnection(Connections[2, 4], Convert.ToInt32(Connections[2, 5]));    // Set IP and port for ADV device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 

            }
            if (CinemaNumber == 3)
            {

                //====================================================================================================================================== 
                if (Device == 1)
                {
                    try
                    {
                        Telnet3 = new TelnetConnection(Connections[3, 2], Convert.ToInt32(Connections[3, 3])); // Set IP and port for Telnet device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
                if (Device == 2)
                {
                    try
                    {
                        ADV3 = new TelnetConnection(Connections[3, 4], Convert.ToInt32(Connections[3, 5]));    // Set IP and port for ADV device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 

            }
            if (CinemaNumber == 4)
            {

                //===================================================================================== ================================================= 
                if (Device == 1)
                {
                    try
                    {
                        Telnet4 = new TelnetConnection(Connections[4, 2], Convert.ToInt32(Connections[4, 3])); // Set IP and port for Telnet device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
                if (Device == 2)
                {
                    try
                    {
                        ADV4 = new TelnetConnection(Connections[4, 4], Convert.ToInt32(Connections[4, 5]));    // Set IP and port for ADV device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 

            }
            if (CinemaNumber == 5)
            {

                //====================================================================================================================================== 
                if (Device == 1)
                {
                    try
                    {
                        Telnet5 = new TelnetConnection(Connections[5, 2], Convert.ToInt32(Connections[5, 3])); // Set IP and port for Telnet device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
                if (Device == 2)
                {
                    try
                    {
                        ADV5 = new TelnetConnection(Connections[5, 4], Convert.ToInt32(Connections[5, 5]));    // Set IP and port for ADV device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 

            }
            if (CinemaNumber == 6)
            {

                //====================================================================================================================================== 
                if (Device == 1)
                {
                    try
                    {
                        Telnet6 = new TelnetConnection(Connections[6, 2], Convert.ToInt32(Connections[6, 3])); // Set IP and port for Telnet device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
                if (Device == 2)
                {
                    try
                    {
                        ADV6 = new TelnetConnection(Connections[6, 4], Convert.ToInt32(Connections[6, 5]));    // Set IP and port for ADV device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 

            }
            if (CinemaNumber == 7)
            {

                //======================================================================================================================================  
                if (Device == 1)
                {
                    try
                    {
                        Telnet7 = new TelnetConnection(Connections[7, 2], Convert.ToInt32(Connections[7, 3])); // Set IP and port for Telnet device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 
                if (Device == 2)
                {
                    try
                    {
                        ADV7 = new TelnetConnection(Connections[7, 4], Convert.ToInt32(Connections[7, 5]));    // Set IP and port for ADV device from XML
                    }
                    catch { }
                }
                //====================================================================================================================================== 

            }
            //######################################################
        }

        #endregion
        //#################################

        //######################
        #region Project Load Fuctions *forumLoad*
        private void Automation_Load(object sender, EventArgs e)
        {
            //################### // Establish Connection to Devices
            ConnectToDevices();
            //###################


            //####################################################### // Create Workers(Threads) Operators
            BackgroundWorker CinemaWorker1 = new BackgroundWorker();
            BackgroundWorker CinemaWorker2 = new BackgroundWorker();
            BackgroundWorker CinemaWorker3 = new BackgroundWorker();
            BackgroundWorker CinemaWorker4 = new BackgroundWorker();
            BackgroundWorker CinemaWorker5 = new BackgroundWorker();
            BackgroundWorker CinemaWorker6 = new BackgroundWorker();
            BackgroundWorker CinemaWorker7 = new BackgroundWorker();
            //#######################################################

            //################################################################################ //Create Error Storage Folders
            string AppLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FolderPath = AppLocation + "\\ErrorLogs";
            string CinemaErrorFolder = "";

            if (!File.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            for (int i = 1; i <= 7; i++)
            {
                CinemaErrorFolder = FolderPath + "\\" + i;
                if (!File.Exists(CinemaErrorFolder))
                {
                    Directory.CreateDirectory(CinemaErrorFolder);
                }
            }
            //################################################################################
        }
        #endregion
        //######################

        //#########################
        #region Buttons Click Activators
        //=========================================================================>1
        private void Start1_btn_Click(object sender, EventArgs e)
        {
            StopOperation1 = false;
            RegisterEventsCinema1();
            CinemaWorker1.RunWorkerAsync();
            Start1_btn.Enabled = false;
            Start1_btn.BackColor = Color.Orange;
            Start1_btn.Text = "Running";
        }
        //=========================================================================>2
        private void Start2_btn_Click(object sender, EventArgs e)
        {
            StopOperation2 = false;
            RegisterEventsCinema2();
            CinemaWorker2.RunWorkerAsync();
            Start2_btn.Enabled = false;
            Start2_btn.BackColor = Color.Orange;
            Start2_btn.Text = "Running";
        }
        //=========================================================================>3
        private void Start3_btn_Click(object sender, EventArgs e)
        {
            StopOperation3 = false;
            RegisterEventsCinema3();
            CinemaWorker3.RunWorkerAsync();
            Start3_btn.Enabled = false;
            Start3_btn.BackColor = Color.Orange;
            Start3_btn.Text = "Running";
        }
        //=========================================================================>4
        private void Start4_btn_Click(object sender, EventArgs e)
        {
            StopOperation4 = false;
            RegisterEventsCinema4();
            CinemaWorker4.RunWorkerAsync();
            Start4_btn.Enabled = false;
            Start4_btn.BackColor = Color.Orange;
            Start4_btn.Text = "Running";
        }
        //=========================================================================>5
        private void Start5_btn_Click(object sender, EventArgs e)
        {
            StopOperation5 = false;
            RegisterEventsCinema5();
            CinemaWorker5.RunWorkerAsync();
            Start5_btn.Enabled = false;
            Start5_btn.BackColor = Color.Orange;
            Start5_btn.Text = "Running";
        }
        //=========================================================================>6
        private void Start6_btn_Click(object sender, EventArgs e)
        {
            StopOperation6 = false;
            RegisterEventsCinema6();
            CinemaWorker6.RunWorkerAsync();
            Start6_btn.Enabled = false;
            Start6_btn.BackColor = Color.Orange;
            Start6_btn.Text = "Running";
        }
        //=========================================================================>7
        private void Start7_btn_Click(object sender, EventArgs e)
        {
            StopOperation7 = false;
            RegisterEventsCinema7();
            CinemaWorker7.RunWorkerAsync();
            Start7_btn.Enabled = false;
            Start7_btn.BackColor = Color.Orange;
            Start7_btn.Text = "Running";
        }
        //=========================================================================
        private void Stop1_btn_Click(object sender, EventArgs e)
        {
            StopOperation1 = true;
            Telnet1.Disconnect();
            ADV1.Disconnect();
            CinemaWorker1.Dispose();
        }
        //=========================================================================
        private void Stop2_btn_Click(object sender, EventArgs e)
        {
            StopOperation2 = true;
            Telnet2.Disconnect();
            ADV2.Disconnect();
            CinemaWorker2.Dispose();

        }
        //=========================================================================
        private void Stop3_btn_Click(object sender, EventArgs e)
        {
            StopOperation3 = true;
            Telnet3.Disconnect();
            ADV3.Disconnect();
            CinemaWorker3.Dispose();
        }
        //=========================================================================
        private void Stop4_btn_Click(object sender, EventArgs e)
        {
            StopOperation4 = true;
            Telnet4.Disconnect();
            ADV4.Disconnect();
            CinemaWorker4.Dispose();
        }
        //=========================================================================
        private void Stop5_btn_Click(object sender, EventArgs e)
        {
            StopOperation5 = true;
            Telnet5.Disconnect();
            ADV5.Disconnect();
            CinemaWorker5.Dispose();
        }
        //=========================================================================
        private void Stop6_btn_Click(object sender, EventArgs e)
        {
            StopOperation6 = true;
            Telnet6.Disconnect();
            ADV6.Disconnect();
            CinemaWorker6.Dispose();
        }
        //=========================================================================
        private void Stop7_btn_Click(object sender, EventArgs e)
        {
            StopOperation7 = true;
            Telnet7.Disconnect();
            ADV7.Disconnect();
            CinemaWorker7.Dispose();
        }
        //=========================================================================
        private void StartAll_btn_Click(object sender, EventArgs e)
        {
            //-=Allow Operations =-
            StopOperation1 = false;
            StopOperation2 = false;
            StopOperation3 = false;
            StopOperation4 = false;
            StopOperation5 = false;
            StopOperation6 = false;
            StopOperation7 = false;
            //============================
            //-=Register all events =-
            RegisterEventsCinema1();
            RegisterEventsCinema2();
            RegisterEventsCinema3();
            RegisterEventsCinema4();
            RegisterEventsCinema5();
            RegisterEventsCinema6();
            RegisterEventsCinema7();
            //============================
            //-=Activate all events =-
            CinemaWorker1.RunWorkerAsync();
            CinemaWorker2.RunWorkerAsync();
            CinemaWorker3.RunWorkerAsync();
            CinemaWorker4.RunWorkerAsync();
            CinemaWorker5.RunWorkerAsync();
            CinemaWorker6.RunWorkerAsync();
            CinemaWorker7.RunWorkerAsync();
            //============================
            //-=Disable All Buttons=-
            Start1_btn.Enabled = false;
            Start2_btn.Enabled = false;
            Start3_btn.Enabled = false;
            Start4_btn.Enabled = false;
            Start5_btn.Enabled = false;
            Start6_btn.Enabled = false;
            Start7_btn.Enabled = false;
            //============================
            Start1_btn.BackColor = Color.Orange;
            Start2_btn.BackColor = Color.Orange;
            Start3_btn.BackColor = Color.Orange;
            Start4_btn.BackColor = Color.Orange;
            Start5_btn.BackColor = Color.Orange;
            Start6_btn.BackColor = Color.Orange;
            Start7_btn.BackColor = Color.Orange;
            ProtectionPanel8.Visible = true;
        }
        private void StopAll_btn_Click(object sender, EventArgs e)
        {
            //-=Allow Operations =-
            StopOperation1 = true;
            StopOperation2 = true;
            StopOperation3 = true;
            StopOperation4 = true;
            StopOperation5 = true;
            StopOperation6 = true;
            StopOperation7 = true;
            //============================
            //-=Disconnect all Telnet =-
            Telnet1.Disconnect();
            Telnet2.Disconnect();
            Telnet3.Disconnect();
            Telnet4.Disconnect();
            Telnet5.Disconnect();
            Telnet6.Disconnect();
            Telnet7.Disconnect();
            //============================
            //-=Disconnect all Ads =-
            ADV1.Disconnect();
            ADV2.Disconnect();
            ADV3.Disconnect();
            ADV4.Disconnect();
            ADV5.Disconnect();
            ADV6.Disconnect();
            ADV7.Disconnect();
            //============================
            //-=Disable All Buttons=-
            CinemaWorker1.Dispose();
            CinemaWorker2.Dispose();
            CinemaWorker3.Dispose();
            CinemaWorker4.Dispose();
            CinemaWorker5.Dispose();
            CinemaWorker6.Dispose();
            CinemaWorker7.Dispose();
            //============================

        }
        #endregion Buttons 
        //#########################

        //#########################
        #region Register Worker Events
        public void RegisterEventsCinema1()
        {
            CinemaWorker1.DoWork += new DoWorkEventHandler(ActivatedCinema1);
            CinemaWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ActivationComplete1);
        }
        public void RegisterEventsCinema2()
        {
            CinemaWorker2.DoWork += new DoWorkEventHandler(ActivatedCinema2);
            CinemaWorker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ActivationComplete2);
        }
        public void RegisterEventsCinema3()
        {
            CinemaWorker3.DoWork += new DoWorkEventHandler(ActivatedCinema3);
            CinemaWorker3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ActivationComplete3);
        }
        public void RegisterEventsCinema4()
        {
            CinemaWorker4.DoWork += new DoWorkEventHandler(ActivatedCinema4);
            CinemaWorker4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ActivationComplete4);
        }
        public void RegisterEventsCinema5()
        {
            CinemaWorker5.DoWork += new DoWorkEventHandler(ActivatedCinema5);
            CinemaWorker5.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ActivationComplete5);
        }
        public void RegisterEventsCinema6()
        {
            CinemaWorker6.DoWork += new DoWorkEventHandler(ActivatedCinema6);
            CinemaWorker6.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ActivationComplete6);
        }
        public void RegisterEventsCinema7()
        {
            CinemaWorker7.DoWork += new DoWorkEventHandler(ActivatedCinema7);
            CinemaWorker7.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ActivationComplete7);
        }
        #endregion
        //#########################

        //#########################
        #region Worker DoWork Event
        //private void ActivatedCinema999(object sender, EventArgs e)   //<<< Test
        //{
        //    Delegete Load999 = new Delegete(LoadText999);
        //    Delegete Pause999 = new Delegete(PauseText999);
        //    Delegete Playing999 = new Delegete(PlayText999);
        //    Delegete Stop999 = new Delegete(StopText999);
        //    Delegete Clear999 = new Delegete(ClearText999);
        //    //=============== DELEGATES =========\\
        //    bool ADVPlay = true;
        //    string Replay = "";
        //    int HowManyFalseParameters = 0;
        //    //====================================\\
        //    //###################################################### //Send Commands To Tibbo
        //    try
        //    {
        //        Telnet999.WriteLine("");
        //        Telnet999.Sleep(2);//2
        //        Telnet999.WriteLine("START");//START
        //        this.Invoke(Load999);
        //        Telnet999.Sleep(16);//16
        //        Telnet999.WriteLine("PAUSE");//PAUSE
        //        this.Invoke(Pause999);
        //        Telnet999.Sleep(2);//2
        //    }
        //    catch (Exception Ex)
        //    {
        //        ReportError(999, "TibboCommandInput", Ex.ToString());
        //        Start999_btn.Enabled = false;
        //        Start999_btn.BackColor = Color.Red;
        //    }
        //    //###################################################### 

        //    //###################################################### //Send Commands To ADV
        //    try
        //    {
        //        ADV999.WriteLine("");//===>Activate Console response
        //        ADV999.WriteLine("PLAY");//PLAY
        //        this.Invoke(Playing999);
        //        ADV999.Sleep(120);//120
        //        while (ADVPlay == true)
        //        {
        //            ADV999.WriteLine("p?");
        //            Replay = ADV999.Read();
        //            HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
        //            if (HowManyFalseParameters >= 2)
        //            {
        //                ADVPlay = false;
        //            }
        //            ADV999.Sleep(4);//4
        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //        ReportError(999, "ADVCommandInput", Ex.ToString());
        //        Start999_btn.Enabled = false;
        //        Start999_btn.BackColor = Color.Red;
        //    }
        //    //###################################################### 

        //    //###################################################### //Send Commands To Tibbo
        //    try
        //    {
        //        if (ADVPlay == false && HowManyFalseParameters >= 2)
        //        {

        //            this.Invoke(Stop999);
        //            Telnet999.WriteLine("");
        //            Telnet999.Sleep(2);//2
        //            Telnet999.WriteLine("START");//Start
        //            this.Invoke(Load999);
        //            Telnet999.Sleep(2);//2
        //            this.Invoke(Clear999);

        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //        ReportError(999, "TibboCommandInput", Ex.ToString());
        //        Start999_btn.Enabled = false;
        //        Start999_btn.BackColor = Color.Red;
        //    }
        //    //###################################################### 

        //}
        ////#######################################################################   // EXAMPLE SAMPLE
        private void ActivatedCinema1(object sender, EventArgs e)
        {
            Delegete Load1 = new Delegete(LoadText1);
            Delegete Pause1 = new Delegete(PauseText1);
            Delegete Playing1 = new Delegete(PlayText1);
            Delegete Stop1 = new Delegete(StopText1);
            Delegete Clear1 = new Delegete(ClearText1);
            //=============== DELEGATES =========\\
            bool ADVPlay = true;
            string Replay = "";
            int HowManyFalseParameters = 0;
            //====================================\\
            //###################################################### //Send Commands To Tibbo
            if (StopOperation1 == false)
            {
                try
                {
                    Telnet1.Connect(1);
                    Telnet1.WriteLine("");
                    Telnet1.Sleep(2);//2
                    Telnet1.WriteLine("START");//START
                    this.Invoke(Load1);
                    Telnet1.Sleep(16);//16
                    if (StopOperation1 == false)
                    {
                        Telnet1.WriteLine("PAUSE");//PAUSE
                        Telnet1.Sleep(2);//2
                        Telnet1.WriteLine("PAUSE");//PAUSE
                    }
                    this.Invoke(Pause1);
                    Telnet1.Sleep(2);//2
                    Telnet1.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(1, "TibboCommandInput", Ex.ToString());
                    Start1_btn.Enabled = false;
                    Start1_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To ADV
            if (StopOperation1 == false)
            {
                try
                {
                    ADV1.Connect(1);
                    ADV1.WriteLine("");//===>Activate Console response
                    ADV1.WriteLine("PLAY");//PLAY
                    this.Invoke(Playing1);
                    ADV1.Sleep(120);//120
                    while (ADVPlay == true)
                    {
                        ADV1.WriteLine("p?");
                        Replay = ADV1.Read();
                        HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
                        if (HowManyFalseParameters >= 2)
                        {
                            ADVPlay = false;
                        }
                        ADV1.Sleep(4);//4
                    }
                    ADV1.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(1, "ADVCommandInput", Ex.ToString());
                    Start1_btn.Enabled = false;
                    Start1_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To Tibbo
            if (StopOperation1 == false)
            {
                try
                {
                    if (ADVPlay == false && HowManyFalseParameters >= 2)
                    {
                        Telnet1.Connect(1);
                        this.Invoke(Stop1);
                        Telnet1.WriteLine("");
                        Telnet1.Sleep(2);//2
                        Telnet1.WriteLine("START");//Start
                        this.Invoke(Load1);
                        Telnet1.Sleep(2);//2
                        Telnet1.Disconnect();
                    }
                }
                catch (Exception Ex)
                {
                    ReportError(1, "TibboCommandInput", Ex.ToString());
                    Start1_btn.Enabled = false;
                    Start1_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 
            this.Invoke(Clear1);
        }
        //#######################################################################
        private void ActivatedCinema2(object sender, EventArgs e)
        {
            Delegete Load2 = new Delegete(LoadText2);
            Delegete Pause2 = new Delegete(PauseText2);
            Delegete Playing2 = new Delegete(PlayText2);
            Delegete Stop2 = new Delegete(StopText2);
            Delegete Clear2 = new Delegete(ClearText2);
            //=============== DELEGATES =========\\
            bool ADVPlay = true;
            string Replay = "";
            int HowManyFalseParameters = 0;
            //====================================\\
            //###################################################### //Send Commands To Tibbo
            if (StopOperation2 == false)
            {
                try
                {
                    Telnet2.Connect(2);
                    Telnet2.WriteLine("");
                    Telnet2.Sleep(2);//2
                    Telnet2.WriteLine("START");//START
                    this.Invoke(Load2);
                    Telnet2.Sleep(16);//16
                    if (StopOperation1 == false)
                    {
                        Telnet2.WriteLine("PAUSE");//PAUSE
                        Telnet2.Sleep(2);//2
                        Telnet2.WriteLine("PAUSE");//PAUSE
                    }
                    this.Invoke(Pause2);
                    Telnet2.Sleep(2);//2
                    Telnet2.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(2, "TibboCommandInput", Ex.ToString());
                    Start2_btn.Enabled = false;
                    Start2_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To ADV
            if (StopOperation2 == false)
            {
                try
                {
                    ADV2.Connect(2);
                    ADV2.WriteLine("");//===>Activate Console response
                    ADV2.WriteLine("PLAY");//PLAY
                    this.Invoke(Playing2);
                    ADV2.Sleep(120);//120
                    while (ADVPlay == true)
                    {
                        ADV2.WriteLine("p?");
                        Replay = ADV2.Read();
                        HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
                        if (HowManyFalseParameters >= 2)
                        {
                            ADVPlay = false;
                        }
                        ADV2.Sleep(4);//4
                    }
                    ADV2.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(2, "ADVCommandInput", Ex.ToString());
                    Start2_btn.Enabled = false;
                    Start2_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To Tibbo
            if (StopOperation2 == false)
            {
                try
                {
                    if (ADVPlay == false && HowManyFalseParameters >= 2)
                    {
                        Telnet2.Connect(2);
                        this.Invoke(Stop2);
                        Telnet2.WriteLine("");
                        Telnet2.Sleep(2);//2
                        Telnet2.WriteLine("START");//Start
                        this.Invoke(Load2);
                        Telnet2.Sleep(2);//2
                        Telnet2.Disconnect();
                    }
                }
                catch (Exception Ex)
                {
                    ReportError(2, "TibboCommandInput", Ex.ToString());
                    Start2_btn.Enabled = false;
                    Start2_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 
            this.Invoke(Clear2);
        }
        //#######################################################################
        private void ActivatedCinema3(object sender, EventArgs e)
        {
            Delegete Load3 = new Delegete(LoadText3);
            Delegete Pause3 = new Delegete(PauseText3);
            Delegete Playing3 = new Delegete(PlayText3);
            Delegete Stop3 = new Delegete(StopText3);
            Delegete Clear3 = new Delegete(ClearText3);
            //=============== DELEGATES =========\\
            bool ADVPlay = true;
            string Replay = "";
            int HowManyFalseParameters = 0;
            //====================================\\
            //###################################################### //Send Commands To Tibbo
            if (StopOperation3 == false)
            {
                try
                {
                    Telnet3.Connect(3);
                    Telnet3.WriteLine("");
                    Telnet3.Sleep(2);//2
                    Telnet3.WriteLine("START");//START
                    this.Invoke(Load3);
                    Telnet3.Sleep(16);//16
                    if (StopOperation1 == false)
                    {
                        Telnet3.WriteLine("PAUSE");//PAUSE
                        Telnet3.Sleep(2);//2
                        Telnet3.WriteLine("PAUSE");//PAUSE
                    }
                    this.Invoke(Pause3);
                    Telnet3.Sleep(2);//2
                    Telnet3.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(3, "TibboCommandInput", Ex.ToString());
                    Start3_btn.Enabled = false;
                    Start3_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To ADV
            if (StopOperation3 == false)
            {
                try
                {
                    ADV3.Connect(3);
                    ADV3.WriteLine("");//===>Activate Console response
                    ADV3.WriteLine("PLAY");//PLAY
                    this.Invoke(Playing3);
                    ADV3.Sleep(120);//120
                    while (ADVPlay == true)
                    {
                        ADV3.WriteLine("p?");
                        Replay = ADV3.Read();
                        HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
                        if (HowManyFalseParameters >= 2)
                        {
                            ADVPlay = false;
                        }
                        ADV3.Sleep(4);//4
                    }
                    ADV3.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(3, "ADVCommandInput", Ex.ToString());
                    Start3_btn.Enabled = false;
                    Start3_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To Tibbo
            if (StopOperation3 == false)
            {
                try
                {
                    if (ADVPlay == false && HowManyFalseParameters >= 2)
                    {
                        Telnet3.Connect(3);
                        this.Invoke(Stop3);
                        Telnet3.WriteLine("");
                        Telnet3.Sleep(2);//2
                        Telnet3.WriteLine("START");//Start
                        this.Invoke(Load3);
                        Telnet3.Sleep(2);//2

                        Telnet3.Disconnect();
                    }
                }
                catch (Exception Ex)
                {
                    ReportError(3, "TibboCommandInput", Ex.ToString());
                    Start3_btn.Enabled = false;
                    Start3_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 
            this.Invoke(Clear3);
        }

        //#######################################################################
        private void ActivatedCinema4(object sender, EventArgs e)
        {
            Delegete Load4 = new Delegete(LoadText4);
            Delegete Pause4 = new Delegete(PauseText4);
            Delegete Playing4 = new Delegete(PlayText4);
            Delegete Stop4 = new Delegete(StopText4);
            Delegete Clear4 = new Delegete(ClearText4);
            //=============== DELEGATES =========\\
            bool ADVPlay = true;
            string Replay = "";
            int HowManyFalseParameters = 0;
            //====================================\\
            //###################################################### //Send Commands To Tibbo
            if (StopOperation4 == false)
            {
                try
                {
                    Telnet4.Connect(4);
                    Telnet4.WriteLine("");
                    Telnet4.Sleep(2);//2
                    Telnet4.WriteLine("START");//START
                    this.Invoke(Load4);
                    Telnet4.Sleep(16);//16
                    if (StopOperation1 == false)
                    {
                        Telnet4.WriteLine("PAUSE");//PAUSE
                        Telnet4.Sleep(2);//2
                        Telnet4.WriteLine("PAUSE");//PAUSE
                    }
                    this.Invoke(Pause4);
                    Telnet4.Sleep(2);//2
                    Telnet4.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(4, "TibboCommandInput", Ex.ToString());
                    Start4_btn.Enabled = false;
                    Start4_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To ADV
            if (StopOperation4 == false)
            {
                try
                {
                    ADV4.Connect(4);
                    ADV4.WriteLine("");//===>Activate Console response
                    ADV4.WriteLine("PLAY");//PLAY
                    this.Invoke(Playing4);
                    ADV4.Sleep(120);//120
                    while (ADVPlay == true)
                    {
                        ADV4.WriteLine("p?");
                        Replay = ADV4.Read();
                        HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
                        if (HowManyFalseParameters >= 2)
                        {
                            ADVPlay = false;
                        }
                        ADV4.Sleep(4);//4
                    }
                    ADV4.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(4, "ADVCommandInput", Ex.ToString());
                    Start4_btn.Enabled = false;
                    Start4_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To Tibbo
            if (StopOperation4 == false)
            {
                try
                {
                    if (ADVPlay == false && HowManyFalseParameters >= 2)
                    {
                        Telnet4.Connect(4);
                        this.Invoke(Stop4);
                        Telnet4.WriteLine("");
                        Telnet4.Sleep(2);//2
                        Telnet4.WriteLine("START");//Start
                        this.Invoke(Load4);
                        Telnet4.Sleep(2);//2
                        Telnet4.Disconnect();
                    }
                }
                catch (Exception Ex)
                {
                    ReportError(4, "TibboCommandInput", Ex.ToString());
                    Start4_btn.Enabled = false;
                    Start4_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 
            this.Invoke(Clear4);
        }
        //#######################################################################
        private void ActivatedCinema5(object sender, EventArgs e)
        {
            Delegete Load5 = new Delegete(LoadText5);
            Delegete Pause5 = new Delegete(PauseText5);
            Delegete Playing5 = new Delegete(PlayText5);
            Delegete Stop5 = new Delegete(StopText5);
            Delegete Clear5 = new Delegete(ClearText5);
            //=============== DELEGATES =========\\
            bool ADVPlay = true;
            string Replay = "";
            int HowManyFalseParameters = 0;
            //====================================\\
            //###################################################### //Send Commands To Tibbo
            if (StopOperation5 == false)
            {
                try
                {
                    Telnet5.Connect(5);
                    Telnet5.WriteLine("");
                    Telnet5.Sleep(2);//2
                    Telnet5.WriteLine("START");//START
                    this.Invoke(Load5);
                    Telnet5.Sleep(16);//16
                    if (StopOperation1 == false)
                    {
                        Telnet5.WriteLine("PAUSE");//PAUSE
                        Telnet5.Sleep(2);//2
                        Telnet5.WriteLine("PAUSE");//PAUSE
                    }
                    this.Invoke(Pause5);
                    Telnet5.Sleep(2);//2
                    Telnet5.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(5, "TibboCommandInput", Ex.ToString());
                    Start5_btn.Enabled = false;
                    Start5_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To ADV
            if (StopOperation5 == false)
            {
                try
                {
                    ADV5.Connect(5);
                    ADV5.WriteLine("");//===>Activate Console response
                    ADV5.WriteLine("PLAY");//PLAY
                    this.Invoke(Playing5);
                    ADV5.Sleep(120);//120
                    while (ADVPlay == true)
                    {
                        ADV5.WriteLine("p?");
                        Replay = ADV5.Read();
                        HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
                        if (HowManyFalseParameters >= 2)
                        {
                            ADVPlay = false;
                        }
                        ADV5.Sleep(4);//4
                    }
                    ADV5.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(5, "ADVCommandInput", Ex.ToString());
                    Start5_btn.Enabled = false;
                    Start5_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To Tibbo
            if (StopOperation5 == false)
            {
                try
                {
                    if (ADVPlay == false && HowManyFalseParameters >= 2)
                    {
                        Telnet5.Connect(5);
                        this.Invoke(Stop5);
                        Telnet5.WriteLine("");
                        Telnet5.Sleep(2);//2
                        Telnet5.WriteLine("START");//Start
                        this.Invoke(Load5);
                        Telnet5.Sleep(2);//2
                        Telnet5.Disconnect();
                    }
                }
                catch (Exception Ex)
                {
                    ReportError(5, "TibboCommandInput", Ex.ToString());
                    Start5_btn.Enabled = false;
                    Start5_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 
            this.Invoke(Clear5);

        }
        //#######################################################################
        private void ActivatedCinema6(object sender, EventArgs e)
        {
            Delegete Load6 = new Delegete(LoadText6);
            Delegete Pause6 = new Delegete(PauseText6);
            Delegete Playing6 = new Delegete(PlayText6);
            Delegete Stop6 = new Delegete(StopText6);
            Delegete Clear6 = new Delegete(ClearText6);
            //=============== DELEGATES =========\\
            bool ADVPlay = true;
            string Replay = "";
            int HowManyFalseParameters = 0;
            //====================================\\
            //###################################################### //Send Commands To Tibbo
            if (StopOperation6 == false)
            {
                try
                {
                    Telnet6.Connect(6);
                    Telnet6.WriteLine("");
                    Telnet6.Sleep(2);//2
                    Telnet6.WriteLine("START");//START
                    this.Invoke(Load6);
                    Telnet6.Sleep(16);//16
                    if (StopOperation1 == false)
                    {
                        Telnet6.WriteLine("PAUSE");//PAUSE
                        Telnet6.Sleep(2);//2
                        Telnet6.WriteLine("PAUSE");//PAUSE
                    }
                    this.Invoke(Pause6);
                    Telnet6.Sleep(2);//2
                    Telnet6.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(6, "TibboCommandInput", Ex.ToString());
                    Start6_btn.Enabled = false;
                    Start6_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To ADV
            if (StopOperation6 == false)
            {
                try
                {
                    ADV6.Connect(6);
                    ADV6.WriteLine("");//===>Activate Console response
                    ADV6.WriteLine("PLAY");//PLAY
                    this.Invoke(Playing6);
                    ADV6.Sleep(120);//120
                    while (ADVPlay == true)
                    {
                        ADV6.WriteLine("p?");
                        Replay = ADV6.Read();
                        HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
                        if (HowManyFalseParameters >= 2)
                        {
                            ADVPlay = false;
                        }
                        ADV6.Sleep(4);//4
                    }
                    ADV6.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(6, "ADVCommandInput", Ex.ToString());
                    Start6_btn.Enabled = false;
                    Start6_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To Tibbo
            if (StopOperation6 == false)
            {
                try
                {
                    if (ADVPlay == false && HowManyFalseParameters >= 2)
                    {
                        Telnet6.Connect(6);
                        this.Invoke(Stop6);
                        Telnet6.WriteLine("");
                        Telnet6.Sleep(2);//2
                        Telnet6.WriteLine("START");//Start
                        this.Invoke(Load6);
                        Telnet6.Sleep(2);//2
                        Telnet6.Disconnect();
                    }
                }
                catch (Exception Ex)
                {
                    ReportError(6, "TibboCommandInput", Ex.ToString());
                    Start6_btn.Enabled = false;
                    Start6_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 
            this.Invoke(Clear6);
        }
        //#######################################################################
        private void ActivatedCinema7(object sender, EventArgs e)
        {
            Delegete Load7 = new Delegete(LoadText7);
            Delegete Pause7 = new Delegete(PauseText7);
            Delegete Playing7 = new Delegete(PlayText7);
            Delegete Stop7 = new Delegete(StopText7);
            Delegete Clear7 = new Delegete(ClearText7);
            //=============== DELEGATES =========\\
            bool ADVPlay = true;
            string Replay = "";
            int HowManyFalseParameters = 0;
            //====================================\\
            //###################################################### //Send Commands To Tibbo
            if (StopOperation7 == false)
            {
                try
                {
                    Telnet7.Connect(7);
                    Telnet7.WriteLine("");
                    Telnet7.Sleep(2);//2
                    Telnet7.WriteLine("START");//START
                    this.Invoke(Load7);
                    Telnet7.Sleep(16);//16
                    if (StopOperation1 == false)
                    {
                        Telnet7.WriteLine("PAUSE");//PAUSE
                        Telnet7.Sleep(2);//2
                        Telnet7.WriteLine("PAUSE");//PAUSE
                    }
                    this.Invoke(Pause7);
                    Telnet7.Sleep(2);//2
                    Telnet7.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(7, "TibboCommandInput", Ex.ToString());
                    Start7_btn.Enabled = false;
                    Start7_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To ADV
            if (StopOperation7 == false)
            {
                try
                {
                    ADV7.Connect(7);
                    ADV7.WriteLine("");//===>Activate Console response
                    ADV7.WriteLine("PLAY");//PLAY
                    this.Invoke(Playing7);
                    ADV7.Sleep(120);//120
                    while (ADVPlay == true)
                    {
                        ADV7.WriteLine("p?");
                        Replay = ADV7.Read();
                        HowManyFalseParameters = Regex.Matches(Replay, "false").Count;
                        if (HowManyFalseParameters >= 2)
                        {
                            ADVPlay = false;
                        }
                        ADV7.Sleep(4);//4
                    }
                    ADV7.Disconnect();
                }
                catch (Exception Ex)
                {
                    ReportError(7, "ADVCommandInput", Ex.ToString());
                    Start7_btn.Enabled = false;
                    Start7_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 

            //###################################################### //Send Commands To Tibbo
            if (StopOperation7 == false)
            {
                try
                {
                    if (ADVPlay == false && HowManyFalseParameters >= 2)
                    {
                        Telnet7.Connect(7);
                        this.Invoke(Stop7);
                        Telnet7.WriteLine("");
                        Telnet7.Sleep(2);//2
                        Telnet7.WriteLine("START");//Start
                        this.Invoke(Load7);
                        Telnet7.Sleep(2);//2
                        Telnet7.Disconnect();
                    }
                }
                catch (Exception Ex)
                {
                    ReportError(7, "TibboCommandInput", Ex.ToString());
                    Start7_btn.Enabled = false;
                    Start7_btn.BackColor = Color.Red;
                }
            }
            //###################################################### 
            this.Invoke(Clear7);

        }
        //#######################################################################
        #endregion
        //#########################

        //#########################
        #region Worker Work Complete
        private void ActivationComplete1(object sender, EventArgs e)
        {
            CinemaWorker1.DoWork -= new DoWorkEventHandler(ActivatedCinema1);
            CinemaWorker1.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(ActivationComplete1);
            Start1_btn.Enabled = true;
            Start1_btn.BackColor = Color.Lime;
            Start1_btn.Text = "Start";
        }
        private void ActivationComplete2(object sender, EventArgs e)
        {
            CinemaWorker2.DoWork -= new DoWorkEventHandler(ActivatedCinema2);
            CinemaWorker2.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(ActivationComplete2);
            Start2_btn.Enabled = true;
            Start2_btn.BackColor = Color.Lime;
            Start2_btn.Text = "Start";

        }
        private void ActivationComplete3(object sender, EventArgs e)
        {
            CinemaWorker3.DoWork -= new DoWorkEventHandler(ActivatedCinema3);
            CinemaWorker3.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(ActivationComplete3);
            Start3_btn.Enabled = true;
            Start3_btn.BackColor = Color.Lime;
            Start3_btn.Text = "Start";
        }
        private void ActivationComplete4(object sender, EventArgs e)
        {
            CinemaWorker4.DoWork -= new DoWorkEventHandler(ActivatedCinema4);
            CinemaWorker4.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(ActivationComplete4);
            Start4_btn.Enabled = true;
            Start4_btn.BackColor = Color.Lime;
            Start4_btn.Text = "Start";
            ProtectCheckBox4.Checked = true;
        }
        private void ActivationComplete5(object sender, EventArgs e)
        {
            CinemaWorker5.DoWork -= new DoWorkEventHandler(ActivatedCinema5);
            CinemaWorker5.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(ActivationComplete5);
            Start5_btn.Enabled = true;
            Start5_btn.BackColor = Color.Lime;
            Start5_btn.Text = "Start";
        }
        private void ActivationComplete6(object sender, EventArgs e)
        {
            CinemaWorker6.DoWork -= new DoWorkEventHandler(ActivatedCinema6);
            CinemaWorker6.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(ActivationComplete6);
            Start6_btn.Enabled = true;
            Start6_btn.BackColor = Color.Lime;
            Start6_btn.Text = "Start";
        }
        private void ActivationComplete7(object sender, EventArgs e)
        {
            CinemaWorker7.DoWork -= new DoWorkEventHandler(ActivatedCinema7);
            CinemaWorker7.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(ActivationComplete7);
            Start7_btn.Enabled = true;
            Start7_btn.BackColor = Color.Lime;
            Start7_btn.Text = "Start";
        }
        #endregion
        //#########################

        //#########################
        #region Text Change Handlers
        //#########################
        #region Load Text Display
        public void LoadText1()
        {
            ShowState1.Text = "Loading";
        }
        public void LoadText2()
        {
            ShowState2.Text = "Loading";
        }
        public void LoadText3()
        {
            ShowState3.Text = "Loading";
        }
        public void LoadText4()
        {
            ShowState4.Text = "Loading";
        }
        public void LoadText5()
        {
            ShowState5.Text = "Loading";
        }
        public void LoadText6()
        {
            ShowState6.Text = "Loading";
        }
        public void LoadText7()
        {
            ShowState7.Text = "Loading";
        }
        #endregion
        //#########################
        #region Pause Text Display
        public void PauseText1()
        {
            ShowState1.Text = "Pause";
        }
        public void PauseText2()
        {
            ShowState2.Text = "Pause";
        }
        public void PauseText3()
        {
            ShowState3.Text = "Pause";
        }
        public void PauseText4()
        {
            ShowState4.Text = "Pause";
        }
        public void PauseText5()
        {
            ShowState5.Text = "Pause";
        }
        public void PauseText6()
        {
            ShowState6.Text = "Pause";
        }
        public void PauseText7()
        {
            ShowState7.Text = "Pause";
        }
        #endregion
        //#########################
        #region ADV Start Text Display
        public void PlayText1()
        {
            AdvState1.Text = "Playing";
        }
        public void PlayText2()
        {
            AdvState2.Text = "Playing";
        }
        public void PlayText3()
        {
            AdvState3.Text = "Playing";
        }
        public void PlayText4()
        {
            AdvState4.Text = "Playing";
        }
        public void PlayText5()
        {
            AdvState5.Text = "Playing";
        }
        public void PlayText6()
        {
            AdvState6.Text = "Playing";
        }
        public void PlayText7()
        {
            AdvState7.Text = "Playing";
        }
        #endregion
        //#########################
        #region ADV STOP Text Display
        public void StopText1()
        {
            AdvState1.Text = "Stop";
        }
        public void StopText2()
        {
            AdvState2.Text = "Stop";
        }
        public void StopText3()
        {
            AdvState3.Text = "Stop";
        }
        public void StopText4()
        {
            AdvState4.Text = "Stop";
        }
        public void StopText5()
        {
            AdvState5.Text = "Stop";
        }
        public void StopText6()
        {
            AdvState6.Text = "Stop";
        }
        public void StopText7()
        {
            AdvState7.Text = "Stop";
        }

        #endregion
        //#########################
        #region Clear ADV and Show Text
        public void ClearText1()
        {
            ShowState1.Text = "-=-";
            AdvState1.Text = "-=-";
            ProtectCheckBox1.Checked = true;
        }
        public void ClearText2()
        {
            ShowState2.Text = "-=-";
            AdvState2.Text = "-=-";
            ProtectCheckBox2.Checked = true;
        }
        public void ClearText3()
        {
            ShowState3.Text = "-=-";
            AdvState3.Text = "-=-";
            ProtectCheckBox3.Checked = true;
        }
        public void ClearText4()
        {
            ShowState4.Text = "-=-";
            AdvState4.Text = "-=-";
            ProtectCheckBox4.Checked = true;
        }
        public void ClearText5()
        {
            ShowState5.Text = "-=-";
            AdvState5.Text = "-=-";
            ProtectCheckBox5.Checked = true;
        }
        public void ClearText6()
        {
            ShowState6.Text = "-=-";
            AdvState6.Text = "-=-";
            ProtectCheckBox6.Checked = true;
        }
        public void ClearText7()
        {
            ShowState7.Text = "-=-";
            AdvState7.Text = "-=-";
            ProtectCheckBox7.Checked = true;
        }

        #endregion
        //#########################
        #region Error Displayer


        #endregion
        //#########################

        //#########################
        #region Logbox Display
        //public void ADVError()
        //{

        //    string message = (WhoDoesError + " " + CinemaNumber + " Error");
        //    LogBox.Text += "\r\n";
        //    LogBox.Text += message;
        //    LogBox.Find(message);
        //    LogBox.SelectionColor = Color.Red;
        //    LogBox.ScrollToCaret();
        //}
        //public void TibboError()
        //{
        //    ShowState1.Text = "-=-";
        //    AdvState1.Text = "-=-";
        //}

        #endregion
        //#########################

        //#########################
        #endregion
        //#########################
        #region Error Recorder

        public void ReportError(int CinemaNumber, string WhoDoesError, string ErrorMessage)
        {
            //==============================================
            //Delegete AdvEror = new Delegete(ADVError);
            //Delegete TibboEror = new Delegete(TibboError);
            //==============================================

            SaveError(CinemaNumber, WhoDoesError, ErrorMessage);
        }
        public void SaveError(int CinemaNumber, string Operation, string ErrorMessage)
        {
            DateTime CurrentTime = DateTime.Now;
            string AppLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FolderPath = AppLocation + "\\ErrorLogs";
            string TextPath = FolderPath + "\\" + CinemaNumber + "\\" + Operation + ".txt";
            StringBuilder result = new StringBuilder();

            if (System.IO.File.Exists(TextPath))
            {
                using (StreamReader streamReader = new StreamReader(TextPath))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string newLine = String.Concat("", line, "", Environment.NewLine);
                        newLine = newLine.Replace(" ", " ");
                        result.Append(newLine);
                    }
                    streamReader.Close();
                }
            }
            using (FileStream fileStream = new FileStream(TextPath, FileMode.Create))
            {
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine("### " + CurrentTime.ToString("dd-MM-yy ###" + " HH:mm:ss ") + "### " + ErrorMessage + "###");
                streamWriter.Write(result);
                streamWriter.Close();
                fileStream.Close();
            }
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            ReportError(1, "ConnectionsError", "Akuna Matata");
        }

        private void ProtectCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ProtectCheckBox1.Checked == true)
            {
                ProtectionPanel1.Visible = true;
            }
            else
            {
                ProtectionPanel1.Visible = false;
            }
            if (ProtectCheckBox2.Checked == true)
            {
                ProtectionPanel2.Visible = true;
            }
            else
            {
                ProtectionPanel2.Visible = false;
            }
            if (ProtectCheckBox3.Checked == true)
            {
                ProtectionPanel3.Visible = true;
            }
            else
            {
                ProtectionPanel3.Visible = false;
            }
            if (ProtectCheckBox4.Checked == true)
            {
                ProtectionPanel4.Visible = true;
            }
            else
            {
                ProtectionPanel4.Visible = false;
            }
            if (ProtectCheckBox5.Checked == true)
            {
                ProtectionPanel5.Visible = true;
            }
            else
            {
                ProtectionPanel5.Visible = false;
            }
            if (ProtectCheckBox6.Checked == true)
            {
                ProtectionPanel6.Visible = true;
            }
            else
            {
                ProtectionPanel6.Visible = false;
            }
            if (ProtectCheckBox7.Checked == true)
            {
                ProtectionPanel7.Visible = true;
            }
            else
            {
                ProtectionPanel7.Visible = false;
            }

        }
        private void ProtectCheckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ProtectCheckBoxAll.Checked == true)
            {
                ProtectionPanel8.Visible = true;
                ProtectCheckBox1.Checked = true;
                ProtectCheckBox2.Checked = true;
                ProtectCheckBox3.Checked = true;
                ProtectCheckBox4.Checked = true;
                ProtectCheckBox5.Checked = true;
                ProtectCheckBox6.Checked = true;
                ProtectCheckBox7.Checked = true;
            }
            else
            {
                ProtectionPanel8.Visible = false;
                ProtectCheckBox1.Checked = false;
                ProtectCheckBox2.Checked = false;
                ProtectCheckBox3.Checked = false;
                ProtectCheckBox4.Checked = false;
                ProtectCheckBox5.Checked = false;
                ProtectCheckBox6.Checked = false;
                ProtectCheckBox7.Checked = false;

            }
        }
        //=============================================================
        #region Admin Access panel
        private void admin_btn_Click(object sender, EventArgs e)
        {
            admin_btn.Click -= new EventHandler(admin_btn_Click);
            admin_btn.Click += new EventHandler(LoginAdmin);
            admin_btn.Text = "Login";
            admin_btn.ForeColor = Color.Green;
            name_lbl.Visible = true;
            Name_text.Visible = true;
            pass_lbl.Visible = true;
            Pass_text.Visible = true;

        }
        private void LoginAdmin(object sender, EventArgs e)
        {
            if (Name_text.Text == "art" && Pass_text.Text == "9768")
            {
                admin_btn.Click -= new EventHandler(LoginAdmin);
                admin_btn.Click += new EventHandler(DisconnectAdmin);
                name_lbl.Visible = false;
                Name_text.Visible = false;
                pass_lbl.Visible = false;
                Pass_text.Visible = false;
                permission_lbl.Text = "Admin";
                permission_lbl.ForeColor = Color.Gold;
                admin_btn.Text = "Disconnect";
                admin_btn.ForeColor = Color.Red;
                Name_text.Clear();
                Pass_text.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect name or password GTFO pl0x :D");
                admin_btn.Text = "Admin Access";
                admin_btn.ForeColor = Color.Black;
                admin_btn.Click += new EventHandler(admin_btn_Click);
                admin_btn.Click -= new EventHandler(LoginAdmin);
                name_lbl.Visible = false;
                Name_text.Visible = false;
                pass_lbl.Visible = false;
                Pass_text.Visible = false;
            }
        }
        //=============================================================
        private void DisconnectAdmin(object sender, EventArgs e)
        {
            admin_btn.Click -= new EventHandler(DisconnectAdmin);
            admin_btn.Click += new EventHandler(admin_btn_Click);
            admin_btn.Text = "Admin Access";
            admin_btn.ForeColor = Color.Black;
            permission_lbl.Text = "Basic user";
            permission_lbl.ForeColor = Color.Lime;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Automation.exe");
            Environment.Exit(1);
        }
        #endregion
        //=============================================================






    }
}

