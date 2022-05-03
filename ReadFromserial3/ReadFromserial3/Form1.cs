using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ReadFromserial3
{
    public partial class Form1 : Form
    {

        #region defined global variable

        string dataOut;
        string sendWith;
        string dataIn; //global varaible data string type
        List<int> s2MW = new List<int>();
        string s1mwr;
        // initialized for later...to separate data

        StreamWriter objStreamWriter;
        string pathfile= @"C:\Users\aachary\source\repos\ReadFromserial3\ReadFromserial3\_My source File\SerialData.txt";
        bool state_AppendText = true;
        
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        #region unwanted label
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            CBoxCOMPORT.Items.AddRange(ports);

            btnOPEN.Enabled = true;
            btnCLOSE.Enabled=false;
            serialPort1.DtrEnable = false;
            chBoxDTREnable.Checked = false;
            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnCLOSE.Enabled = false;
            btnSENDDATA.Enabled = false;
            chboxWriteLine.Checked = false;
            chboxWrite.Checked = true;
            sendWith = "write";
            chBoxAddTodata.Checked = true;
            chBoxAlwaysUpdate.Checked = false;
            toolStripComboBox3.Text = "Hex";
            toolStripComboBox4_TxData.Text = "Hex";
            CBoxBAUDRATE.Text = "38400";


        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBoxPARITYBITS.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                btnCLOSE.Enabled = true;
                btnOPEN.Enabled = false;
                labelCOMportstatus.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCLOSE.Enabled = false;
                btnOPEN.Enabled = true;
                labelCOMportstatus.Text = "OFF";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                tboxDATAOUT.Text = "";
                btnOPEN.Enabled = true;
                labelCOMportstatus.Text = "OFF";

            }
        }

        

        private void btnSENDDATA_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = tboxDATAOUT.Text;
                if (sendWith == "writeline")
                {
                    serialPort1.WriteLine(dataOut);
                }
                else if (sendWith =="write")
                {
                    serialPort1.Write(dataOut);
                }
                 //change writeline to write if we want to write in same line
            }
        }


        #region handshake rts dtr
        private void chBoxDTREnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDTREnable.Checked)
            {
                serialPort1.DtrEnable = true;
                //MessageBox.Show(""DTR Enable" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);......need to fix
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRTSEnable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }
        #endregion

        private void btnCleardataout_Click(object sender, EventArgs e)
        {
            if (tboxDATAOUT.Text != "")
            {
                tboxDATAOUT.Text = "";
            }
        }

        private void tboxDATAOUT_TextChanged(object sender, EventArgs e)
        {
            int dataOutlength = tboxDATAOUT.Text.Length;
            labelDataOutLength.Text = String.Format("{0:00}", dataOutlength); //writing string format to 2 digit
            if (chboxUsingenter.Checked)
            {
                tboxDATAOUT.Text = tboxDATAOUT.Text.Replace(Environment.NewLine, "");   ///this is to prevent enter kewy to create a new line
            }
        }

        private void chboxUsingbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxUsingbutton.Checked)
            {
                btnSENDDATA.Enabled = true;

            }
            else
            {
                btnSENDDATA.Enabled = false;
            }
        }

        private void labelCOMportstatus_Click(object sender, EventArgs e)
        {
            //if (btnCLOSE.Enabled == true)
            //{
            //    labelCOMportstatus.Text = "ON";
            //}
        }

        private void tboxDATAOUT_KeyDown(object sender, KeyEventArgs e)
        {
            if(chboxUsingenter.Checked)
            {
                if(e.KeyCode == Keys.Enter)  // if enter key is pressed
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOut = tboxDATAOUT.Text;
                        if (sendWith == "writeline")
                        {
                            
                            serialPort1.WriteLine(dataOut);
                        }
                        else if (sendWith == "write")
                        {
                            serialPort1.Write(dataOut);
                        } //change writeline to write if we want to write in same line
                    }
                }
            }
        }

        private void chboxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxWriteLine.Checked)
            {
                sendWith = "writeline";           // store string data , this one is to determine which one would be using writeline or write
                chboxWrite.Checked = false;
                chboxWriteLine.Checked = true;
            }
        }
        private void chboxwrite_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxWrite.Checked)
            {
                sendWith = "write";
                chboxWrite.Checked = true;
                chboxWriteLine.Checked = false;
            }
        }

        private void chboxUsingenter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ta_Click(object sender, EventArgs e)
        {

        }
        #region readdatafrom serialport
        List<List<byte>> packages = new List<List<byte>>();
              
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var dataIn = serialPort1.BytesToRead;
            var rest = dataIn % 9;
            byte[] dataBuffer =new byte[dataIn- rest];      // for dataformat new added list dekhi
            
            serialPort1.Read(dataBuffer,0, dataIn- rest);
            packages = new List<List<byte>>();
            for (int i = 0; i < dataBuffer.Count()- rest; i += 9)
            {
                var firstList = dataBuffer.ToList().GetRange(i, 9);

                packages.Add((firstList));
            }
           

            this.Invoke(new EventHandler(showData));
           //this methode show the data serial into textbox , cant be shown directly to the textbox
        }
        
        public void showData(object sender, EventArgs e)
        {
            
            lbDataInLength.Text = String.Format("{0:00}", packages.Count*9);  //in that format
            foreach(var lst in packages)
            {
                var dataIn = string.Join("", lst.Select(n => n.ToString("X2"))) + '\n';


                if (chBoxAlwaysUpdate.Checked)
                {
                    tBoxDataIN.Text= dataIn;
                }
                else if (chBoxAddTodata.Checked)
                {
                    tBoxDataIN.AppendText(dataIn);

                }
               
            }
            List<int> s1MW = new List<int>();

            foreach (var lst in packages)
            {
                s1MW.Add(lst[1]);
                s2MW.Add(lst[5]);
                var s2mwr= string.Join(" ", s2MW.Select(n => n.ToString("X2"))) + '\n';
                s1mwr = string.Join(" ",s1MW.Select(n => n.ToString("X2"))) + '\n';
                richTextBox1.AppendText(s1mwr);
                richTextBox2.AppendText(s2mwr);

            }
            
            //new data save
            try
            {
                objStreamWriter = new StreamWriter(pathfile, state_AppendText);
                objStreamWriter.Write(dataIn);
                objStreamWriter.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

           
        }
        #endregion
        #region data forplotting
        public static List<Measurement> GetData()
        {
            var measurements = new List<Measurement>();

            var startDate = DateTime.Now.AddMinutes(-10);
            List<int> s11 = new List<int>();
            var r = new Random();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    measurements.Add(new Measurement() { SensorId = i, DateTime = startDate.AddMinutes(j), value=r.Next(1,30)});
                }
            }
            measurements.Sort((m1, m2) => m1.DateTime.CompareTo(m2.DateTime));
            return measurements;
            
            
        }
        public  static List<Measurement> GetUpdateData(DateTime dateTime)
        {
            var measurements = new List<Measurement>();
            var r = new Random();


            for (int i = 0; i < 5; i++)
            {
                measurements.Add(new Measurement() { SensorId = i, DateTime = dateTime.AddSeconds(1), value=r.Next(1,30) });
            }
            return measurements;
        }
        public class Measurement
        {
            public int SensorId { get; set; }      //(byte wise sensor name )
            public int value { get; set; }
            public string vs { get; set; }
            public DateTime DateTime { get; set; }
        }
        #endregion
        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked= true;
                chBoxAddTodata.Checked = false;
            }
            else
            {
                chBoxAddTodata.Checked=true;
            }
            
        }

        private void chBoxAddTodata_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddTodata.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddTodata.Checked = true;
            }
            else
            {
                chBoxAlwaysUpdate.Checked=true; 
                }
        }

        private void btnClearDataInReceiver_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }
        private void btnDemo_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.ShowDialog();
        }
        #region unwanted
        private void endLineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataFormatToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void toolStripComboBox_appendOrOverwrite_DropDownClosed(object sender, EventArgs e)
        {
            if(toolStripComboBox_appendOrOverwrite.Text=="Append Text")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;
            }
        }

        #region open and save file text

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 =new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream=openFileDialog1.OpenFile())!=null){
                    string strfilename = openFileDialog1.FileName;
                    string filetext=File.ReadAllText(strfilename);
                    // MessageBox.Show(strfilename);  dont need to show message in message box
                    tBoxDataIN.Text=filetext;

                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(Stream s=File.Open(saveFileDialog1.FileName,FileMode.CreateNew))
                    using(StreamWriter sw= new StreamWriter(s))
                {
                    sw.Write(tBoxDataIN.Text);
                }
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
