import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserData } from '../models/UserData';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerUserData: UserData = new UserData();
  modelText:string="";
  modelHeader:string="";
  showSpinner:boolean=false;
  constructor(private _auth: AuthService, private _router: Router) { }

  ngOnInit(): void {
  }
  DisplayModalPopup(modelHeader:string,modelText:string){
    this.modelHeader=modelHeader;
    this.modelText=modelText;
    document.getElementById("btnLaunchModel")?.click();
  }
  ShowSpinner(){
    this.showSpinner=true;
  }
  HideSpinner(){
    this.showSpinner=false;
  }

  registerUser() {
    if(this.registerUserData.email==''|| this.registerUserData.password=='' || this.registerUserData.confirmPassword=='' || this.registerUserData.firstName=='' || this.registerUserData.lastName=='' || this.registerUserData.loginId==''){
      this.DisplayModalPopup("Error","Please enter all field");
      return;
    }
    this.ShowSpinner();
    var userDataObject={
      firstName:this.registerUserData.firstName,
      lastName:this.registerUserData.lastName,
      email:this.registerUserData.email,
      loginId:this.registerUserData.loginId,
      password:this.registerUserData.password,
      confirmPassword:this.registerUserData.confirmPassword,
      contactNumber:Number(this.registerUserData.contactNumber)
    }
  
    this._auth.registerUser(userDataObject).subscribe(res => {
      this.HideSpinner();localStorage.setItem('token', res.token);
      this._router.navigate(['home'])
    },
      err => console.log(err));
  }

}