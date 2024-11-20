import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContasPagarCadastroComponent } from './contas-pagar-cadastro.component';

describe('ContasPagarCadastroComponent', () => {
  let component: ContasPagarCadastroComponent;
  let fixture: ComponentFixture<ContasPagarCadastroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ContasPagarCadastroComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContasPagarCadastroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
