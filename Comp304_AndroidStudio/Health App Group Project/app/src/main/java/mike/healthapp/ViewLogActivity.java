package mike.healthapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class ViewLogActivity extends AppCompatActivity {
    int mode;
    TextView tv;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view_log);

        tv= findViewById(R.id.tvRecords);
        mode = getIntent().getIntExtra("mode",0);


        DatabaseManager db = new DatabaseManager(this);
        List table;
        switch(mode){
            case 0:
                table = db.getTable("tbl_bloodpressure");

                for (Object o : table) {
                    ArrayList<String> row = (ArrayList<String>)o;
                    String output="";
                    for (int i=0;i<row.size();i++)
                    {
                        output+= row.get(i).toString() + " ";
                        output+="\n";
                    }
                    tv.setText(output);
                }
                break;
            case 1:
                table = db.getTable("tbl_bmi");

                for (Object o : table) {
                    ArrayList<String> row = (ArrayList<String>)o;
                    String output="";
                    for (int i=0;i<row.size();i++)
                    {
                        output+= row.get(i).toString() + " ";
                        output+="\n";
                    }
                    tv.setText(output);
                }
                break;
        }
    }

    public void goBack(View view) {
        Intent intent = new Intent(this, FitnessLogActivity.class);
        startActivity(intent);
    }
}
