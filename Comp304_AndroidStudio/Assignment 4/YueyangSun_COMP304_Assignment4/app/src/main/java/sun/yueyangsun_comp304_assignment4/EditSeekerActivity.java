package sun.yueyangsun_comp304_assignment4;

import android.content.ContentValues;
import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class EditSeekerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_seeker);
    }

    public void next(View v){
        EditText[] userInput=new EditText[7];
        userInput[0]=findViewById(R.id.firstName);
        userInput[1]=findViewById(R.id.lastName);
        userInput[2]=findViewById(R.id.address);
        userInput[3]=findViewById(R.id.city);
        userInput[4]=findViewById(R.id.postal);
        userInput[5]=findViewById(R.id.qualification);
        userInput[6]=findViewById(R.id.experience);

        SharedPreferences prefs = getSharedPreferences("user", MODE_PRIVATE);
        String user = prefs.getString("username", null);

        DatabaseManager db = new DatabaseManager(this);

        String fields[] = {"username","firstname","lastname","address","city","postal","qualification","experience"};
        String record[] = {user,
                userInput[0].getText().toString(),
                userInput[1].getText().toString(),
                userInput[2].getText().toString(),
                userInput[3].getText().toString(),
                userInput[4].getText().toString(),
                userInput[5].getText().toString(),
                userInput[6].getText().toString()};
        ContentValues values = new ContentValues();
        db.updateRecord(values, "tbl_seeker", fields,record);

        Intent in=new Intent(EditSeekerActivity.this,ViewSeekerActivity.class);
        startActivity(in);

    }
}
