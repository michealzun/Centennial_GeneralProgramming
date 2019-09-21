import javax.swing.JOptionPane;

public class Driver {
   //movie variable
    private static Movie movie;

    public static void main(String[] args) {
        //instantiate and show by calling the two methods
        showInputDialog();
        showMessageDialog();

        //make changes by using jOptionPane inputs then setters and then show it again
        String title =JOptionPane.showInputDialog("enter movie title");
        movie.setTitle(title);
        String studio =JOptionPane.showInputDialog("enter movie studio");
        movie.setStudio(studio);
        String leadActor =JOptionPane.showInputDialog("enter movie lead actor");
        movie.setLeadActor(leadActor);
        double budget = Double.parseDouble(JOptionPane.showInputDialog("enter movie budget"));
        movie.setBudget(budget);
        int year = Integer.parseInt(JOptionPane.showInputDialog("enter movie year"));
        movie.setYear(year);
        showMessageDialog();

    }

    public static void showInputDialog(){
        //ask for title
        String title =JOptionPane.showInputDialog("enter movie title");

        //ask for studio
        String studio =JOptionPane.showInputDialog("enter movie studio");

        //ask for lead actor
        String leadActor =JOptionPane.showInputDialog("enter movie lead actor");

        //ask for budget
        double budget = Double.parseDouble(JOptionPane.showInputDialog("enter movie budget"));

        //ask for year
        int year = Integer.parseInt(JOptionPane.showInputDialog("enter movie year"));

        //ask for movie type and use a switch to instantiate the right movie type using values provided
        int movieType =Integer.parseInt(JOptionPane.showInputDialog("movie type: 1-Action, 2-Comedy"));
        switch(movieType){
            case 1:
                movie = new ActionMovie(title,studio,leadActor,budget,year);
                break;
            case 2:
                movie = new ComedyMovie(title,studio,leadActor,budget,year);
                break;
            default:
                //in case if user don't enter 1 or 2
                throw new IllegalArgumentException("please enter a number 1 or 2");
        }
    }

    public static void showMessageDialog(){
        //display the movie info using jOptionPane
        JOptionPane.showMessageDialog(null,movie+movie.getGenre());
    }
}
