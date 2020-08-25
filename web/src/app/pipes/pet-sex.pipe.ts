import {Pipe, PipeTransform} from '@angular/core';

@Pipe({
  name: 'petSex'
})
export class PetSexPipe implements PipeTransform {

  transform(value: string): string {
    if (value === 'female') {
      return 'Fêmea';
    }

    return 'Macho';
  }

}
