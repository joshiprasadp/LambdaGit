using System.ComponentModel.DataAnnotations;

namespace Cy.Api
{
    public class CapData
    {
        public string Id { get; set; }

        [Required]
        public string DerivativeType { get; set; }

        [Required]
        public int CapId { get; set; }

        [Required]
        public string ModelYear { get; set; }

        [Required]
        public int[] SelectedEquipmentIds { get; set; }

        [Required]
        public string ExaminationDate { get; set; }

        [Required]
        public string ValidUntil { get; set; }

        public CapTechnicalSpecificationItem[] TechnicalSpecificationItems { get; set; }

        public CapError[] Errors { get; set; }
    }
}
