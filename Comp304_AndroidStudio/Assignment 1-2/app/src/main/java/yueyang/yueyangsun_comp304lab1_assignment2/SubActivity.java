package yueyang.yueyangsun_comp304lab1_assignment2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class SubActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sub);

        TextView textView=findViewById(R.id.textView9);
        Intent intent=getIntent();
        String output = String.format("name : %s%nprogram : %s%nsemester : %s%n course : %s",
                intent.getStringExtra("name"),
                intent.getStringExtra("program"),
                intent.getStringExtra("semester"),
                intent.getStringExtra("course"));
        textView.setText(output);
        textView.setTextSize(34);
    }
}
