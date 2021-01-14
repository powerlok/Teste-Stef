import { Component, OnInit } from "@angular/core";
import { PersonService } from './../../services/person.service';
import { Person } from './../../model/person.model';

@Component({
  selector: "app-pessoa",
  templateUrl: "pessoa.component.html",
  styleUrls: ["./pessoa.component.css"]
})
export class PessoaComponent implements OnInit {

  personData: Person[] = [];

  constructor(private personService: PersonService) { }

  ngOnInit() {
    this.personService.getAll().subscribe((response: any) => {
      if (response.success) {
        this.personData = response.data.personObjects;
      } else {
        console.log('Error ao carregar a lista ded Person!!');
      }
    });
  }


}
