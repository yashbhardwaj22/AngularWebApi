using System.Collections.Generic;

namespace AngularDotnetProducts.Models
{
    public class StudentInfoData
    {
        public static List<StudentInfo> GetData()
        {
            return new List<StudentInfo>
            {
                new StudentInfo
                {
                    StudentName="Sanjay",
                    StudentID =123,
                    StudentClass = 12,
                    StudentAge = 18
                },
                new StudentInfo
                {
                    StudentName="Ravi",
                    StudentID =153,
                    StudentClass = 11,
                    StudentAge = 17
                },
                new StudentInfo
                {
                    StudentName="Sandeep",
                    StudentID =163,
                    StudentClass = 10,
                    StudentAge = 15
                },
                new StudentInfo
                {
                    StudentName="Kamal",
                    StudentID =111,
                    StudentClass = 10,
                    StudentAge = 14
                },
                new StudentInfo
                {
                    StudentName="Amrit",
                    StudentID =122,
                    StudentClass = 12,
                    StudentAge = 19
                },
                new StudentInfo
                {
                    StudentName="Komal",
                    StudentID =145,
                    StudentClass = 9,
                    StudentAge = 13
                },
                new StudentInfo
                {
                    StudentName="Hasan",
                    StudentID =121,
                    StudentClass = 12,
                    StudentAge = 18
                },
                new StudentInfo
                {
                    StudentName="Neha",
                    StudentID =158,
                    StudentClass = 11,
                    StudentAge = 16
                },
                new StudentInfo
                {
                    StudentName="Rahul",
                    StudentID =129,
                    StudentClass = 12,
                    StudentAge = 18
                },
                new StudentInfo
                {
                    StudentName="Rohit",
                    StudentID =127,
                    StudentClass = 8,
                    StudentAge = 12
                }
            };
        }
    }
}
