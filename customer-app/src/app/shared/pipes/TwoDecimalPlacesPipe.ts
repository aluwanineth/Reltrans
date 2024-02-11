import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'numberFormatter' })
export class NumberFormatterPipe implements PipeTransform {

  transform(value: number, decimals = 2): string {
    if (isNaN(value)) {
      return 'N/A'; // Handle NaN values gracefully
    }

    return value.toFixed(decimals); // Use toFixed for precise formatting
  }
}