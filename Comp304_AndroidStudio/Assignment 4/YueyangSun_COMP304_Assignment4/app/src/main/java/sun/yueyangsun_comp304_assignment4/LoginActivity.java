package sun.yueyangsun_comp304_assignment4;

import android.content.ContentValues;
import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class LoginActivity extends AppCompatActivity {


    DatabaseManager db;
    EditText username;
    EditText password;

    static final String[] tables={"tbl_admin","tbl_program","tbl_offer","tbl_payment"};

    private static final String tableCreatorString[] =
            {"CREATE TABLE tbl_admin (admin_id INTEGER PRIMARY KEY AUTOINCREMENT , username TEXT, password TEXT, firstname TEXT, lastname TEXT);",
                    "CREATE TABLE tbl_seeker (seeker_id INTEGER PRIMARY KEY AUTOINCREMENT , username TEXT , password TEXT , firstname TEXT, lastname TEXT, city TEXT, address TEXT, postal TEXT, qualification TEXT, experience TEXT);",
                    "CREATE TABLE tbl_offer (offer_id INTEGER PRIMARY KEY AUTOINCREMENT , interview_date TEXT , interview_status TEXT , company TEXT, position TEXT, recruitment_status TEXT);",
                    "CREATE TABLE tbl_payment (payment_id INTEGER PRIMARY KEY AUTOINCREMENT , payment_date TEXT , amount_paid TEXT , credit_card TEXT, card_expire TEXT);"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        username = findViewById(R.id.loginUsername);
        password = findViewById(R.id.loginPassword);

        SharedPreferences prefs = getSharedPreferences("user", MODE_PRIVATE);
        String restoredText = prefs.getString("username", null);
        if (restoredText != null) {
            username.setText(prefs.getString("username", ""));
        }

        db = new DatabaseManager(this);
        db.dbInitialize(tables, tableCreatorString);
        addSampleRecords();


    }
    public void addSampleRecords() {
        //check if already created
        boolean created = false;

        String statement = "SELECT username FROM tbl_admin";
        List table = db.selectTable(statement);
        ;
        for (Object o : table) {
            ArrayList<String> row = (ArrayList<String>) o;

            for (int i = 0; i < row.size(); i++) {
                if (row.get(i).equals("admin")) {
                    created = true;
                }
            }
        }
        if (!created){

            String adminFields[] = {"admin_id", "username", "password", "firstname", "lastname"};
            String adminRecord[] = {"", "admin", "123", "yueyang", "sun"};
            ContentValues values = new ContentValues();
            db.addRecord(values, "tbl_admin", adminFields, adminRecord);

            String seekerFields[] = {"seeker_id", "username", "password", "firstname", "lastname", "city", "address", "postal", "qualification", "experience"};
            String seekerRecord[] = {"", "rock", "123", "pet", "rock", "Toronto", "123street", "A1A1A1", "none", "former sand"};
            values = new ContentValues();
            db.addRecord(values, "tbl_seeker", seekerFields, seekerRecord);

            String offerFields[] = {"offer_id", "interview_date", "interview_status", "company", "position", "recruitment_status"};
            String offerRecord[] = {"", "jan_13_2018", "scheduled", "google", "developer", "in_search"};
            values = new ContentValues();
            db.addRecord(values, "tbl_offer", offerFields, offerRecord);

            String paymentFields[] = {"payment_id", "payment_date", "amount_paid", "credit_card", "card_expire"};
            String paymenRecord[] = {"", "jan_13_2018", "$500", "4000 4000 4000 4000", "13/22"};
            values = new ContentValues();
            db.addRecord(values, "tbl_payment", paymentFields, paymenRecord);
            }
        /*
        to display

         List table = db.getTable("tbl_offer");

        for (Object o : table) {
            ArrayList<String> row = (ArrayList<String>) o;
            // Writing table to log
            String output = "";
            for (int i = 0; i < row.size(); i++) {
                output += row.get(i).toString() + " ";
                output += "\n";
            }
            username.setText(output);

        }
         */
    }

    public void shareUser(){
        SharedPreferences.Editor editor = getSharedPreferences("user", MODE_PRIVATE).edit();
        editor.putString("username", username.getText().toString());
        editor.apply();
    }
    public void register(View v){
        Intent intent= new Intent(LoginActivity.this,NewSeekerActivity.class);
        startActivity(intent);
    }
    public void adminLogin(View v){
        boolean success=false;

        String statement= "SELECT password FROM tbl_admin WHERE username = \'"+ username.getText()+"\'";
        List table = db.selectTable(statement);
;
        for (Object o : table) {
            ArrayList<String> row = (ArrayList<String>) o;

            for (int i = 0; i < row.size(); i++) {
                if( row.get(i).equals(password.getText().toString()))
                {
                    success=true;
                }
            }
        }

        if(success){
        shareUser();
        Intent intent= new Intent(LoginActivity.this,OptionAdminActivity.class);
        startActivity(intent);}
    }
    public void seekerLogin(View v){
        boolean success=false;

        String statement= "SELECT password FROM tbl_seeker WHERE username = \'"+ username.getText()+"\'";
        List table = db.selectTable(statement);

        for (Object o : table) {
            ArrayList<String> row = (ArrayList<String>) o;

            for (int i = 0; i < row.size(); i++) {
                if( row.get(i).toString().equals(password.getText().toString()))success=true;
            }
        }
        if(success){
            shareUser();
            Intent intent= new Intent(LoginActivity.this,ViewSeekerActivity.class);
            startActivity(intent);}
    }
}
