import { Component, Input} from '@angular/core';
import { IShow } from '../../../interfaces/IShow';
import { NgOptimizedImage } from '@angular/common';

@Component({
  selector: 'app-cards',
  standalone: true,
  imports: [NgOptimizedImage],
  templateUrl: './cards.component.html',
  styleUrl: './cards.component.scss'
})
export class CardsComponent {

  @Input() shows: any | IShow[] = undefined;

  constructor() {
  }
}
