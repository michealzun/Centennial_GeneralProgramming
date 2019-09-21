//imports
import javax.swing.*;
import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;


public class Exe1 extends JFrame{
    //initialize all the objects we'll need in for the panel
    private JPanel[] panel=new JPanel[8];
    private JLabel[] labels=new JLabel[7];
    private JTextField[] fields=new JTextField[7];
    private JCheckBox[] checkBoxes=new JCheckBox[2];
    private JRadioButton[] radioButtons= new JRadioButton[2];
    private ButtonGroup buttonGroup=new ButtonGroup();
    private static final String[] comboItemsCS = { "Python", "C#", "Java"};
    private static final String[] comboItemsBS = { "Human Resource", "Marketing", "Statistic"};
    private JComboBox<String> comboBox;
    private DefaultListModel item = new DefaultListModel();
    private JList<String> list = new JList<>();
    private JButton button = new JButton();
    private String data;
    private JTextArea textArea = new JTextArea();

    //constructor
    public Exe1(){
        //set the frame
        super("Option 1 Exe 1");
        setLayout(new BorderLayout());
        setInitialValues();
        setPanels();
        addItems();
        pack();
    }

    //set the values for objects
    public void setInitialValues(){
        //set label texts
        labels[0]=new JLabel("Name:");
        labels[1]=new JLabel("Address:");
        labels[2]=new JLabel("Province:");
        labels[3]=new JLabel("City:");
        labels[4]=new JLabel("Postal Code:");
        labels[5]=new JLabel("Phone Number:");
        labels[6]=new JLabel("Email:");
        //set text boxes
        fields[0]=new JTextField("John Doe");
        fields[1]=new JTextField("100 Develop Road");
        fields[2]=new JTextField("ON");
        fields[3]=new JTextField("Toronto");
        fields[4]=new JTextField("X0X0X0");
        fields[5]=new JTextField("(888)888-scam");
        fields[6]=new JTextField("jdoe@java.ca");
        //set checkbox text
        checkBoxes[0]=new JCheckBox("Student Council");
        checkBoxes[1]=new JCheckBox("Volunteer Work");
        //set radio button
        radioButtons[0] = new JRadioButton("Computer Science");
        radioButtons[1] = new JRadioButton("Business");
        buttonGroup.add(radioButtons[0]);
        buttonGroup.add(radioButtons[1]);
        radioButtons[0].setSelected(true);
        radioButtons[0].addActionListener(new RadioHandler());
        radioButtons[1].addActionListener(new RadioHandler());
        //set combo box
        comboBox=new JComboBox<String>(comboItemsCS);
        comboBox.setMaximumRowCount(3);
        comboBox.addItemListener(new comboHandler());
        //set button
        button.setSize(100,30);
        button.setText("Display");
        button.addActionListener(new ButtonHandler());
        //user input summary box
        textArea.setEditable(false);
        textArea.setText("press the button above");
    }
    //set up the position for the panels
    public void setPanels(){
        //top part
        panel[0]=new JPanel();
        panel[0].setLayout(new GridLayout(1,4));
        add(panel[0], BorderLayout.CENTER);
        //bottom part
        panel[1]=new JPanel();
        panel[1].setLayout(new BorderLayout());
        add(panel[1], BorderLayout.SOUTH);
        //top first quarter
        panel[2]=new JPanel();
        panel[2].setLayout(new GridLayout(7,1));
        panel[0].add(panel[2]);
        //top 2nd quarter
        panel[3]=new JPanel();
        panel[3].setLayout(new GridLayout(7,1));
        panel[0].add(panel[3]);
        //top 3rd quarter
        panel[4]=new JPanel();
        panel[4].setLayout(new GridLayout(2,1));
        panel[0].add(panel[4]);
        //top last quarter
        panel[5]=new JPanel();
        panel[5].setLayout(new BorderLayout());
        panel[0].add(panel[5]);
        //top right, for the radio buttons
        panel[6]=new JPanel();
        panel[6].setLayout(new GridLayout(2,1));
        panel[5].add(panel[6],BorderLayout.NORTH);
        //right side, for the list box and combo box
        panel[7]=new JPanel();
        panel[7].setLayout(new BorderLayout());
        panel[5].add(panel[7],BorderLayout.CENTER);
    }
    //add the objects into the panels
    public void addItems(){
        //adding every object into their corresponding panel
        for (JLabel label:labels) {
            panel[2].add(label);
        }
        for (JTextField field:fields) {
            panel[3].add(field);
        }
        for (JCheckBox checkBox:checkBoxes) {
            panel[4].add(checkBox);
        }
        for (JRadioButton radio:radioButtons) {
            panel[6].add(radio);
        }
        panel[7].add(comboBox,BorderLayout.NORTH);
        panel[7].add(list,BorderLayout.CENTER);
        panel[1].add(button,BorderLayout.NORTH);
        panel[1].add(textArea,BorderLayout.CENTER);
    }

    //when a radio button is selected, the combo box items get set to the corresponding array
    private class RadioHandler implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            //when computer is selected
            if (radioButtons[0].isSelected()){
                comboBox.removeAllItems();
                for (String item :comboItemsCS) {
                    comboBox.addItem(item);
                }
                removeLastItem();
             //when business is selected
            }else if (radioButtons[1].isSelected()){
                comboBox.removeAllItems();
                for (String item :comboItemsBS) {
                    comboBox.addItem(item);
                }
                removeLastItem();
            }
        }
        private void removeLastItem(){
                item.remove(item.size()-1);
                list.setModel(item);
        }
    }

    //add combo box selection to list
    private class comboHandler implements ItemListener {
        @Override
        public void itemStateChanged(ItemEvent e) {
            if (comboBox.getItemCount()>0 && e.getStateChange() == ItemEvent.SELECTED) {
                String selected = comboBox.getSelectedItem().toString();
                //checks for repeated entries
                boolean inList=false;
                for(int i = 0; i< list.getModel().getSize();i++){
                    if(selected==list.getModel().getElementAt(i))inList=true;
                }
                if(!inList) {
                    item.addElement(selected);
                    list.setModel(item);
                }
            }
        }
    }

    //for updating the text area when the button is pressed
    private class ButtonHandler implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            data="";
            for (JTextField field:fields) {
                data+=field.getText()+", ";
            }
            data+=checkBoxes[0].isSelected()?"student council,":"";
            data+=checkBoxes[1].isSelected()?"volunteer,":"";
            data+="\n courses: \n";
            for(int i = 0; i< list.getModel().getSize();i++){
                data+=(list.getModel().getElementAt(i)) + "\n";
            }
            textArea.setText(data);
        }
    }

    //main function
    public static void main(String[] args) {
        //instantiate the Exe1 object and set how it presents
        Exe1 frame = new Exe1();
        frame.setSize(624,290);
        frame.setVisible(true);
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
    }
}
