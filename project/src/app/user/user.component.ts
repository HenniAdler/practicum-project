import { Component, OnDestroy, OnInit } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatRadioModule } from '@angular/material/radio';
import { MatSelectModule } from '@angular/material/select';
import { MatDialogModule, MatDialog } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import Child from 'src/app/Models/Child';
import { UserService } from '../services/user.service';
import User from 'src/app/Models/User';
import { ChildService } from '../services/child.service';
import { FormsModule } from '@angular/forms';



@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit, OnDestroy{
HMO:string[]=['מאוחדת','כללית','מכבי','לאומית']
children:Child[]=[]
AllChildren:Child[]=[]
currentId:number=0

  constructor(public userSer:UserService,public childSer:ChildService) { }
  
  ngOnInit(): void {

  }
  ngOnDestroy(): void {

  }
  viewChild(){
    this.children.push(new Child(null,null,null,null,null));
  }
   addChild(e) {
    console.log(e.firstName)
    let result = this.AllChildren.find(i => i.IdNumber == e.IdNumber);
    // this.currentId=this.currentId+1
       if (result) {
      if (this.userSer.CurrentUser.gender ==2) {
        if (result.motherId)
          alert("ERROR,enter again your child's id number")
        else if (result.patherId){}
          //this.childSer.updateDetails(new Child(currentId, e.Name, e.IdNumber, e.DateOfBirth, result.patherId,e.id))
        else this.childSer.addChild(new Child(e.Name, e.IdNumber, e.DateOfBirth, null,this.userSer.CurrentUser.IdNumber))
      }
      else {
        if (result.patherId)
          alert("ERROR,enter again your child's id number")
        else if (result.motherId){}
          //this.childSer.updateDetails(new Child(currentId,this.childSer.MyChild.Name, this.childSer.MyChild.IdNumber, this.childSer.MyChild.DateOfBirth, this.userSer.MyUser.id, result.motherId))
        else this.childSer.addChild(new Child(e.Name, e.IdNumber, e.DateOfBirth, this.userSer.CurrentUser.IdNumber, null))
      }
    }
    else if (this.userSer.CurrentUser.gender==2)
      this.childSer.addChild(new Child( e.Name, e.IdNumber, e.DateOfBirth, null, this.userSer.CurrentUser.IdNumber))
    else this.childSer.addChild(new Child( e.Name, e.IdNumber,e.DateOfBirth, this.userSer.CurrentUser.IdNumber, null))
    console.log(e)
}

  addUser(){
    this.userSer.CurrentUser.children=this.children
    this.userSer.addUser()
  this.children=[]
  }

  saveHMO(value){
    this.userSer.CurrentUser.Hmo=value
    console.log(this.userSer.CurrentUser.Hmo)
  }
}





