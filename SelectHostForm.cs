/*
 * Сделано в SharpDevelop.
 * Пользователь: 055makarov
 * Дата: 22.10.2014
 * Время: 13:20
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Collections.Generic;
namespace RemoteLaunchAppClient
{
	/// <summary>
	/// Description of SelectHostForm.
	/// </summary>
	public partial class SelectHostForm : Form
	{
		private string _selectedHostIp;
		
		public string SelectedHostIp
		{
			get
			{
				return _selectedHostIp;
			}
		}
		
		public SelectHostForm()
		{
			InitializeComponent();
		}
		
		void SelectHostFormLoad(object sender, EventArgs e)
		{
			lblProcess.Text="Выполняется поиск серверов...";
			DiscoveryHostBackground dhb = new DiscoveryHostBackground();
			dhb.DiscoveryHostCompleted+= new Action<Dictionary<string,string>>(dhb_DiscoveryHostCompleted);
			dhb.DoWork();
			
		}

		void dhb_DiscoveryHostCompleted(Dictionary<string,string> d)
		{
			if(d.Count==0)
			{
				lblProcess.Text="Поиск не дал результатов";
			}
			else
			{
				lblProcess.Text="Поиск завершен";
			}
			foreach(KeyValuePair<string,string> entry in d)
			{
						dataGridView1.Rows.Add(entry.Key,entry.Value);	
			}
		}
		
		void DataGridView1CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int row = e.RowIndex;
			if(row!=-1)
			{_selectedHostIp=dataGridView1[1,row].Value as string;
				this.Close();	}
		}
	}
}
