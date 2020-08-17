import { Component } from '@angular/core';
import { Repository } from "./Models/repository";
import { Movie } from "./Models/movie.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'StoreProject';

  constructor(private repo : Repository)
    {}

  get movie( ): Movie {
      return this.repo.movie;
  }


}
