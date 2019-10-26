using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Atrx.WindowsPhone.Motywuj
{
	[Table]
	public class Citation
	{
        // Indeks cytatu
		[Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
		public int Id { get; set; }

        // Treść cytatu
		[Column]
		public string Content { get; set; }
		
        // Autor cytatu
		[Column]
		public string Author { get; set; }

        // Określa czy cytat jest ulubiony
		[Column]
		public bool IsFavorite { get; set; }
	}
}
