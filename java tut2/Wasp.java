package application;

import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.Random;

public class Wasp {
    // Instance variables
    private ImageView view;

    // Static variables (note the capitalization)
    private static ImageView HIVE;
    private static int HIVE_HEALTH = 100;
    private static double MAX_X, MAX_Y;
    private static double HIVE_X, HIVE_Y;
    private static Image IMAGE;
    private static Random RAND = new Random();

    // This will run once when the program starts
    static {
        try {
            IMAGE = new Image(new FileInputStream("wasp.png"));
            HIVE = new ImageView(new Image(new FileInputStream("hive.png")));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

    // Called after program starts with the window size as parameters
    static void initialiseHive(double maxX, double maxY) {
        // Save variables
        MAX_X = maxX;
        MAX_Y = maxY;

        // Put hive in center of the screen
        HIVE_X = MAX_X / 2;
        HIVE_Y = MAX_Y / 2;
        HIVE.setFitHeight(MAX_X / 10);
        HIVE.setPreserveRatio(true);
        HIVE.setX(HIVE_X);
        HIVE.setY(HIVE_Y);
    }

    // Constructor sets ImageView and initial placement at the hive
    public Wasp() {
        // Place wasp on random part of the screen
        view = new ImageView(IMAGE);
        view.setFitHeight(MAX_Y / 20);
        view.setPreserveRatio(true);
        view.setX(RAND.nextInt((int)MAX_X));
        view.setY(RAND.nextInt((int)MAX_Y));
    }
    
    public ImageView getView() {
        return view;
    }

    public static ImageView getHIVE() {
        return HIVE;
    }

    public static int getHiveHealth() {
        return HIVE_HEALTH;
    }

    public void move() {
        int x = (RAND.nextInt(10)-5); // generates a random number between -5 and 5
        int y = (RAND.nextInt(10)-5);
        
        if      (view.getX() + x >= MAX_X) {view.setX(0);}
    	else if (view.getX() + x <= 0)     {view.setX(MAX_X);}
    	else                               {view.setX(view.getX()+x);} // if number will not send coordinates over boundaries it will be changed
        
        if      (view.getY() + y >= MAX_Y) {view.setY(0);}
    	else if (view.getY() + y <= 0)     {view.setY(MAX_Y);}
    	else                               {view.setY(view.getY()+y);}
    }

    public void kill() {
    	HIVE_HEALTH -= 1; // take down 1 hp of hive
    }
}
