import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IPagination } from './models/pagination';
import { IProduct } from './models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'Demart';
  products!: IProduct[];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get<IPagination>('https://localhost:5001/api/product?pageSize=50')
      .subscribe((response: IPagination) => {
        this.products = response.data;
      }, error => {
        console.log(error);
      });
  }
}
