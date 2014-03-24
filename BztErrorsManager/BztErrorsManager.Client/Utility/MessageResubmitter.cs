using System.IO;
using System.Net;
using System.Text;

namespace BztErrorsManager.Client.Utility
{
	public static class MessageResubmitter
	{
		public static HttpStatusCode ResubmitHTTP(string resubmitUrl, string msgContent, string msgContentType) {
			// on transforme le message à rejouer en Stream
			var msgStream = new MemoryStream(ASCIIEncoding.Default.GetBytes(msgContent));

			// création de la requête HTTP à partir de l'URL
			var httpRequest = (HttpWebRequest)WebRequest.Create(resubmitUrl);
			httpRequest.Headers.Set(HttpRequestHeader.Pragma, "no-cache");
			httpRequest.KeepAlive = true;
			httpRequest.Timeout = 300000;
			httpRequest.Method = "POST";
			httpRequest.ContentType = msgContentType;
			httpRequest.UseDefaultCredentials = true;

			// resoumission du message
			using (var sr = new StreamReader(msgStream, Encoding.ASCII)) {
				var returnCode = HttpStatusCode.InternalServerError;
				HttpWebResponse response;

				var sw = new StreamWriter(httpRequest.GetRequestStream());

				sw.WriteLine(sr.ReadToEnd());
				sw.Flush();
				sw.Close();

				try {
					response = httpRequest.GetResponse() as HttpWebResponse;
					returnCode = response.StatusCode;
				}
				catch (WebException webex) {
					response = (HttpWebResponse)webex.Response;
					returnCode = response.StatusCode;
				}
					
				return returnCode;
			}
		}
	}
}
