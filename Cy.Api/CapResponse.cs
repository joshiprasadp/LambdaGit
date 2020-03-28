using System.ComponentModel.DataAnnotations;

namespace Cy.Api
{
    public class CapResponse
    {
        [Required]
        public string AuditId { get; set; }

        public CapError[] Errors { get; set; }

        public CapData[] WltpData { get; set; }
    }
}
