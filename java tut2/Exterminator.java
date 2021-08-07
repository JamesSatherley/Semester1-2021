package application;

import javafx.animation.AnimationTimer;
import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.KeyEvent;
import javafx.scene.layout.StackPane;
import javafx.scene.text.Font;
import javafx.scene.text.Text;
import javafx.stage.Stage;

public class Exterminator extends Application {

    private Spray spray;

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) {
        // GUI Plumbing
        Group root = new Group();
        Scene scene = new Scene(root);
        primaryStage.setScene(scene);
        primaryStage.setFullScreen(true);
        primaryStage.setTitle("Let's play!");
        primaryStage.show();

        // Set window size
        double width = scene.getWidth();
        double height = scene.getHeight();
        Wasp.initialiseHive(width, height);
        Spray.initialiseSpray(width, height);

        // Set finish scene
        Text message = new Text(width/5, height/5, "The scourge of the wasps is no more!");
        message.setFont(new Font(30));
        StackPane rootFinish = new StackPane();
        rootFinish.getChildren().add(message);
        rootFinish.setAlignment(Pos.CENTER);
        Scene finish = new Scene(rootFinish, 800, 600);

        // Create objects and add initial image views to GUI
        spray = new Spray();
        root.getChildren().addAll(Wasp.getHIVE(), spray.getView());

        // Handle key strokes (give event to moveSpray method)
        scene.setOnKeyPressed(this::moveSpray); // This means that the method moveSpray in this class is called on a key press

        // Main game loop. The AnimationTimer's default handle method has been changed.
        new AnimationTimer() {
            private long lastUpdate = 0;
            
            @Override 
            public void handle(long now) {
                // Change this to change speed (nanoseconds)
                if (now - lastUpdate > 200_000_000) {
                    lastUpdate = now;
                } else {
                    return;
                }

                // End game
                if (Wasp.getHiveHealth() < 0) {
                    primaryStage.setScene(finish);
                    primaryStage.setTitle("Game Finished!");
                    this.stop();
                }

                // Create new wasp
                Wasp w = new Wasp();
                Spray.addWasp(w); // You will need to access the wasps for game logic
                root.getChildren().add(w.getView()); // Add wasp's image view so it shows up on the screen
                
                // Move wasps
                for (Wasp wasp: Spray.getWASPS()) {
                    wasp.move();
                }
            }
        }.start();
    }

    private void moveSpray(KeyEvent e) {
        // Works with direction arrows, or WASD commands
        switch(e.getCode()) {
            case UP: case W:
                spray.moveUp();
                spray.spray();
                break;
            case DOWN: case S:
                spray.moveDown();
                spray.spray();
                break;
            case LEFT: case A:
                spray.moveLeft();
                spray.spray();
                break;
            case RIGHT: case D:
                spray.moveRight();
                spray.spray();
                break;
		default:
			break;
        }
    }

}
