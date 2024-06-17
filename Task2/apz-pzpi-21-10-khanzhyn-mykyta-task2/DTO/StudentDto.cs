﻿using System.ComponentModel.DataAnnotations;

namespace StudCheck_back.DTO
{
    public class StudentDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string? Number { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public string NfcId { get; set; }
        public int? ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
