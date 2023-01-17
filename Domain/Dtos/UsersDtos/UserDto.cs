using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.UsersDtos
{
    public class UserDto
    {
        [Required]
        [MinLength(11)]
        [MaxLength(14)]
        public string CodeId { get; set; }
        [Required]
        [MinLength(12)]
        [MaxLength(256)]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [MinLength(11)]
        [MaxLength(11)]
        public string Phone { get; set; }
    }
    public class UserDtoGet : UserDto
    {
        public Guid Id { get; set; }
    }

    public class UserDtoPatch
    {
        [MinLength(12)]
        [MaxLength(256)]
        public string Email { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MinLength(11)]
        [MaxLength(11)]
        public string Phone { get; set; }
        [MinLength(11)]
        [MaxLength(14)]
        public string  CodeId { get; set; }

    }
}
