using System;
namespace Moment3API.Models
{
    public class Song
    {
        // Värden som ska hanteras 
        public int SongId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }
        public string Category { get; set; }

    }
}
