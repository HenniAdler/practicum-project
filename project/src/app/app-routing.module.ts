import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuidelinesComponent } from './guidelines/guidelines.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
{path:"form",component:UserComponent},
{path:"guidelines",component:GuidelinesComponent},
{path:"",redirectTo:"guidelines",pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
