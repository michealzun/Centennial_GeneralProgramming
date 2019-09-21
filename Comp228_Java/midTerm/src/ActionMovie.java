public class ActionMovie extends Movie {
    //default constructor plus charge 10% extra for action movies
    public ActionMovie(String title, String studio, String leadActor, double budget, int year) {
        super(title, studio, leadActor, budget*1.1, year);
    }

    //set the budget charge 10% extra for action movies
    @Override
    public void setBudget(double budget) {
        super.budget=budget*1.1;
    }

    @Override
    public String getGenre() {
        return "Genre: Action";
    }
}
