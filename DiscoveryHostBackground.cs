/*
 * Сделано в SharpDevelop.
 * Пользователь: 055makarov
 * Дата: 22.10.2014
 * Время: 13:35
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Net;
namespace RemoteLaunchAppClient
{
	/// <summary>
	/// Description of DiscoveryClientBackground.
	/// </summary>
	public class DiscoveryHostBackground
	{
		SynchronizationContext context;
		public event Action<Dictionary<string,string>> DiscoveryHostCompleted;
		public DiscoveryHostBackground()
		{
		
		}
		
		public void DoWork()
		{
			context=SynchronizationContext.Current;
			Task<Dictionary<string,string>> t = new Task<Dictionary<string,string>>(()=>{
			 	return	RemoteLaunchAppServiceClientHelper.FindRemoteLaunchAppService(); 	
			});
			
			t.ContinueWith((t1)=>{
				context.Post((o)=>{
			    	if(DiscoveryHostCompleted!=null)	DiscoveryHostCompleted(t1.Result);
				},null);
			});
			
			t.ContinueWith((o)=>{},TaskContinuationOptions.OnlyOnFaulted);
			
			t.Start();
		}
		
	
	
	}
}
