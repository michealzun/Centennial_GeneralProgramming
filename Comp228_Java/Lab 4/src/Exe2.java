import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Pos;
import javafx.geometry.Insets;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.control.CheckBox;
import javafx.scene.control.RadioButton;
import javafx.scene.control.ToggleGroup;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextArea;
import javafx.scene.control.ListView;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;

public class Exe2 extends Application {
    //initialize all the objects we'll need in for the panel
    private GridPane[] gridPanes=new GridPane[5];
    private BorderPane[] borderPanes= new BorderPane[2];
    private Label[] labels=new Label[7];
    private TextField[] fields=new TextField[7];
    private CheckBox[] checkBoxes=new CheckBox[2];
    private RadioButton[] radioButtons= new RadioButton[2];
    private ToggleGroup buttonGroup=new ToggleGroup();
    private static final String[] comboItemsCS = { "Python", "C#", "Java"};
    private static final String[] comboItemsBS = { "Human Resource", "Marketing", "Statistic"};
    private ComboBox<String> comboBox= new ComboBox<>();
    private ListView<String> list = new ListView<>();
    private Button button = new Button();
    private String data;
    private TextArea textArea = new TextArea();


    //set the values for objects
    public void setInitialValues(){
        //set label texts
        labels[0]=new Label("Name:");
        labels[1]=new Label("Address:");
        labels[2]=new Label("Province:");
        labels[3]=new Label("City:");
        labels[4]=new Label("Postal Code:");
        labels[5]=new Label("Phone Number:");
        labels[6]=new Label("Email:");
        //set text boxes
        fields[0]=new TextField("John Doe");
        fields[1]=new TextField("100 Develop Road");
        fields[2]=new TextField("ON");
        fields[3]=new TextField("Toronto");
        fields[4]=new TextField("X0X0X0");
        fields[5]=new TextField("(888)888-scam");
        fields[6]=new TextField("jdoe@java.ca");
        //set checkbox text
        checkBoxes[0]=new CheckBox("Student Council");
        checkBoxes[1]=new CheckBox("Volunteer Work");
        //set radio button
        radioButtons[0] = new RadioButton("Computer Science");
        radioButtons[1] = new RadioButton("Business");
        radioButtons[0].setToggleGroup(buttonGroup);
        radioButtons[1].setToggleGroup(buttonGroup);
        radioButtons[0].setSelected(true);
        radioButtons[0].setOnAction(new RadioHandler());
        radioButtons[1].setOnAction(new RadioHandler());
        //set combo box
        ObservableList<String> items = FXCollections.observableArrayList(comboItemsCS);
        comboBox.getItems().addAll(items);
        comboBox.setOnAction(new comboHandler());
        //set list view
        list.setPrefHeight(6*24); //max items * row height
        //set button
        button.setText("Display");
        button.setOnAction(new ButtonHandler());
        //user input summary box
        textArea.setEditable(false);
        textArea.setText("press the button above");
        textArea.setPrefRowCount(5);
    }
    //set up the position for the panels
    public void setPanes(){
        //instantiate
        for (int i=0;i<borderPanes.length;i++){
            borderPanes[i]=new BorderPane();
        }
        for (int i=0;i<gridPanes.length;i++){
            gridPanes[i]=new GridPane();
        }
        gridPanes[1].setVgap(15);
        gridPanes[2].setVgap(6);
        gridPanes[3].setPadding(new Insets(50, 0, 0, 0));
        gridPanes[3].setVgap(50);
        //top part
        borderPanes[0].setCenter(gridPanes[0]);
        //bottom part
        borderPanes[0].setBottom(borderPanes[1]);
        //top first quarter
        gridPanes[0].add(gridPanes[1],0,0);
        //top 2nd quarter
        gridPanes[0].add(gridPanes[2],1,0);
        //top 3rd quarter
        gridPanes[0].add(gridPanes[3],2,0);
        //top last quarter
        gridPanes[0].add(gridPanes[4],4,0);
    }
    //add the objects into the panels
    public void addItems(){
        //adding every object into their corresponding panel
        for(int i=0; i<labels.length;i++){
            gridPanes[1].add(labels[i],0,i);
        }
        for(int i=0; i<fields.length;i++){
            gridPanes[2].add(fields[i],0,i);
        }
        for(int i=0; i<checkBoxes.length;i++){
            gridPanes[3].add(checkBoxes[i],0,i);
        }
        gridPanes[4].add(radioButtons[0],0,0);
        gridPanes[4].add(radioButtons[1],0,1);
        gridPanes[4].add(comboBox,0,2);
        gridPanes[4].add(list,0,3);
        borderPanes[1].setTop(button);
        borderPanes[1].setCenter(textArea);
        BorderPane.setAlignment(button, Pos.TOP_CENTER);
    }
    //when a radio button is selected, the combo box items get set to the corresponding array
    class RadioHandler implements EventHandler<ActionEvent> {
        @Override
        public void handle(ActionEvent e) {
            //when computer is selected
            if (radioButtons[0].isSelected()){
                ObservableList<String> items = FXCollections.observableArrayList(comboItemsCS);
                comboBox.getItems().setAll(items);
                //when business is selected
            }else if (radioButtons[1].isSelected()){
                ObservableList<String> items = FXCollections.observableArrayList(comboItemsBS);
                comboBox.getItems().setAll(items);
            }
        }
    }

    //add combo box selection to list
    class comboHandler implements EventHandler<ActionEvent> {
        @Override
        public void handle(ActionEvent e) {
            if (!comboBox.getItems().isEmpty() ) {
                String selected = comboBox.getValue();
                //checks for repeated entries
                boolean inList=false;
                for(int i = 0; i< list.getItems().size();i++){
                    if(selected==list.getItems().get(i))inList=true;
                }
                if(!inList) {
                    list.getItems().add(selected);
                }
            }
        }
    }

    //for updating the text area when the button is pressed
    class ButtonHandler implements EventHandler<ActionEvent> {
        @Override
        public void handle(ActionEvent e) {
            data="";
            for (TextField field:fields) {
                data+=field.getText()+", ";
            }
            data+=checkBoxes[0].isSelected()?"student council,":"";
            data+=checkBoxes[1].isSelected()?"volunteer,":"";
            data+="\n courses: \n";
            for(int i = 0; i< list.getItems().size();i++){
                data+=(list.getItems().get(i)) + "\n";
            }
            textArea.setText(data);
        }
    }

    public void setPaneSize(){
        //gridPanes[i]
    }

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) {
        //set things up
        setInitialValues();
        setPanes();
        addItems();
        // Create scene
        Scene scene = new Scene(borderPanes[0]);
        setPaneSize();
        primaryStage.setTitle("Exercise 2");
        primaryStage.setScene(scene);
        primaryStage.show();
    }
}
