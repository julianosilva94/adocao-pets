import {Component, Input, OnInit} from '@angular/core';
import {Pet} from '../../models/pet';

@Component({
  selector: 'app-pet-card-deck',
  templateUrl: './pet-card-deck.component.html',
  styleUrls: ['./pet-card-deck.component.scss']
})
export class PetCardDeckComponent implements OnInit {

  @Input() pets: Pet[];

  constructor() {
  }

  ngOnInit(): void {
  }

}
