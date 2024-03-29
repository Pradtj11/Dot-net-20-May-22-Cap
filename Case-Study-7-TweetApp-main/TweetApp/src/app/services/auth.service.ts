import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { UserData } from '../models/UserData';
import { map } from 'rxjs/operators';

@Injectable()
export class AuthService {
  getusers() {
    throw new Error('Method not implemented.');
  }
  private _registerUrl = "https://tweetwebapi20220725114432.azurewebsites.net/api/Login/register";
  private _loginUrl = "https://tweetwebapi20220725114432.azurewebsites.net/api/Login/login";
  private _UserUrl = "https://tweetwebapi20220725114432.azurewebsites.net/api/Login/User";
 

  constructor(private http: HttpClient, private _router:Router) { }

  registerUser(user: any) {
    return this.http.post<any>(this._registerUrl, user);
  }
  loginUser(user: any) {
    return this.http.post<any>(this._loginUrl, user);
  }
  loggedIn()
  {
    return !!localStorage.getItem('token')
  }
  logoutUser(){
    localStorage.removeItem('token');
    this._router.navigate(['/login']);
  }
  getUser() {
    return this.http.get<any>(this._UserUrl)
    
  }
  getToken(){
    return localStorage.getItem('token');
  }

}