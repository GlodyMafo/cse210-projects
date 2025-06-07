class WrittingAssignment : Assignment
{
    private string _title = "";

    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        this._title = title;
    }

    public string GetWrittingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}