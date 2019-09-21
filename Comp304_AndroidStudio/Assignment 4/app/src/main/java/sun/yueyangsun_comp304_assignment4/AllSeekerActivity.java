package sun.yueyangsun_comp304_assignment4;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class AllSeekerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_all_seeker);

        TextView tv= findViewById(R.id.textView10);

        DatabaseManager db = new DatabaseManager(this);
        String statement="SELECT username FROM tbl_seeker";
        List table = db.selectTable(statement);

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

    }

}
