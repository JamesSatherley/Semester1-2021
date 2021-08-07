import java.util.ArrayList;
import java.util.List;

public class ArtistDemo {
    public static void main(String[] args) {
        Artist artist1 = new Artist("x", "y", "z");
        Artist artist2 = new Artist("i", "j", "k");
        List<Artist> artistsList = new ArrayList<>();
        artistsList.add(artist1);
        artistsList.add(artist2);
        Artists artists = new Artists(artistsList);
        System.out.println(artists.getArtistName(0));
        System.out.println(artists.getArtistName(1));
        System.out.println(artists.getArtistName(2));
    }
}
