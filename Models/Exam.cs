namespace _23._04._2024.Models
{
    internal class Exam
    {
        public string _subject { get; set; }
        public int _examDuration { get; set; }
        public DateTime _startDate { get; set; }
        public DateTime _endDate { get; set; }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public int ExamDuration
        {
            get { return _examDuration; }
            set { _examDuration = value; }
        }
        public Exam(string subject,int exaDuration,DateTime starDate,DateTime endDate)
        {
            Subject = subject;
            ExamDuration = exaDuration;
            StarDate=starDate;
            EndDate=endDate;
        }


    }
}
