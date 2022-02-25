import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Apartment, UUser } from '../Interfaces-classes/member';

@Injectable({
  providedIn: 'root'
})
export class MembersService {
readonly baseUrlUs='https://localhost:44329/api/Users'
readonly baseUrlAp='https://localhost:44329/api/apartments'
  constructor(private http:HttpClient) { }
  formData:UUser = new UUser();
  list : UUser[];
  formData1: Apartment = new Apartment();
  list1: Apartment[]


getUsersWithAll()
{
  return this.http.get<UUser>(this.baseUrlUs);
}



getApartments()
{
  return this.http.get<Apartment>(this.baseUrlAp);
}
}
