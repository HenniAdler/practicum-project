import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import Child from 'src/app/Models/Child';

@Injectable({
  providedIn: 'root'
})
export class ChildService {

  constructor(public http: HttpClient) { }
  BaseRouterUrl = `${environment.baseUrl}/Child`
  // MyChild:Child=new Child(null,null,null,null,null,null)

  addChild(child: Child) {
    return this.http.post(this.BaseRouterUrl, child).subscribe((result) => console.log(result))
  }
  getAllChildren() {
    return this.http.get<Child[]>(this.BaseRouterUrl)
  }

  
  // getChild(id: number) {
  //   return this.http.get<Child>(`${this.BaseRouterUrl}/${id}`)
  // }
  // deleteChild(id: number) {
  //   this.http.delete(`${this.BaseRouterUrl}/${id}`)
  // }
  // updateDetails(child: Child) {
  //   this.http.put<object>(`${this.BaseRouterUrl}/${child.Id}`,child)
  // }
}

