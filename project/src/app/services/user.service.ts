import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import User from 'src/app/Models/User';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(public http:HttpClient) { }
  BaseRouterUrl=`${environment.baseUrl}/User`
  CurrentUser:User=new User("","","",new Date(null),0,"",[])
  currentUser=new BehaviorSubject<(User)>(null);


  addUser(){
    return this.http.post(this.BaseRouterUrl,this.CurrentUser).subscribe((result)=>console.log(result))
  }
}
