package sun.yueyangsun_comp304_assignment4;

import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class ViewSeekerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view_seeker);

        TextView tv= findViewById(R.id.textView);

        DatabaseManager db = new DatabaseManager(this);

        SharedPreferences prefs = getSharedPreferences("user", MODE_PRIVATE);
        String statement="SELECT * FROM tbl_seeker WHERE username = \'"+ prefs.getString("username", null)+"\'";

        List table = db.selectTable(statement);

        for (Object o : table) {
            ArrayList<String> row = (ArrayList<String>) o;
            // Writing table to log
            String output = "";
            for (int i = 0; i < row.size(); i++) {
                output += row.get(i).toString() + " ";
                output += "\n";
            }
            tv.setText(output);
        }
    }

    public void edit(View v){
        Intent in=new Intent(ViewSeekerActivity.this,EditSeekerActivity.class);
        startActivity(in);
    }
}

