﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlightManagment.Domain.Models.Passenger;

namespace FlightManagment.Domain.Models.DTOs.PassengerDTOs
{
    public class PassengerBaseDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Maximum 100 characters.")]
        public string Firstname { get; set; }
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Maximum 100 characters.")]
        public string Lastname { get; set; }
        
        public Genders Gender { get; set; } = 0;
        public int? FlightId { get; set; }
        [ForeignKey(nameof(FlightId))]
        public Flight? Flight { get; set; }
        [StringLength(6)]
        public string SeatNumber { get; set; } = "N/A";
        public bool isCheckedIn { get; set; } = false;
        public DateTime? CHeckInTime { get; set; }
        //public IList<Luggage> Luggage { get; set; }
    }
}
