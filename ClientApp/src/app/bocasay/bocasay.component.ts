import { Component, OnInit } from '@angular/core';
import { baseComponent } from '../base/base';
import { BackendApiService } from '../services/backend-api.service';

@Component({
  selector: 'app-bocasay',
  templateUrl: './bocasay.component.html',
  styleUrls: ['./bocasay.component.scss']
})
export class BocasayComponent extends baseComponent implements OnInit {

  firstName: string;
  lastName: string ;
  firstNameValid: boolean;
  lastNameValid: boolean;
  errMessage: string = "This field is required";
  subbmited: boolean;

  ngOnInit(): void {
  }

  constructor(private apiService: BackendApiService)
  {
    super();
    this.firstName = "";
    this.lastName = "";
    this.firstNameValid = true;
    this.lastNameValid = true;
  }

  validField() {

    if (this.firstName.length == 0) {
      this.firstNameValid = false;
    } else
    {
      this.firstNameValid = true;
    }

    if (this.lastName.length == 0) {
      this.lastNameValid = false;
    } else {
      this.lastNameValid = true;
    }
  }

  submit()
  {
    if (this.firstNameValid && this.lastNameValid) {
      let param =
      {
        firstName: this.firstName,
        lastName: this.lastName
      }

      this.apiService.postExecute("stored", param)
        .subscribe(data => { console.log("Succeeded, result = " + data); this.subbmited = true }, (err) => console.error("Failed! " + err));
    }
  }

}
