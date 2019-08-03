using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;

namespace LostWoods.Models
{

    public class Trail
    {
        public int TrailId { get; set; }

        [Required]
        [Display(Name = "Trail Name: ")]
        public string TrailName { get; set; }

        [Required]
        [Display(Name = "Trail Length: ")]
        public float Length { get; set; }

        [Display(Name="Elevation Change: ")]
        public float ElevationGain { get; set; }

        [Display(Name = "Max Elevation: ")]
        public float MaxElevation { get; set; }

        [Required]
        [Range(-180, 180)]
        [Display(Name = "Longitude: ")]
        public float Longitude { get; set; }

        [Required]
        [Range(-90, 90)]
        [Display(Name = "Latitude: ")]
        public float Latitude { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}