import { Component } from '@angular/core';

@Component({
  selector: 'app-hor-nav-menu',
  templateUrl: './hor-nav-menu.component.html',
  styleUrls: ['./hor-nav-menu.component.css']
})
export class HorNavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
