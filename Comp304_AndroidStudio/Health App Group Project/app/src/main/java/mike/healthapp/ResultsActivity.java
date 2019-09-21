package mike.healthapp;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;
import android.widget.TextView;

public class ResultsActivity extends AppCompatActivity {

    public String source;
    public TextView tvInfo;
    Intent intent;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_results);
        tvInfo=findViewById(R.id.tvInfo);

        intent = getIntent();
        source = intent.getStringExtra("sourceActivity");
        tvInfo.setText(intent.getStringExtra("info"));
    }

    public void goBack(View view) {

        if(source == "bloodpressure"){
            Intent intent = new Intent(this, BloodPressureActivity.class);
            startActivity(intent);

        } else if(source == "bmi"){
            Intent intent = new Intent(this, BMIActivity.class);
            startActivity(intent);

        } else {
            Intent intent = new Intent(this, Introduction.class);
            startActivity(intent);
        }



    }

    public void sendMessage(View view){
        String x= "smsto:"+intent.getIntExtra("phone",0);
        Intent i = new Intent(android.content.Intent.ACTION_SENDTO,Uri.parse(x));
        i.putExtra("sms_body", tvInfo.getText().toString());
        startActivity(i);
    }
}
