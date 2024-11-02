import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faSackDollar } from '@fortawesome/free-solid-svg-icons';
import { Router } from 'express';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [FontAwesomeModule, RouterModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  faSackDollar = faSackDollar;
}
