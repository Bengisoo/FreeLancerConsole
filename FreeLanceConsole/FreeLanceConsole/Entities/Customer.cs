using FreeLanceConsole.Abstract;
using FreeLanceConsole.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FreeLanceConsole.Entities
{
    internal class Customer : Person<Guid>, ICsvConvertible
    {
   
        public string PhoneNumber { get; set; }
        public string  GetValuesCSV()
        {
            return $"{Id} - {CreatedOn} - {FirstName} - {LastName} - {PhoneNumber}";
        }

        public void SetValuesCSV(string csvLine)
        {
            string[] data= csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName= data[2];
            LastName= data[3];  
            PhoneNumber= data[4];
        }
    }

}
