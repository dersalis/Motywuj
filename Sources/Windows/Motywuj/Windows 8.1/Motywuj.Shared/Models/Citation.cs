using System;
using System.Collections.Generic;
using System.Text;

namespace Motywuj.Models
{
    public class Citation
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int FavoriteNumber { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsPin { get; set; }
    }
}
