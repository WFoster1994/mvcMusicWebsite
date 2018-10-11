using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcMusicWebsite.Models
{
    public class Music
    {
        [ScaffoldColumn(false)]
        public int MusicID { get; set; }

        [StringLength(50), Required]
        public string BandName { get; set; }

        [Required, Range(1, 15), DataType(DataType.MultilineText)]
        public decimal Price { get; set; }

        [StringLength(50), Required]
        public string AlbumName { get; set; }

        [StringLength(50), Required, Display(Name = "Track Name")]
        public string TrackName { get; set; }

        [StringLength(50), Required]
        public string ArtistName { get; set; }

        [StringLength(300), Required]
        public string Description { get; set; }

        //Place to find the image
        [StringLength(128), DataType(DataType.Url)]
        public string ImageURL { get; set; }

        [StringLength(128)]
        public string Rating { get; set; }

        

    }
}