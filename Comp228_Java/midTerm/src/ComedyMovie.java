public class ComedyMovie extends Movie {
    //default constructor that uses it's parent's constructor
    public ComedyMovie(String title, String studio, String leadActor, double budget, int year) {
        super(title, studio, leadActor, budget, year);
    }

    //set the budget of the movie
    @Override
    public void setBudget(double budget) {
        super.budget=budget;
    }

    @Override
    public String getGenre() {
        return "Genre: Comedy";
    }
}
