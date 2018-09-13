import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { forEach } from '@angular/router/src/utils/collection';
@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  studentData: any;
  SearchByAttribute: string = "";
  SearchText:any;
  MinRange: number=null;
  MaxRange: number=null;
  SortByAttribute: string = "";
  apiStudentData:any;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any>(baseUrl + 'api/Products/GetStudentRecord').subscribe(result => {
      this.studentData = result;
      this.apiStudentData = result;
     // console.log(result)
    }, error => console.error(error));

  }
  SearchFilter(name:string,element){
      if(name =='')
        return true;
      if(name =='StudentName')
        if(element.studentName.toLowerCase() == this.SearchText.toLowerCase())
        return true;
      if(name=='StudentID')
            if(element.studentID == this.SearchText)
              return true;
      if(name=='StudentClass')
          if(element.studentClass == this.SearchText)
              return true;

      return false;
  }
  SearchByRange(element){
    if(this.MinRange != null && this.MaxRange !=null )
        if(element.studentFees >this.MaxRange || element.studentFees <this.MinRange)
             return false;
    if(this.MinRange ==null && this.MaxRange !=null )
      if(element.studentFees >this.MaxRange )
          return false;
    if(this.MinRange !=null && this.MaxRange ==null )
          if(element.studentFees <this.MinRange)
              return false;
    return true;
  }
  
  Search() {
  var  tempData =[];
    this.apiStudentData.forEach(element => {
      if(this.SearchFilter(this.SearchByAttribute,element) && this.SearchByRange(element))
          tempData.push(element)
      
    }); 
    if(this.SortByAttribute =='StudentID')
        tempData.sort(function(obj1:any,obj2:any){
            return obj1.studentID - obj2.studentID
          });
    if(this.SortByAttribute =='StudentName')
        tempData.sort(function(obj1:any,obj2:any){
              var name1 =obj1.studentName.toLowerCase()
              var name2 =obj2.studentName.toLowerCase()
        if(name1> name2)
          return 1;
        if(name1< name2)
          return -1;
        return 0;
        });
    if(this.SortByAttribute =='StudentClass')
        tempData.sort(function(obj1:any,obj2:any){
            return obj1.studentClass - obj2.studentClass
        });
  

    this.studentData = tempData;
  }
}


