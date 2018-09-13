using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularDotnetProducts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularDotnetProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("[action]")]
        public IEnumerable<StudentJoinView> GetStudentRecord()
        {
            List<StudentInfo> studentData = StudentInfoData.GetData();
            List<StudentTransactions> studentTransactions = StudentTransactionsData.GetData();
            List<StudentJoinView> studentJoinViews = (from std_info in studentData
                                                      join std_trans in studentTransactions
                         on std_info.StudentID equals std_trans.StudentID
                                                      select new StudentJoinView
                                                      {
                                                          StudentID = std_info.StudentID,
                                                          StudentName = std_info.StudentName,
                                                          StudentClass = std_info.StudentClass,
                                                          StudentAge = std_info.StudentAge,
                                                          StudentFees = std_trans.StudentFees,
                                                          Date = std_trans.Date
                                                      }
                                                      ).ToList();
            return studentJoinViews;

        }

    }
}