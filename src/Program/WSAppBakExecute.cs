using System;
using WSAppBak;

namespace WSAppBak.Program
{
	internal class WSAppBakExecute
	{
		private static void Main(string[] args)
		{
			Console.Title = "WSAppBak";
			WSAppBak.Services.WSAppBak wSAppBak = new WSAppBak.Services.WSAppBak();
			wSAppBak.Run();
		}
	}
}
