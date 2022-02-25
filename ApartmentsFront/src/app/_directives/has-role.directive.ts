import { Directive, Input, OnInit, TemplateRef, ViewContainerRef } from '@angular/core';
import { take } from 'rxjs';
import { AccountService } from '../Service/account.service';
import { User } from '../Interfaces-classes/user';

@Directive({
  selector: '[appHasRole]' // *appHasRole= ["Admin"]
})
export class HasRoleDirective implements OnInit {
  @Input() appHasRole: string[];
  user: User;
  //za prikazivanje ili sakkrivanje odredenih komponenti(AdminPanel npr ng g d --skip-tests)
  constructor(private viewContainerRef: ViewContainerRef,
     private templateRef: TemplateRef<any>,
     private accountService: AccountService) {
       this.accountService.currentUser$.pipe(take(1)).subscribe(user => {
         this.user = user;
       })
      }
  ngOnInit(): void {
    // ocistit view ako nema uloga
  if (!this.user?.roles || this.user == null)
    {
      this.viewContainerRef.clear();
      return;
    }

    if  (this.user?.roles.some(r => this.appHasRole.includes(r)))
    {
      this.viewContainerRef.createEmbeddedView(this.templateRef);
    } 
    else
    {
      this.viewContainerRef.clear();
    }
  //Ukratko ako nisu u ulogi u kojoj trebaju(u ovom slucaju Admin) nece se prikazat to sta mi necemo da se prikaze ili hoce ako jest u toj ulogi
   }

}
