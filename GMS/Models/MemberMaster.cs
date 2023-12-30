namespace GMS.Models
{
    public class MemberMaster
    {
        public int ID { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; }

        public string? TelephoneNo { get; set; }

        public int? FingerPrintID { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public string Modifiedby { get; set; }

        public DateTime ModifiedDatetime { get; set; }

    }
}
