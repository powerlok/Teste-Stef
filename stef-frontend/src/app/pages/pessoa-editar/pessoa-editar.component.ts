import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl, Validators, FormBuilder, FormArray } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { PhoneNumberType } from 'src/app/model/phone-number-type.model';
import { PersonService } from 'src/app/services/person.service';
import { PhoneNumberTypeService } from 'src/app/services/phone-number-type.service';
import * as _ from 'lodash';
import { PersonPhone } from 'src/app/model/person-phone.model';

@Component({
  selector: "app-pessoa-editar",
  templateUrl: "pessoa-editar.component.html",
  styleUrls: ["./pessoa-editar.component.css"]
})
export class PessoaEditarComponent implements OnInit {

  formPerson: FormGroup;
  form: FormArray;
  id: number;
  personPhone: any;
  phoneNumberTypeData: PhoneNumberType[];

  constructor(private _fb: FormBuilder,
    private personService: PersonService,
    private activatedRoute: ActivatedRoute,
    private phoneNumberTypeService: PhoneNumberTypeService) {

    this.formPerson = this._fb.group({
      phones: this._fb.array([])
    });
  }

  ngOnInit() {
    this.id = this.activatedRoute.snapshot.params['id'];
    this.getPhoneNumberType();
    this.getPersonPhoneById(this.id);
  }

  setFormGroup() {

    let array = this.formPerson.get('phones') as FormArray;
    _.forEach(this.personPhone.phones, (row: PersonPhone) => {
      array.push(this._fb.group({
        businessEntityID: new FormControl(row.businessEntityID, Validators.compose([Validators.required])),
        phoneNumberTypeID: new FormControl(row.phoneNumberTypeID, Validators.compose([Validators.required])),
        phoneNumber: new FormControl(row.phoneNumber, Validators.compose([Validators.required])),
      }))
    });
  }

  getPersonPhoneById(id: any) {
    this.personService.getById(id).subscribe((response: any) => {
      if (response.success) {
        this.personPhone = response.data.personObject;
        this.setFormGroup();
      } else {
        console.log('Error ao carregar a lista');
      }
    });
  }

  getPhoneNumberType() {
    this.phoneNumberTypeService.getAll().subscribe((response: any) => {
      if (response.success) {
        this.phoneNumberTypeData = response.data.phoneNumberObjects;
      } else {
        console.log('Error ao carregar a lista');
      }
    })
  }

  onSubmit() {
    this.personService.update(this.formPerson.value).subscribe((response) => {
      console.log(response);
    });
  }
}
