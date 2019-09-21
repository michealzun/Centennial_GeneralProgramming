package mike.healthapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;

public class FitnessLogActivity extends AppCompatActivity {
    int mode=0;
    RadioButton rb1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fitness_log);
        rb1=findViewById(R.id.radioButton);
    }

    public void goBack(View view) {
        Intent intent = new Intent(this, Introduction.class);
        startActivity(intent);
    }

    public void goResults(View view) {
        if(rb1.isChecked())
            mode=0;
        else
            mode=1;

        Intent intent = new Intent(this, ViewLogActivity.class);
        intent.putExtra("mode", mode);
        startActivity(intent);
    }
}
