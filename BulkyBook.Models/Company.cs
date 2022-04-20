﻿using System;
namespace BulkyBook.Models
{
	public class Company
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? StreetAdress { get; set; }
    }
}

