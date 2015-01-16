/*
 * Сделано в SharpDevelop.
 * Пользователь: 055makarov
 * Дата: 16.10.2014
 * Время: 13:42
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using RemoteLaunchAppClient.ServiceReference; 
namespace RemoteLaunchAppClient
{

	public partial class MainForm : Form,IRemoteLaunchAppServiceCallback
	{
		RemoteLaunchAppClient.ServiceReference.RemoteLaunchAppServiceClient sс;
		bool intMod =false;
		int defaultProcessLifeTime=60;
		
        HostHistory hh;
		public MainForm()
		{
			InitializeComponent();
            hh = new HostHistory(Properties.Settings.Default.HostHistory);
            ParseHostHistory(hh.HostHistoryData);
			txtTimeToExit.Text=defaultProcessLifeTime.ToString();
		}

        void ParseHostHistory(Queue<string> q)
        {
            ToolStripItemCollection ic = ((ToolStripDropDownItem)menuHostHistoy.Items[0]).DropDown.Items;
            ic.Clear();
            if (q != null)
            {
                foreach (var item in q)
                {
                    ToolStripItem tsi = ic.Add(item);
                    tsi.Click += (o, ars) =>
                    {
                        txtComputerName.Text = o.ToString();
                        intMod = false;
                        rIntDisabled.Checked = true;
                    };
                }
            }
        
        }
		
        void CreateClientEndLaunch(string compName,string command,string args,TimeSpan procLifeTime)
        {
        	if (sс != null && sс.State != CommunicationState.Faulted)
            {
                //sс.CloseProg();
                sс.Close();
            }
					

            sс=RemoteLaunchAppClient.RemoteLaunchAppServiceClientHelper.CreateClient(this,compName);
            sс.SubscribeRecieved();
            sс.LaunchProg(command, args,procLifeTime);
        }
        
        void BtnLaunchClick(object sender, EventArgs e)
		{
            try{

                if (txtComputerName.Text == "")
                {
                    CleanData();
                    RecievedData("Укажите имя или IP-адресс сервера");
                    return;
                }
                if(rIntDisabled.Checked==true)
                {
                    CleanData();
                	intMod = false;
                    
                    string[] strArr = txtInput.Text.Split(new char[] { ' ' }, 2);

                    string command = strArr[0];
                    string args = String.Empty;
                    if (strArr.Length == 2)
                    {

                        args = strArr[1];
                    }

                    CreateClientEndLaunch(txtComputerName.Text,command,args,ParseTime());
                    ParseHostHistory(hh.UpdateHostHistory(txtComputerName.Text));
                }
                else if(rIntEnabled.Checked==true && intMod ==false)
                {
                	CleanData();
                
                	 CreateClientEndLaunch(txtComputerName.Text,"cmd","",ParseTime());
                     intMod = true;
                	 ParseHostHistory(hh.UpdateHostHistory(txtComputerName.Text));
                
                }
                else if(intMod == true && rIntEnabled.Checked==true)
                {
                	sс.SendMessage(txtInput.Text);
               
                }
            }
            catch (UriFormatException ex)
            {
                RecievedData(ex.Message);
            }
            catch(CommunicationException ex)
            {
            	if(intMod==true) intMod=false;
            	RecievedData(ex.Message);
            }
		}
	
		private TimeSpan ParseTime()
		{
			 long timeToExit = 0;
             long.TryParse(txtTimeToExit.Text, out timeToExit);

             if (txtTimeToExit.Text != "" && timeToExit != 0)
             	return TimeSpan.FromSeconds(timeToExit);
             else
             	return TimeSpan.FromSeconds(defaultProcessLifeTime);
		
		}
		
		public void RecievedData(string data)
		{
			if(data!=null && data!="")
			{
				data=data+Environment.NewLine;
			}
			this.txtOutput.Text+=data;
			txtOutput.SelectionStart = txtOutput.Text.Length;
			txtOutput.ScrollToCaret();
		}
		
		public void CleanData()
		{
			this.txtOutput.Text="";
		}
		
		void BtnCheckConnectionClick(object sender, EventArgs e)
		{
			try{


                if (txtComputerName.Text == "")
                {
                    CleanData();
                    RecievedData("Укажите имя или IP-адресс сервера");
                    return;
                }
                
				if(sс!=null && sс.State!=CommunicationState.Faulted){

                    sс.Close();              
				}
				rIntDisabled.Checked=true;
                intMod = false;
			    CleanData();
				sс=RemoteLaunchAppClient.RemoteLaunchAppServiceClientHelper.CreateClient(this,txtComputerName.Text);
				sс.Open();
                ParseHostHistory(hh.UpdateHostHistory(txtComputerName.Text));
				RecievedData(string.Format("Open connection with {0}",txtComputerName.Text));
				
			}
			catch (UriFormatException ex)
            {
                RecievedData(ex.Message);
            }
            catch(CommunicationException ex)
            {
            	RecievedData(ex.Message);
            }
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			
			if(sс!=null && sс.State!=CommunicationState.Faulted){
                        sс.Close();              
			}

            hh.SaveHostHistory(Properties.Settings.Default);
		}
		
		void BtnSearchHostsClick(object sender, EventArgs e)
		{
			SelectHostForm shf = new SelectHostForm();
			shf.ShowDialog();
			if(shf.DialogResult== DialogResult.Cancel && shf.SelectedHostIp!=null)
			{
				txtComputerName.Text = shf.SelectedHostIp;
				rIntDisabled.Checked=true;
			}
		}
		
		void RIntEnabledCheckedChanged(object sender, EventArgs e)
		{
			txtComputerName.Enabled = !rIntEnabled.Checked;	
		}
		
	}
}
