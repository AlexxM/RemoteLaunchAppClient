/*
 * Сделано в SharpDevelop.
 * Пользователь: 055makarov
 * Дата: 20.10.2014
 * Время: 11:43
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using RemoteLaunchAppClient;
using System.ServiceModel;
using System.ServiceModel.Discovery;
using System.Net;
using System.Collections.Generic;
using RemoteLaunchAppClient.ServiceReference;
namespace RemoteLaunchAppClient
{
	/// <summary>
	/// Description of RemoteLaunchAppService.
	/// </summary>
	public class RemoteLaunchAppServiceClientHelper
	{
		
		public static RemoteLaunchAppServiceClient CreateClient(IRemoteLaunchAppServiceCallback c,string name)
		{
			Uri uri =new Uri("net.tcp://"+name+":8089/RemoteLaunchAppService");
			EndpointAddress ea = new EndpointAddress(uri);
			NetTcpBinding tcpBinding = new NetTcpBinding(SecurityMode.None);
            tcpBinding.SendTimeout = new TimeSpan(0, 0, 0, 0, 60000);
            tcpBinding.OpenTimeout = new TimeSpan(0, 0, 0, 0, 60000);
            tcpBinding.MaxReceivedMessageSize = 65000;
            tcpBinding.ReaderQuotas.MaxStringContentLength = 10000;
            tcpBinding.ReaderQuotas.MaxDepth = 10000;
            tcpBinding.ReaderQuotas.MaxArrayLength = 10000;
            tcpBinding.MaxConnections = 10;

            InstanceContext context = new InstanceContext(c);
            RemoteLaunchAppServiceClient client = new RemoteLaunchAppServiceClient(context, tcpBinding, ea);
            return client;
		}
		
		public static Dictionary<string,string> FindRemoteLaunchAppService()
		{
			Dictionary<string,string> d = new Dictionary<string,string>();
			DiscoveryClient dc = new DiscoveryClient(new UdpDiscoveryEndpoint());
			FindCriteria criteria = new FindCriteria(typeof(IRemoteLaunchAppService));
			criteria.Duration=TimeSpan.FromSeconds(7);
			FindResponse fr = dc.Find(criteria);
			foreach(var endpoint in fr.Endpoints)
			{
				string ip = endpoint.Address.Uri.Host;
				IPHostEntry entry = Dns.GetHostEntry(ip);
				d.Add(entry.HostName,ip);
			}
			
			return d;
		}
	}
}
