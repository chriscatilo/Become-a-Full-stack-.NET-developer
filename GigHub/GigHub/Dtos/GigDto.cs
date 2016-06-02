using System;

namespace GigHub.Dtos
{
    public class GigDto
    {

        public int Id { get; set; }

        public bool IsCancelled { get; private set; }

        public UserDto Artist { get; set; }

        public DateTime DateTime { get; set; }
        
        public string Venue { get; set; }

        public GenreDto Genre { get; set; }
    }
}