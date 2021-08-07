import java.util.*;

public class Artists {
	
		private List<Artist> artists;
		
		public Artists(List<Artist> artists) {
			this.artists = artists;
		}
		
		public Optional<Artist> getArtist(int index) {
			if (index < 0 || index >= artists.size()) {
				return Optional.empty();
			}
			return Optional.of(artists.get(index));
		}
		
		private void indexException(int index) {
			throw new IllegalArgumentException(index + " doesn't correspond to an Artist");
		}

		public Optional<String> getArtistName(int index) {
			Artist artist = getArtist(index).orElse(null);
			return artist != null ? Optional.of(artist.getName()) : Optional.empty();
		}

}
