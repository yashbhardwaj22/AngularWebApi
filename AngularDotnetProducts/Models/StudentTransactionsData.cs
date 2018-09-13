using System.Collections.Generic;

namespace AngularDotnetProducts.Models
{
    public class StudentTransactionsData
    {
        public static List<StudentTransactions> GetData()
        {
            return new List<StudentTransactions>
            {
                new StudentTransactions
                {
                    StudentFees=5000,
                    StudentID =123,
                    Date ="12-Jan-2018"
                },
                new StudentTransactions
                {
                    StudentFees=2000,
                    Date="16-Aug-2017",
                    StudentID =153,
                },
                new StudentTransactions
                {
                    StudentFees=3000,
                    Date="16-Sep17",
                    StudentID =163,                    
                },
                new StudentTransactions
                {
                    StudentFees=2500,
                    Date="17-Oct-2017",
                    StudentID =111,
                    
                },
                new StudentTransactions
                {
                    StudentFees=2000,
                    Date="10-Dec-2017",
                    StudentID =122,                   
                },
                new StudentTransactions
                {
                    StudentFees =3000,
                    Date="16-Feb-2017",
                    StudentID =145,
                },
                new StudentTransactions
                {
                    StudentFees=2000,
                    Date="20-May-2017",
                    StudentID =120,
                },
                new StudentTransactions
                {
                    StudentFees=4000,
                    Date="25-Jun-2017",
                    StudentID =158,                   
                },
                new StudentTransactions
                {
                    StudentFees=4500,
                    Date="31-Aug-2018",
                    StudentID =200,
                },
                new StudentTransactions
                {
                    StudentFees=5050,
                    Date="25-Mar-2017",
                    StudentID =127,
                }
            };
        }
    }
}
