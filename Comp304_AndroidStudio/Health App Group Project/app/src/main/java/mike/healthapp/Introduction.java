package mike.healthapp;


import android.content.ContentValues;
import android.content.Intent;
import android.graphics.drawable.AnimationDrawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

import java.util.ArrayList;
import java.util.List;

public class Introduction extends AppCompatActivity {
    boolean sound=false;
    DatabaseManager db;

    String[] tables={"tbl_bloodpressure","tbl_bmi"};
    String tableCreatorString[] =
            {"CREATE TABLE tbl_bloodpressure (bp_id INTEGER PRIMARY KEY AUTOINCREMENT , age INTEGER, sex TEXT, systolic INTEGER, diastolic INTEGER, diagnosis TEXT);",
            "CREATE TABLE tbl_bmi (bmi_id INTEGER PRIMARY KEY AUTOINCREMENT , height INTEGER, weight INTEGER, diagnosis TEXT);"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_introduction);
        createDatabase();
        drawLogo();
    }

    public void playSound(View view) {
        if (!sound) {
            sound=true;
            startService(new Intent(this, Sound.class));
        }else{
            sound=false;
            stopService(new Intent(this, Sound.class));
        }
    }
    public void startBlood(View view) {
        Intent intent = new Intent(this, BloodPressureActivity.class);
        startActivity(intent);
    }

    public void startBMI(View view) {
        Intent intent = new Intent(this, BMIActivity.class);
        startActivity(intent);
    }

    public void startFit(View view) {
        Intent intent = new Intent(this, FitnessLogActivity.class);
        startActivity(intent);
    }

    public void createDatabase() {
        //initialize database
        db = new DatabaseManager(this);
        db.dbInitialize(tables, tableCreatorString);

        //add sample data

        //check if sample already exist
        boolean created = false;

        String statement = "SELECT * FROM tbl_bloodpressure";
        List table = db.selectTable(statement);
        for (Object o : table) {
            ArrayList<String> row = (ArrayList<String>) o;
            for (int i = 0; i < row.size(); i++) {
                created = true;
            }
        }
        //create if table empty
        if (!created) {
            String fields[] = {"bp_id", "age", "sex", "systolic", "diastolic", "diagnosis"};
            String record[] = {"", "200", "Male", "300", "200", "dead"};
            ContentValues values = new ContentValues();
            db.addRecord(values, "tbl_bloodpressure", fields, record);
        }

    }

    private void drawLogo(){

        ImageView image= findViewById(R.id.imageView);
        AnimationDrawable anime= new AnimationDrawable();
        anime.setOneShot(false);
        anime.addFrame(getResources().getDrawable(R.drawable.frame00),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame01),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame02),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame03),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame04),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame05),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame06),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame07),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame08),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame09),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame10),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame11),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame12),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame13),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame14),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame15),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame16),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame17),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame18),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame19),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame20),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame21),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame22),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame23),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame24),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame25),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame26),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame27),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame28),30);
        anime.addFrame(getResources().getDrawable(R.drawable.frame29),30);
        image.setBackground(anime);
        anime.setVisible(true,true);
        anime.start();

    }
}
