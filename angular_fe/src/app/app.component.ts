import { Component, OnInit } from '@angular/core';
import { ApiService } from './services/api.service';
import { IShow } from './interfaces/IShow';
import { NavbarComponent } from './core/navbar/navbar.component';
import { FooterComponent } from './core/footer/footer.component';
import { RouterModule } from '@angular/router';
import { NgOptimizedImage } from '@angular/common';
import { type MetaDefinition } from '@angular/platform-browser';
import { MetadataService } from './services/metadata.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: true,
  imports: [NavbarComponent, FooterComponent, RouterModule, NgOptimizedImage],
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  title = 'angular_fe';
  shows: any | IShow[];
  tags: MetaDefinition[] = [];
  constructor(private apiService: ApiService, private metadataService: MetadataService) {
    this.metadataService.generateMetadata([
      {name: 'title', content: 'HomePage'},
      {name: 'description', content: 'This is a homepage!'},
    ]);
  }

  ngOnInit() {
    this.apiService.get<IShow>('shows').subscribe(res => {
      this.shows = res;
    })
  }
  
}