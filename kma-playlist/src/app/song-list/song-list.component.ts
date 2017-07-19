import { Component, OnInit } from '@angular/core';

import { SongService } from '../services/song.service'

@Component({
  selector: 'song-list',
  templateUrl: './song-list.component.html',
  styleUrls: ['./song-list.component.css'],
  providers: [SongService]
})
export class SongListComponent implements OnInit {

  isLoading: boolean;
  songs: any[];

  constructor(private songService: SongService) { }

  ngOnInit() {
    this.songs = [];
    this.refreshSongs();
  }

  refreshSongs(): void {
    this.isLoading = true;
    this.songService.getSongs().then((songs) => {
      this.songs = songs;
      this.isLoading = false;
    });
  }
}
