import { Component, OnInit } from '@angular/core';
import { UserData } from '../models/UserData';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-home',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {

  constructor(private auth: AuthService) { }

  users: Array<UserData> = new Array<UserData>();
  ngOnInit(): void {

    this.auth.getUser().subscribe((res: UserData[]) => this.users = res, (err: any) => console.log(err))
  }

}