import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Customer } from './customer.model';

@Component({
  templateUrl: './customer.component.html'
})
export class CustomerComponent {

  constructor(public httpc:HttpClient){
    
  }
  title = 'first-sample-project';
  myname = 'vikash Verma'
  CustomerModel: Customer = new Customer();
  CustmerModels: Array<Customer> = new Array<Customer>();
  AddCustomer() {
    //this.CustmerModels.push(this.CustomerModel);
    this.httpc.post ("https://localhost:4200/api/Customer", this.CustomerModel).subscribe(res=>{this.PostSuccess}, res=> {this.PostError});
    this.CustomerModel = new Customer();
  }
  PostSuccess(res:any){
    console.log(res);
  }
  PostError(res:any)
  {
    console.log(res);
  }
  EditCustomer(input: Customer) {
    this.CustomerModel = input;
  }
  DeleteCustomer(input: Customer) {
    var index=this.CustmerModels.indexOf(input);
    this.CustmerModels.splice(index,1);
  }

}