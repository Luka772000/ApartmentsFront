import { Component, OnInit } from '@angular/core';
import { Apartment } from '../Interfaces-classes/member';
import { MembersService } from '../Service/members.service';

@Component({
  selector: 'app-tablica',
  templateUrl: './tablica.component.html',
  styleUrls: ['./tablica.component.css']
})
export class TablicaComponent implements OnInit {
  apartments: Apartment[];
  constructor(public service: MembersService) { }

  ngOnInit(): void {
    this.service.getApartments()
    this.service.getUsersWithAll()
  }
 
}
