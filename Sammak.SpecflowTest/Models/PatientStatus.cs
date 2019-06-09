using System;

namespace Sammak.SpecflowTest.Models
{
    public class PatientStatus
    {
        public string PracticeId { get; set; }
        public string Description { get; set; }
        public Guid? PersonId { get; set; }
        public Guid? PatientStatusId { get; set; }
        public Guid? PatientStatusReasonChangeId { get; set; }
        public Guid? EncounterId { get; set; }
    }
}
