﻿using EHospital.Domain.Entities.Common;

namespace EHospital.Domain.Entities;

public class Patient:BaseEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime DOB { get; set; }
    public Guid GenderId { get; set; }
    public Gender Gender { get; set; }
    public Guid BloodGroupId { get; set; }
    public BloodGroup BloodGroup { get; set; }
    public string? PhoneNumber { get; set; }
    public string? SeriaNumber { get; set; }
    public string? RegistrationAddress { get; set; }
    public string? CurrentAddress { get; set; }
    public Guid InsuranceId { get; set; }
    public Insurance Insurance { get; set; }
    public string? Email { get; set; }

    public ICollection<Registration> Registrations { get; set; }
}
