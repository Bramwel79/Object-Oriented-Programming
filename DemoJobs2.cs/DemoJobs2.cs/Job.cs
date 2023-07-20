using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoJobs2.cs
{
    class Job
    {
        String jobDescription;
        double timeToCompleteJob;
        double jobPerHourRate;
        double jobTotalFee;



        public String JobDescription
        {
            get
            {
                return jobDescription;
            }
            set
            {
                jobDescription = value;
            }
        }

        public double TimeToCompleteJob
        {
            get
            {
                return timeToCompleteJob;
            }
            set
            {
                timeToCompleteJob = value;
                CalculateTotalJobFee();
            }
        }

        public double JobPerHourRate
        {
            get
            {
                return jobPerHourRate;
            }
            set
            {
                jobPerHourRate = value;
                CalculateTotalJobFee();
            }
        }
        public double JobTotalFee
        {
            get
            {
                return jobTotalFee;
            }

        }
        private void CalculateTotalJobFee()
        {
            jobTotalFee = TimeToCompleteJob * JobPerHourRate;
        }
        public static Job operator +(Job one, Job two)
        {
            Job temp = new Job();
            temp.JobDescription = one.JobDescription + " and " + two.JobDescription;
            temp.TimeToCompleteJob = one.TimeToCompleteJob + two.TimeToCompleteJob;
            temp.JobPerHourRate =((one.timeToCompleteJob *one.JobPerHourRate) +(two.timeToCompleteJob * two.JobPerHourRate)) / 2;
            return temp;
        }

        static void Main(string[] args)
        {
            Job sweeping = new Job();
            sweeping.JobDescription = "Sweeping floor";
            sweeping.TimeToCompleteJob = 25.45;
            sweeping.JobPerHourRate = 10.05;

            Job vacuuming = new Job();
            vacuuming.JobDescription = "Vacuuming";
            vacuuming.TimeToCompleteJob = 22.25;
            vacuuming.JobPerHourRate = 12.05;

            Job sweepingVacuuming = new Job();
            sweepingVacuuming = sweeping + vacuuming;

            Console.WriteLine("The new Job is {0}", sweepingVacuuming.JobDescription);
            Console.WriteLine("The time taken to complete this job is {0} hours", sweepingVacuuming.TimeToCompleteJob);
            Console.WriteLine("The hourly rate charged for this job is {0}", sweepingVacuuming.JobPerHourRate.ToString("c"));
            Console.WriteLine("The Job total fee is {0}", sweepingVacuuming.JobTotalFee.ToString("c"));
            Console.ReadLine();
        }
    }
}

