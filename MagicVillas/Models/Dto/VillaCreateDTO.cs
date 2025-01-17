﻿using System.ComponentModel.DataAnnotations;

namespace MagicVillas.Models.Dto
{
    public class VillaCreateDTO
    {
       
             [Required]
             [MaxLength(30)]
            public string Name { get; set; }
            public string Description { get; set; }
            public double  Rate { get; set; }
            public int Sqft { get; set; }
            public  string ImageUrl     { get; set; }
            public int Price { get; set; }
        }
    }

