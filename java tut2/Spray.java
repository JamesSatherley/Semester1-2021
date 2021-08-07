package application;

import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Spray {
    // Instance variables
    private ImageView view;

    // Static variables (note the capitalization)
    private static double MAX_X, MAX_Y;
    private static Image IMAGE;
    private static List<Wasp> WASPS = new ArrayList<>();

    // This will run once when the program starts
    static {
        try {
            IMAGE = new Image(new FileInputStream("flyspray.png"));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

    // Called after program starts with the window size as parameters
    static void initialiseSpray(double maxX, double maxY) {
        // Save variables
        MAX_X = maxX;
        MAX_Y = maxY;
    }

    public Spray() {
        // Begin in top left corner
        view = new ImageView(IMAGE);
        view.setFitHeight(MAX_Y / 10);
        view.setPreserveRatio(true);
        view.setX(MAX_X / 10);
        view.setY(MAX_Y / 10);
    }
    
    public ImageView getView() {
        return view;
    }

    public static List<Wasp> getWASPS() {
        return Collections.unmodifiableList(WASPS);
    }

    public static void addWasp(Wasp w) {
        WASPS.add(w);
    }
    
    public void moveUp() {
        view.setY(isClose(view.getY(), (MAX_Y/100)*-1, MAX_Y)); // calls the isClose() function to test if it is close to a boundary
    }

    public void moveDown() {
        view.setY(isClose(view.getY(), MAX_Y/100, MAX_Y));      // if it is it will switch sides, otherwise it will just change the coordinates
    }

    public void moveLeft() {
        view.setX(isClose(view.getX(), (MAX_Y/100)*-1, MAX_X)); // in accordance with whatever button was pressed
    }

    public void moveRight() {
        view.setX(isClose(view.getX(), MAX_Y/100, MAX_X));
    }
    
    public double isClose(double coord, double difference, double max) 
    {
    	if      (coord + difference >= max)    {return 0;}
    	else if (coord + difference <= 0)      {return max;}
    	else                                   {return coord + difference;}
    }

    public void spray() {
        for (int i = 0; i < WASPS.size(); i++) // for the size of the list, do code below, until i is greater than size of the list
        {	
        	Wasp wasp = WASPS.get(i);
        	if(isCloseToBug(wasp.getView()))  // if spray is close to a wasp return true, else false and do nothing
        	{
        		WASPS.remove(i);
        		wasp.kill();
        		wasp.getView().setImage(null); // if true: remove from wasps list, .kill it, set the image to null, set the wasp to null effectively removing it completely
        		wasp = null;
        	}
        }
    }

    private boolean isCloseToBug(ImageView other) {
    	if (view.getX()+75 > other.getX() && view.getX()-75 < other.getX() && view.getY()+75 > other.getY() && view.getY()-75 < other.getY()) 
    	{
    		return true; // discussed above
    	}
    	else 
    	{
    		return false;
    	}
    }
}
