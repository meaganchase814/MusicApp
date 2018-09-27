using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Itunes.Models
{
    public class Albums
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public string CoverArt { get; set; }
        public string ReleaseDate { get; set; }
        public virtual List<Songs> SongName { get; set; }
    }

    public class Songs
    {
        public int ID { get; set; }
        public string SongName { get; set; }
        public virtual Albums Albums { get; set; }

    }

    public class Albums2Context : DbContext
    {
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Songs> SongName { get; set; }
    }


}
