import { Person } from './person.model';
import { PhoneNumberType } from './phone-number-type.model';

export class PersonPhone {
    businessEntityID: number;
    phoneNumberTypeID: number;
    phoneNumber: string;
    person: Person;
    phoneNumberType: PhoneNumberType;
}