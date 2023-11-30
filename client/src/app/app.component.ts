import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core'; //add OnInit

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Dating app';
  users: any; //cheating because it can be anything
  constructor (private http: HttpClient){}


  ngOnInit(): void  {
    //here goes the request
    this.http.get('https://localhost:5001/api/users').subscribe({ //we need to subscribe to the object arriving
    
    next: response  => this.users = response, //lamba expression
    error: error => console.log(error),
    complete: () => console.log('Request has completed')
    })

  }
  
}
