import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuscarespostaComponent } from './buscaresposta.component';

describe('BuscarespostaComponent', () => {
  let component: BuscarespostaComponent;
  let fixture: ComponentFixture<BuscarespostaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BuscarespostaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BuscarespostaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
