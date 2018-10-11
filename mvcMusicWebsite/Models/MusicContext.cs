using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcMusicWebsite.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("DefaultConnection")
        {

        }

        public DbSet<Music> Music { get; set; }
    }
}