import { Component, OnInit } from '@angular/core';
import { IShow } from '../../interfaces/IShow';
import { ApiService } from '../../services/api.service';
import { CardsComponent } from '../ui/cards/cards.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CardsComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent implements OnInit {
  shows: any | IShow[];
  constructor(private apiService: ApiService) { }

  ngOnInit(): void {
    this.apiService.get<IShow>('shows').subscribe(res => {
      this.shows = res;
    })
  }
}
