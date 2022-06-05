﻿using System.ComponentModel.DataAnnotations;
namespace MVC_uppgift.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public List<PeopleLanguage> PeopleLanguagues { get; set; }
    }
}
