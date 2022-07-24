import { Component, OnInit } from '@angular/core';
import { UserData } from '../models/UserData';
import { AuthService } from '../services/auth.service';
import { Subscription } from 'rxjs';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-home',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {
  searchKey:string = "";
  public searchTerm: string='';
    
  clickEventSubscription:Subscription | undefined;
  private _tweetservice: any;
  

  constructor(private auth: AuthService, private accountService:AccountService) { 
    this.clickEventSubscription= this.accountService.getClickEvent().subscribe(()=>{
        this.incrementCount();
    })
  }

  users: Array<UserData> = new Array<UserData>();
  ngOnInit(): void {

    this.auth.getUser().subscribe((res: UserData[]) => this.users = res, (err: any) => console.log(err))
  }
  count:number=0;
  incrementCount(){
    this.count++;
  }
  quantity:number=0;
  i=1;
  plus(){
    if(this.i !=50){
      this.i++;
      this.quantity=this.i;
    }
  }
    minus(){
      if(this.i !=1){
        this.i--;
        this.quantity=this.i;
      }
    }
    search(event:any){
      this.searchTerm=(event.target as HTMLInputElement).value;
      console.log(this.searchTerm);
      this._tweetservice.search.next(this.searchTerm);
    }
  }
  


