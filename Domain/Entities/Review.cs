using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int SalaryRating { get; set; }
        public int TrainingRating { get; set; }
        public int CareRating { get; set; }
        public int CultureRating { get; set; }
        public int OfficeRating { get; set; }
        public string SummaryContent { get; set; }
        public string ReviewContent { get; set; }
        public string ReasonContent { get; set; }
        public string ExperienceContent { get; set; }
        public string SuggestionContent { get; set; }
        public bool Recommened { get; set; }
        public ReviewStatus ReviewStatus { get; set; }
        public string? ReasonToReject { get; set; }
        public UserAccount UserAccount { get; set; }
        public int? UserId { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }

    }

    public enum ReviewStatus
    {
        Pending,
        Approve,
        Reject
    }
}
