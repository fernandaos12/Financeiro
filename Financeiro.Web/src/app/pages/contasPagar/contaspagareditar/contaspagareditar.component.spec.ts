import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContaspagareditarComponent } from './contaspagareditar.component';

describe('ContaspagareditarComponent', () => {
  let component: ContaspagareditarComponent;
  let fixture: ComponentFixture<ContaspagareditarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ContaspagareditarComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContaspagareditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
