import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { User } from './Interfaces-classes/user';
import { AccountService } from './Service/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ApartmentsFront';
  users:any
  constructor(private http:HttpClient,private accountService:AccountService){}
  ngOnInit(){
    
    this.setCurrentUser();
    
  }
  setCurrentUser(){
    const user: User = JSON.parse(localStorage.getItem('user')!);
    this.accountService.setCurrentUser(user);
  }
  getUsers () {
    this.http.get('https://localhost:44329/api/users').subscribe( response => {
       this.users=response; 
    }, error=>{
       console. log(error);
                })
   }
}

