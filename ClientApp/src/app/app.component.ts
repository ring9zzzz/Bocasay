import { Component } from '@angular/core';
import { baseComponent } from './base/base';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent extends baseComponent {
  title = 'Bocasay';
}
