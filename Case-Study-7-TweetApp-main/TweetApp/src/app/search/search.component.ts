import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  // @Input() public hotelSearch;
  public tweet = '';

  @Output() searchQueryEvent = new EventEmitter();

  constructor(private router:Router) { }

  searchQuery = (query:any) => {
    this.searchQueryEvent.emit(query);
  }

  clearSearch = () => {
    this.tweet = '';
    this.searchQueryEvent.emit(this.tweet);
  }
  search(term:string):void{
    if(term)
    this.router.navigateByUrl('/search/'+ term);
  }
  ngOnInit(): void {
  }

}