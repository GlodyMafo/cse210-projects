using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "The Church of Jesus-Christ of later days saints";
        job1._jobTitle = "Missionnary";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Bloom";
        job2._jobTitle = "Data Entry Specialist";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Job job3 = new Job();
        job3._company = "CMB";
        job3._jobTitle = "Web Developper";
        job3._startYear = 2024;
        job3._endYear = 2025;

        // job1.Display();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._name = "Glody Mafo";

        myResume.Display();

    }
}