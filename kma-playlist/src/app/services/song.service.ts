import { Injectable } from '@angular/core';
import { Http } from '@angular/http'

import 'rxjs/add/operator/toPromise';

@Injectable()
export class SongService {

  constructor(private http: Http) { }

  getSongs(): Promise<any> {
    return this.http.get('http://localhost/KMAPlaylistWebAPI/song').toPromise()
      .then(response =>
        response.json()
      )
      .catch(() => {
        console.log('Pls no, why?')
      });
  }

}
