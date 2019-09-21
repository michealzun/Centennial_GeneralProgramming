//imports
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Run extends JFrame{
    //initialize database objects
    private PreparedStatement prepared;
    private Connection conn;
    public static final String DRIVER = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
    public static final String DATABASE_URL = "jdbc:sqlserver://localhost:1433;database=Lab5;integratedSecurity=true";
    //initialize interface objects
    private JTabbedPane tabbedPane = new JTabbedPane();
    private ReturnTableModel[] tableModels= new ReturnTableModel[3];
    private JPanel[] panel=new JPanel[7];
    private JLabel[] labels=new JLabel[23];
    private JTextField[] fields=new JTextField[14];
    private JButton[] buttons= new JButton[7];
    private JTable[] tables=new JTable[3];

    //constructor
    public Run(){
        //set the frame
        super("Players and Games");
        setLayout(new FlowLayout());
        setInitialValues();
        setPanels();
        addItems();
        pack();
    }

    //set the values for objects
    public void setInitialValues(){
        //set label texts
        labels[0]=new JLabel("Player Data");
        labels[1]=new JLabel("Player ID");
        labels[2]=new JLabel("First Name: ");
        labels[3]=new JLabel("Last Name: ");
        labels[4]=new JLabel("Address: ");
        labels[5]=new JLabel("Postal Code: ");
        labels[6]=new JLabel("Province: ");
        labels[7]=new JLabel("Phone Number: ");
        labels[8]=new JLabel("Game Data");
        labels[9]=new JLabel("Game ID(only for editing): ");
        labels[10]=new JLabel("Game Title: ");
        labels[11]=new JLabel("Game To Player Relationship");
        labels[12]=new JLabel("Game to Player ID(only for editing): ");
        labels[13]=new JLabel("Game ID: ");
        labels[14]=new JLabel("Player ID: ");
        labels[15]=new JLabel("Playing Date(yyyy-mm-dd): ");
        labels[16]=new JLabel("Score: ");
        labels[17]=new JLabel("", SwingConstants.CENTER);
        labels[18]=new JLabel("", SwingConstants.CENTER);
        labels[19]=new JLabel("", SwingConstants.CENTER);
        labels[20]=new JLabel("");
        labels[21]=new JLabel("");
        labels[22]=new JLabel("");
        //set text boxes for sample input
        fields[0]=new JTextField("1");
        fields[1]=new JTextField("Yue yang");
        fields[2]=new JTextField("Sun");
        fields[3]=new JTextField("Bat cave");
        fields[4]=new JTextField("X0X0X0");
        fields[5]=new JTextField("Ontario");
        fields[6]=new JTextField("(888)888-scam");
        fields[7]=new JTextField("1");
        fields[8]=new JTextField("Maple Story");
        fields[9]=new JTextField("1");
        fields[10]=new JTextField("1");
        fields[11]=new JTextField("1");
        fields[12]=new JTextField("2018-01-01");
        fields[13]=new JTextField("9001");
        //set button text
        buttons[0]=new JButton("Add Player");
        buttons[0].addActionListener(new ButtonHandler1());
        buttons[1]=new JButton("Change Player");
        buttons[1].addActionListener(new ButtonHandler2());
        buttons[2]=new JButton("Add Game");
        buttons[2].addActionListener(new ButtonHandler3());
        buttons[3]=new JButton("Change Game");
        buttons[3].addActionListener(new ButtonHandler4());
        buttons[4]=new JButton("Add Relation");
        buttons[4].addActionListener(new ButtonHandler5());
        buttons[5]=new JButton("Change Relation");
        buttons[5].addActionListener(new ButtonHandler6());
        //display
        try {
            tableModels[0] = new ReturnTableModel(DRIVER, DATABASE_URL, "SELECT * FROM Player");
        } catch(Exception e){
            labels[18].setText("cannot select from player table");
        }
        try {
            tableModels[1] = new ReturnTableModel(DRIVER, DATABASE_URL, "SELECT * FROM Game");
        } catch(Exception e){
            labels[19].setText("cannot select from game table");
        }
        try {
            tableModels[2] = new ReturnTableModel(DRIVER, DATABASE_URL, "SELECT * FROM PlayerGame");
        } catch(Exception e){
            labels[20].setText("cannot select from game table");
        }
        tables[0]=new JTable(tableModels[0]);
        tables[1]=new JTable(tableModels[1]);
        tables[2]=new JTable(tableModels[2]);
    }

    //set up the position for the panels
    public void setPanels(){
        //player tab
        panel[0]=new JPanel();
        panel[0].setLayout(new BorderLayout());
        panel[1]=new JPanel();
        panel[1].setLayout(new GridLayout(9,2));
        panel[0].add(panel[1], BorderLayout.WEST);
        //game tab
        panel[2]=new JPanel();
        panel[2].setLayout(new BorderLayout());
        panel[3]=new JPanel();
        panel[3].setLayout(new GridLayout(4,2));
        panel[2].add(panel[3], BorderLayout.WEST);
        //player to game tab
        panel[4]=new JPanel();
        panel[4].setLayout(new BorderLayout());
        panel[5]=new JPanel();
        panel[5].setLayout(new GridLayout(7,2));
        panel[4].add(panel[5], BorderLayout.WEST);
        //custom statement tab
        panel[6]=new JPanel();
        panel[6].setLayout(new BorderLayout());
        //add the tabs
        tabbedPane.addTab("Players", panel[0]);
        tabbedPane.addTab("Games", panel[2]);
        tabbedPane.addTab("Player2Game", panel[4]);
        add(tabbedPane);
    }
    //add the objects into the panels
    public void addItems(){
        //player tab
        panel[0].add(tables[0],BorderLayout.CENTER);
        panel[0].add(labels[17],BorderLayout.SOUTH);
        panel[1].add(labels[0]);
        panel[1].add(labels[20]);
        for (int i = 0; i<=6;i++){
            panel[1].add(labels[i+1]);
            panel[1].add(fields[i]);
        }
        panel[1].add(buttons[0]);
        panel[1].add(buttons[1]);

        //game tab
        panel[2].add(tables[1],BorderLayout.CENTER);
        panel[2].add(labels[18],BorderLayout.SOUTH);
        panel[3].add(labels[8]);
        panel[3].add(labels[21]);
        for (int i = 7; i<=8;i++){
            panel[3].add(labels[i+2]);
            panel[3].add(fields[i]);
        }
        panel[3].add(buttons[2]);
        panel[3].add(buttons[3]);

        //player to game tab
        panel[4].add(tables[2],BorderLayout.CENTER);
        panel[4].add(labels[19],BorderLayout.SOUTH);
        panel[5].add(labels[11]);
        panel[5].add(labels[22]);
        for (int i = 9; i<=13;i++){
            panel[5].add(labels[i+3]);
            panel[5].add(fields[i]);
        }
        panel[5].add(buttons[4]);
        panel[5].add(buttons[5]);
    }

    //for inserting player
    private class ButtonHandler1 implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            //grab from the message box and execute using prepared update
            try {
                Class.forName(DRIVER);
                conn = DriverManager.getConnection(DATABASE_URL);
                prepared = conn.prepareStatement("INSERT into Player (player_id,first_name, last_name, address, postal_code,province,phone_number) VALUES(?,?,?,?,?,?,?)");
                //unlike other primary keys, the player pk isn't set to auto increment so that the players can choose
                prepared.setString(1, fields[0].getText());
                prepared.setString(2, fields[1].getText());
                prepared.setString(3, fields[2].getText());
                prepared.setString(4, fields[3].getText());
                prepared.setString(5, fields[4].getText());
                prepared.setString(6, fields[5].getText());
                prepared.setString(7, fields[6].getText());
                prepared.executeUpdate();
                tableModels[0].Refresh();
            }
            //exception handling
            catch (SQLException ex) {
                ex.printStackTrace();
            }
            catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            }
            finally {
                try {
                    prepared.close();
                    conn.close();
                }
                catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        }
    }
    //for editing player
    private class ButtonHandler2 implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            //grab from the message box and execute using prepared update
            try {
                Class.forName(DRIVER);
                conn = DriverManager.getConnection(DATABASE_URL);
                prepared = conn.prepareStatement("Update Player Set first_name=?, last_name=?, address=?, postal_code=?,province=?,phone_number=? Where player_id=?");
                prepared.setString(1, fields[1].getText());
                prepared.setString(2, fields[2].getText());
                prepared.setString(3, fields[3].getText());
                prepared.setString(4, fields[4].getText());
                prepared.setString(5, fields[5].getText());
                prepared.setString(6, fields[6].getText());
                prepared.setInt(7, Integer.parseInt(fields[0].getText()));
                prepared.executeUpdate();
                tableModels[0].Refresh();
            }
            //exception handling
            catch (SQLException ex) {
                ex.printStackTrace();
            } catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            } finally {
                try {
                    prepared.close();
                    conn.close();
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        }
    }
    //for inserting player
    private class ButtonHandler3 implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            //grab from the message box and execute using prepared update
            try {
                Class.forName(DRIVER);
                conn = DriverManager.getConnection(DATABASE_URL);
                prepared = conn.prepareStatement("INSERT into Game (game_title) VALUES(?)");
                prepared.setString(1, fields[8].getText());
                prepared.executeUpdate();
                tableModels[1].Refresh();
            }
            //exception handling
            catch (SQLException ex) {
                ex.printStackTrace();
            }
            catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            }
            finally {
                try {
                    prepared.close();
                    conn.close();
                }
                catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        }
    }
    //for editing player
    private class ButtonHandler4 implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            //grab from the message box and execute using prepared update
            try {
                Class.forName(DRIVER);
                conn = DriverManager.getConnection(DATABASE_URL);
                prepared = conn.prepareStatement("Update Game Set game_title=? Where game_id=?");
                prepared.setString(1, fields[8].getText());
                prepared.setInt(2, Integer.parseInt(fields[7].getText()));
                prepared.executeUpdate();
                tableModels[1].Refresh();
            }
            //exception handling
            catch (SQLException ex) {
                ex.printStackTrace();
            } catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            } finally {
                try {
                    prepared.close();
                    conn.close();
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        }
    }
    //for inserting player
    private class ButtonHandler5 implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            //grab from the message box and execute using prepared update
            try {
                Class.forName(DRIVER);
                conn = DriverManager.getConnection(DATABASE_URL);
                prepared = conn.prepareStatement("INSERT into PlayerGame (player_id,game_id,playing_date,score) VALUES(?,?,?,?)");
                prepared.setInt(1, Integer.parseInt(fields[10].getText()));
                prepared.setInt(2, Integer.parseInt(fields[11].getText()));
                //try to convert text input into sql date format
                try {
                Date date=new SimpleDateFormat("yyyy-MM-dd").parse(fields[12].getText());
                prepared.setDate(3, new java.sql.Date(date.getTime()));
                }catch (ParseException ex) {
                    ex.printStackTrace();
                }
                prepared.setInt(4, Integer.parseInt(fields[13].getText()));
                prepared.executeUpdate();
                tableModels[2].Refresh();
            }
            //exception handling
            catch (SQLException ex) {
                ex.printStackTrace();
            }
            catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            }
            finally {
                try {
                    prepared.close();
                    conn.close();
                }
                catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        }
    }
    //for editing player
    private class ButtonHandler6 implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            //grab from the message box and execute using prepared update
            try {
                Class.forName(DRIVER);
                conn = DriverManager.getConnection(DATABASE_URL);
                prepared = conn.prepareStatement("Update PlayerGame Set player_id=?, game_id=?, playing_date=?, score=? Where player_game_id=?");
                prepared.setInt(1, Integer.parseInt(fields[10].getText()));
                prepared.setInt(2, Integer.parseInt(fields[11].getText()));
                //try to convert text input into sql date format
                try {
                    Date date=new SimpleDateFormat("yyyy-MM-dd").parse(fields[12].getText());
                    prepared.setDate(3, new java.sql.Date(date.getTime()));
                }catch (ParseException ex) {
                    ex.printStackTrace();
                }
                prepared.setInt(4, Integer.parseInt(fields[13].getText()));
                prepared.setInt(5, Integer.parseInt(fields[9].getText()));
                prepared.executeUpdate();
                tableModels[2].Refresh();
            }
            //exception handling
            catch (SQLException ex) {
                ex.printStackTrace();
            } catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            } finally {
                try {
                    prepared.close();
                    conn.close();
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        }
    }
    //main function
    public static void main(String[] args) {
        //instantiate the Run object and set how it shows
        Run frame = new Run();
        frame.setSize(900,320);
        frame.setVisible(true);
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
    }
}
