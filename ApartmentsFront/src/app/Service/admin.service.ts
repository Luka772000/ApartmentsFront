import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { User } from '../Interfaces-classes/user';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  baseUrl=environment.apiUrl;
  constructor(private http: HttpClient) { }
  getUsersWIthRoles(){
    return this.http.get<Partial<User>[]>(this.baseUrl + 'admin/users-with-roles')
  }
  updateUserRoles(username, roles) {
    return this.http.post(this.baseUrl + 'admin/edit-user-roles/' + username + '?roles=' + roles, {});
  }
}
