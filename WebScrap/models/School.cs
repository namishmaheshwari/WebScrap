﻿using System;
using System.Collections.Generic;

namespace WebScrapper.models
{
    internal class School
    {
        public string Name
        {
            get;
            set;
        }

        public string Dean
        {
            get;
            set;
        }

        public List<Stream> Streams { 
            get; 
            set; 
        }

        public override string ToString(){
            return string.Format("School Name: {0}\r\nSchool Dean:{1}\r\nSchool Streams:\r\n{2}", this.Name, this.Dean, string.Join("\n", this.Streams));
        }
    }
}
