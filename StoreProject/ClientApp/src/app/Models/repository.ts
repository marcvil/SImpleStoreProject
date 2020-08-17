import { Movie } from "./movie.model";
import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable()
export class Repository {

  public movie: Movie;
  constructor(private httpClient: HttpClient,@Inject('BASE_URL')baseUrl :string)
  {
    httpClient.get<Movie>(baseUrl + 'Movies/GetMovie')
      .subscribe(result => {
          this.movie = result
        },
        error => console.error(error)
        );

  }

}
