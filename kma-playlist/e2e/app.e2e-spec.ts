import { KmaPlaylistPage } from './app.po';

describe('kma-playlist App', () => {
  let page: KmaPlaylistPage;

  beforeEach(() => {
    page = new KmaPlaylistPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
