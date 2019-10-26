using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Phone.Tasks;

namespace Atrx.WindowsPhone.Motywuj
{
	public class ShareManagement : IDisposable
	{
		//
		// Udostępnia cytat za pomocą wiadomości sms
		//
		public void ShareViaSms(string content, string author)
		{
			/*
			 * CEL:
			 * Tworzy wiadomość sms z cytatem i wysyła ją
			 * 
			 * PARAMETRY WEJŚCIOWE:
			 * content:string - treść cytatu
			 * author:string - autor cytatu
			 */

			// Zadanie 
			var smsTask = new SmsComposeTask();
			// Treść cytatu
			smsTask.Body = CreateTextMessage(content, author);
			// Wyślij cytat
			smsTask.Show();
		}


		//
		//udostępnia cytat za pomocą wiadomości email
		//
		public void ShareViaEmail(string content, string author)
		{
            /*
             * CEL:
             * Tworzy wiadomość email z cytatem i wysyła ją
             * 
             * PARAMETRY WEJŚCIOWE:
             * content:string - treść cytatu
             * author:string - autor cytatu
             */

            // Zadanie
			var emailTask = new EmailComposeTask();
			// Tytuł wiadomości
			emailTask.Subject = "Cytat motywujący";
			// Treść wiadomości
			emailTask.Body = CreateEmailBody(content ,author);
			// Wyślij wiadomość
			emailTask.Show();
		}


		//
		//udostępnia cytat do sieci społecznościowej
		//
		public void ShareViaSocialNetwork(string content, string author)
		{
			/*
			 * CEL:
			 * Tworzy wiadomość społecznościową z cytatem i wysyła ją
			 * 
			 * PARAMETRY WEJŚCIOWE:
			 * content:string - tytuł notatki
			 * author:string - treść notatki 
			 */

			//zadanie
			var snTask = new ShareStatusTask();
			//treść wiadomości
			snTask.Status = CreateTextMessage(content, author);
			//wyślij wiadomość
			snTask.Show();
		}


		//
		//tworzy miadomość tekstową sms lub dla sieci społecznościowej
		//
		private string CreateTextMessage(string content, string author)
		{
            /*
             * CEL:
             * Tworzy wiadomość tekstową z połączenia treści oraz autora cytatu
             * 
             * PARAMETRY WEJŚCIOWE:
             * content:string - treść cytatu
             * author:string - autor cytatu
             * 
             * WARTOŚĆ ZWRACANA:
             * string - treść wiadomości 
             */

            // Utwórz wiadomość
			string textMessage = string.Format("\"{0}\" - {1}", content, author);
			// Zwróć wiadomość
			return textMessage;
		}


		//
		//tworzy treść wiadomości email
		//
		private string CreateEmailBody(string content, string author)
		{
            /*
             * CEL:
             * Tworzy treść wiadomości email z połączenia treści i autora cytatu oraz informacji
             * o programie
             * 
             * PARAMETRY WEJŚCIOWE:
             * content:string - treść cytatu
             * author:string - autor cytatu
             * 
             * WARTOŚĆ ZWRACANA:
             * string - treść email
             */

            // Informacja o programie
            string info = "Cytat pochodzi z programu Motywuj dla Windows Phone";
			// Utwórz wiadomość
			string emailBody = string.Format("\"{0}\" - {1}\n\n{2}", content, author, info);
			// Zwróć wiadomość
			return emailBody;
		}


		public void Dispose()
		{
			//throw new NotImplementedException();
		}
	}
}
