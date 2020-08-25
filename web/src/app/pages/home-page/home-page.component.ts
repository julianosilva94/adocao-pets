import {Component, OnInit} from '@angular/core';
import {PetService} from '../../services/pet.service';
import {Pet} from '../../models/pet';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {

  pets: Pet[];

  constructor(private petService: PetService) {
  }

  ngOnInit(): void {
    this.petService.getAll().subscribe(data => this.pets = data);
  }

}
