﻿using System.ComponentModel.DataAnnotations;

namespace Cy.Api
{
    public class CapTechnicalSpecificationItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
