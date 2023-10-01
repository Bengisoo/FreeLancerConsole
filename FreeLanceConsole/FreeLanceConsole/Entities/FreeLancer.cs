﻿using FreeLanceConsole.Abstract;
using FreeLanceConsole.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace FreeLanceConsole.Entities
{
    internal class FreeLancer : Person<Guid>, ICsvConvertible
    {
        public string WorkExperience { get; set; }

        public List<Review> Reviews { get; set; }

        public string GetValuesCSV()
        {
            return $"{Id} - {CreatedOn} - {FirstName} - {LastName} - {WorkExperience}";
        }

        public void SetValuesCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTime.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            WorkExperience = data[4];
        }

      
    }
}
