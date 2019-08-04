using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;

namespace LostWoods.Models
{

    public class Trail
    {
        public int TrailId { get; set; }

        [Required(ErrorMessage = "Please provide a trail name.")]
        [Display(Name = "Trail Name: ")]
        public string TrailName { get; set; }

        [Required(ErrorMessage = "Please provide the length of the trail.")]
        [Display(Name = "Trail Length: ")]
        public float Length { get; set; }

        [Display(Name="Elevation Change: ")]
        public float ElevationGain { get; set; }

        [Display(Name = "Max Elevation: ")]
        public float MaxElevation { get; set; }

        [Range(-180, 180, ErrorMessage = "Please provide valid longitude, [-180, 180]")]
        [Display(Name = "Longitude: ")]
        [Required(ErrorMessage = "Please provide valid longitude, [-180, 180]")]
        public float Longitude { get; set; }

        [Required(ErrorMessage = "Please provide valid latitude, [-90, 90]")]
        [Range(-90, 90, ErrorMessage = "Please provide valid latitude, [-90, 90]")]
        [Display(Name = "Latitude: ")]
        public float Latitude { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}