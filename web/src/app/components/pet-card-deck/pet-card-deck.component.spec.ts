import {async, ComponentFixture, TestBed} from '@angular/core/testing';

import {PetCardDeckComponent} from './pet-card-deck.component';

describe('PetCardDeckComponent', () => {
  let component: PetCardDeckComponent;
  let fixture: ComponentFixture<PetCardDeckComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [PetCardDeckComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PetCardDeckComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
