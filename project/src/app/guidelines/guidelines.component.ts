import { Component,OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { UserService } from '../services/user.service';


@Component({
  selector: 'app-guidelines',
  templateUrl: './guidelines.component.html',
  styleUrls: ['./guidelines.component.scss']
})
export class GuidelinesComponent implements OnInit, OnDestroy {
   userName=""
   sub: Subscription
  constructor(public userSer: UserService) { }
 
  ngOnInit(): void {
    this.sub = this.userSer.currentUser.subscribe(success => this.userName = success?.firstName)
  }
  ngOnDestroy(): void {
    this.sub.unsubscribe();

  }

}
