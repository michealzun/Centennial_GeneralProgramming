package yueyang.yueyangsun_comp304lab1_assignment1;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class SecondActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        TextView textView=findViewById(R.id.textView);
        Intent intent=getIntent();
        textView.setText(intent.getStringExtra("userInput"));
        textView.setTextSize(34);
    }
}
