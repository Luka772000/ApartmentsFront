import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { AccountService } from '../Service/account.service';
import { User } from '../Interfaces-classes/user';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-navigacija',
  templateUrl: './navigacija.component.html',
  styleUrls: ['./navigacija.component.css']
})
export class NavigacijaComponent {
  model: any={}
 
  

 

  constructor(public accountService:AccountService,public router:Router, private toastr:ToastrService) {}
ngOnInIt():void {
  
}
  login(){
    this.accountService.login(this.model).subscribe(response=>{
      console.log(response);
      console.log("uspjelo je")
      
    },error =>{
      console.log(error);
    })
  }
  logout(){
    this.accountService.logout();
    this.router.navigateByUrl('/')
    this.toastr.success("Uspjesna odjava")
  }
  
}
