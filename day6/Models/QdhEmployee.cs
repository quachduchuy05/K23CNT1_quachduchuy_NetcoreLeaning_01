namespace QdhLab06.Models
{
    public class QdhEmployee
    {
        private static int _autoId = 1;
        public int QdhId { get; set; }
        public string QdhName { get; set; }
        public DateTime QdhBirthDay { get; set; }
        public string QdhEmail { get; set; }
        public string QdhPhone { get; set; }
        public string QdhSalary { get; set; }
        public int QdhStatus { get; set; }
        public QdhEmployee()
        {
            QdhId = _autoId++;
        }
    }
}