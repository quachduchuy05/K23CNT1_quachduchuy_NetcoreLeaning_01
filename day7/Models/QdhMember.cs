namespace day7.Models
{
    public interface QdhMember
    {
        public int QdhId { get; set; }

        public string QdhName { get; set; }
        public string QdhUserName { get; set; }

        public string QdhPassword { get; set; }

        public string QdhEmail { get; set; }

        public bool QdhStatus { get; set; }
    }
}