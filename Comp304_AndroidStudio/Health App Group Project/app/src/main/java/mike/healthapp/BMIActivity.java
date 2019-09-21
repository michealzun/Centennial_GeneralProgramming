package mike.healthapp;

import android.content.ContentValues;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;

public class BMIActivity extends AppCompatActivity {

    float height;
    float weight;
    int phone;
    float bmi;
    String diagnosis;
    String info;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bmi);
    }

    public void goBack(View view) {
        Intent intent = new Intent(this, Introduction.class);
        startActivity(intent);
    }

    public void goResults(View view) {
        getValues();
        calculateResult();
        saveToDatabase();
        Intent intent = new Intent(this, ResultsActivity.class);
        intent.putExtra("sourceActivity", "bmi");
        intent.putExtra("phone", phone);
        intent.putExtra("info", info);
        startActivity(intent);
    }
    public void getValues(){
        EditText iptHeight=findViewById(R.id.iptHeight);
        height=Integer.valueOf(iptHeight.getText().toString());
        EditText iptWeight=findViewById(R.id.iptWeight);
        weight=Integer.valueOf(iptWeight.getText().toString());
        EditText iptPhone=findViewById(R.id.iptPhone);
        phone=Integer.valueOf(iptPhone.getText().toString());
    }
    public void calculateResult(){
        bmi=weight/height/height*10000;
        if(bmi>30)
            diagnosis="obese";
        else if(bmi>25)
            diagnosis="overweight";
        else if(bmi>18.5)
            diagnosis="normal";
        else
            diagnosis="underweight";
        info= String.format("bmi test: %n height-%s%n weight-%s%n bmi-%s%n diagnosis-%s",height,weight,bmi,diagnosis);
    }
    public void saveToDatabase(){
        DatabaseManager db= new DatabaseManager(this);
        String fields[] = {"bmi_id", "height", "weight", "diagnosis"};
        String record[] = {"", Float.toString(height), Float.toString(weight), diagnosis};
        ContentValues values = new ContentValues();
        db.addRecord(values, "tbl_bmi", fields, record);
    }
}
