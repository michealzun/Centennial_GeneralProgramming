public abstract class Movie {
    //variables
    private String title;
    private String studio;
    private String leadActor;
    protected double budget;
    private int year;

    //toString returns all the variables in a formatted string
    @Override
    public String toString() {
        return String.format("Title: %s%nStudio: %s%nLead Actor: %s%nBudget: %.2f%nYear: %d%n",title,studio,leadActor,budget,year);
    }

    //accessors for all the variables except budget
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getStudio() {
        return studio;
    }

    public void setStudio(String studio) {
        this.studio = studio;
    }

    public String getLeadActor() {
        return leadActor;
    }

    public void setLeadActor(String leadActor) {
        this.leadActor = leadActor;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    //constructor for all variables
    public Movie(String title, String studio, String leadActor, double budget, int year) {
        this.title = title;
        this.studio = studio;
        this.leadActor = leadActor;
        this.budget = budget;
        this.year = year;
    }

    //abstract budget setter for child class to define
    public abstract void setBudget(double budget);

    //abstract getter to return the genre of the movie
    public abstract String getGenre();
}
