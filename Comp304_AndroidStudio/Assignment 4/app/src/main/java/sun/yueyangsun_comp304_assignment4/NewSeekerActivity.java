package sun.yueyangsun_comp304_assignment4;

import android.content.ContentValues;
import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class NewSeekerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_new_seeker);
    }

    public void next(View v){
        EditText[] userInput=new EditText[2];
        userInput[0]=findViewById(R.id.username);
        userInput[1]=findViewById(R.id.password);

        DatabaseManager db = new DatabaseManager(this);

        String fields[] = {"seeker_id","username","password"};
        String record[] = {"",userInput[0].getText().toString(),userInput[1].getText().toString()};
        ContentValues values = new ContentValues();
        db.addRecord(values, "tbl_seeker", fields,record);

        SharedPreferences.Editor editor = getSharedPreferences("user", MODE_PRIVATE).edit();
        editor.putString("username", userInput[0].getText().toString());
        editor.apply();

        Intent in=new Intent(NewSeekerActivity.this,EditSeekerActivity.class);
        startActivity(in);

    }
}
