using System.Collections.Generic;

namespace WebScrapper.models
{
    public class Student
    {
        public Student(){
            this.Major = new List<string>();
            this.School = new List<string>();
            this.Degree = new List<string>();
            this.additionalInfo = new List<string>();
        }
        public string Name
        {
            get;
            set;
        }
        public List<string> Major
        {
            get;
            set;
        }
        public List<string> School
        {
            get;
            set;
        }
        public List<string> Degree
        {
            get;
            set;
        }
        public List<string> additionalInfo{
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("Student Name:{0}\r\nStudent Major:{1}\r\n Student School:{2}\r\n Student Degree:{3}\r\nStudent AddInfo:{4}\r\n", 
                                 this.Name, string.Join(",", this.Major), string.Join(",", this.School),
                                 string.Join(",", this.Degree), string.Join(",", this.additionalInfo));
        }

    }
}