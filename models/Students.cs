using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTBD_MVC_Project_1.models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Students> GetStudents()
        {
            List<Students> students = new List<Students>()
            {
                    new Students
                {
                    Id = 1,
                    Name = "Jobayer",
                    Age = 15
                },
                new Students
                {
                    Id = 2,
                    Name = "Rahim",
                    Age = 12
                },
                new Students
                {
                    Id = 3,
                    Name = "Karim",
                    Age = 11
                },
                new Students
                {
                    Id = 4,
                    Name = "July",
                    Age = 13
                }
            };

            return students;
        }
    }
}
