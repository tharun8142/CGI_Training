import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddJewelleryComponent } from './add-jewellery.component';

describe('AddJewelleryComponent', () => {
  let component: AddJewelleryComponent;
  let fixture: ComponentFixture<AddJewelleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddJewelleryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddJewelleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
