import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BocasayComponent } from './bocasay.component';

describe('BocasayComponent', () => {
  let component: BocasayComponent;
  let fixture: ComponentFixture<BocasayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BocasayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BocasayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
