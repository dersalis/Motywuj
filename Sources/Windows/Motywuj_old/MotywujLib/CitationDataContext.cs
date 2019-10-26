using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq;
using System.Data.Linq.Mapping;

//using Atrx.WindowsPhone.Motywuj;

namespace Atrx.WindowsPhone.Motywuj
{
	public class CitationDataContext : DataContext
	{
		// Konstruktor
		public CitationDataContext(string connectionString)
			: base(connectionString) 
		{ }

		// Zwróć tabele
		public Table<Citation> Citations;
		//{
		//	get { return this.GetTable<Citation>(); }
		//}
	}
}
