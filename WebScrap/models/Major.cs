﻿using System.Collections.Generic;

namespace WebScrapper.models
{
    internal class Major
    {
        public string Name
        {
            get;
            set;
        }

        public List<Student> Students{
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("Major Name: {0}\r\nMajor Students:\r\n{1}", this.Name, string.Join("\n", this.Students));

        }
    }
}