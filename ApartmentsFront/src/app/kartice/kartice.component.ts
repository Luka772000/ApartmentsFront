import { Component, Input, Output,EventEmitter } from '@angular/core';
import { map } from 'rxjs/operators';
import { Breakpoints, BreakpointObserver } from '@angular/cdk/layout';
import { NavigacijaComponent } from '../navigacija/navigacija.component';
import { AccountService } from '../Service/account.service';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-kartice',
  templateUrl: './kartice.component.html',
  styleUrls: ['./kartice.component.css']
})
export class KarticeComponent {
  /** Based on the screen size, switch from standard to one column per row */
  registerMode=false;
  llogin=false;
  constructor(public accountService:AccountService,public router:Router, private toastr:ToastrService) {}

  model: any={}
 

ngOnInIt():void {
  if(localStorage.getItem('user')!=null)
  {
       this.llogin=true;
  }
}

  login(){
    this.accountService.login(this.model).subscribe(response=>{
      this.router.navigateByUrl('/')
      console.log("uspjelo je")
      this.toastr.success("uspjesna prijava")
      
    },error =>{
      console.log(error);
      this.toastr.error("Pogresno ime ili lozinka")
    })
  }
  logout(){
    this.accountService.logout();
    
    
  }
  registerToggle(){
    this.registerMode=!this.registerMode;
    this.router.navigateByUrl('/')

  }
  

cancelRegisterMode(event: boolean){
  this.registerMode = event;
}
}
