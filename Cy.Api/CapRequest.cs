using System;
using System.ComponentModel.DataAnnotations;

namespace Cy.Api
{
    public class CapRequest
    {
        public string Id { get; set; }

        [Required]
        public string DerivativeType { get; set; }

        [Required]
        public string ModelYear { get; set; }

        [Required]
        public int CapId { get; set; }

        [Required]
        public int[] SelectedEquipmentIds { get; set; }
    }
}
