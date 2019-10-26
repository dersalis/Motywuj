using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;

namespace Atrx.WindowsPhone.Motywuj
{
	public class SettingsManagement :IDisposable
	{
		//ustawienia aplikacji - zapis/odczyt
		////v1.0.0.2
		IsolatedStorageSettings _appSettings;

		//
		//konstruktor
		//
		public SettingsManagement()
		{
			//ustawienia
			_appSettings = IsolatedStorageSettings.ApplicationSettings;	
		}

		#region PIERWSZY START

		//
		//Odczytuje wartość z ustawień
		////v1.0.0.2
		public bool LoadFirstStart(string settingName)
		{
			/*
			 * CEL:
			 * Odczytuje wartość z ustawień
			 * 
			 * WARTOŚĆ WEJŚCIOWA:
			 * settingName:string - nazwa ustawienia
			 * 
			 * WARTOŚĆ ZWRACANA:
			 * bool - wartość odczytana
			 */

			//ustaw wartość początkową - true - czyli program uruchomiono pierwszy raz
			bool settValue = true;

			//jeśli ustawienia istnieją to je odczytaj
			if (_appSettings.Contains(settingName))
				settValue = (bool)_appSettings[settingName];
			//zwróć
			return settValue;
		}

		//
		//Zapisuje wartość do ustawień
		////v1.0.0.2
		public void SaveFirstStart(string settingName, bool settingValue)
		{
			/*
			 * CEL:
			 * Zapisuje wartość do ustawień
			 * 
			 * WARTOŚĆ WEJŚCIOWA:
			 * settingName:string - nazwa ustawienia
			 * settingValue:bool - wartość ustawień
			 */

			//zapisz ustawienia 
			//jeśli zmienna ustawień istnieje to zapisz wartość
			if (_appSettings.Contains(settingName))
				_appSettings[settingName] = settingValue;
			//jeśli zmienna ustawień nie istnieje to ją utwórz i zapisz wartość
			else _appSettings.Add(settingName, settingValue);
		}

		#endregion

		#region INDEKS SORTOWANIA

		//
		//Odczytuje wartość z ustawień
		////v1.0.0.2
		public byte LoadSortIndex(string settingName)
		{
			/*
			 * CEL:
			 * Odczytuje wartość z ustawień
			 * 
			 * WARTOŚĆ WEJŚCIOWA:
			 * settingName:string - nazwa ustawienia
			 * 
			 * WARTOŚĆ ZWRACANA:
			 * bool - wartość odczytana
			 */

			//ustaw wartość początkową - true - czyli program uruchomiono pierwszy raz
			byte settValue = 0;

			//jeśli ustawienia istnieją to je odczytaj
			if (_appSettings.Contains(settingName))
				settValue = (byte)_appSettings[settingName];
			//zwróć
			return settValue;
		}

		//
		//Zapisuje wartość do ustawień
		////v1.0.0.2
		public void SaveSortIndex(string settingName, byte settingValue)
		{
			/*
			 * CEL:
			 * Zapisuje wartość do ustawień
			 * 
			 * WARTOŚĆ WEJŚCIOWA:
			 * settingName:string - nazwa ustawienia
			 * settingValue:bool - wartość ustawień
			 */

			//zapisz ustawienia 
			//jeśli zmienna ustawień istnieje to zapisz wartość
			if (_appSettings.Contains(settingName))
				_appSettings[settingName] = settingValue;
			//jeśli zmienna ustawień nie istnieje to ją utwórz i zapisz wartość
			else _appSettings.Add(settingName, settingValue);
		}

		#endregion

		public void Dispose()
		{
			//throw new NotImplementedException();
		}
	}
}
