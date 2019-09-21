package sun.yueyangsun_comp304_assignment4;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class AllOfferActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_all_offer);

        TextView tv= findViewById(R.id.textView12);

        DatabaseManager db = new DatabaseManager(this);
        List table = db.getTable("tbl_offer");

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
