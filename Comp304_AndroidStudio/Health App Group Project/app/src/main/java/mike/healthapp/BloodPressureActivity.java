package mike.healthapp;

import android.content.ContentValues;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;


public class BloodPressureActivity extends AppCompatActivity {

    int age;
    String sex;
    int systolic;
    int diastolic;
    int phone;
    String diagnosis;
    String info;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_blood_pressure);
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
        intent.putExtra("sourceActivity", "bloodpressure");
        intent.putExtra("phone", phone);
        intent.putExtra("info", info);
        startActivity(intent);
    }

    public void getValues(){
        EditText iptAge=findViewById(R.id.iptAge);
        age=Integer.valueOf(iptAge.getText().toString());
        RadioButton rbMale=findViewById(R.id.rbM);
        if(rbMale.isChecked())
            sex="male";
        else
            sex="female";
        EditText iptSys=findViewById(R.id.iptSystolic);
        systolic=Integer.valueOf(iptSys.getText().toString());
        EditText iptDia=findViewById(R.id.iptDiastolic);
        diastolic=Integer.valueOf(iptDia.getText().toString());
        EditText iptPhone=findViewById(R.id.iptPhone);
        phone=Integer.valueOf(iptPhone.getText().toString());
    }
    public void calculateResult(){
        if(age>10) {
            if (systolic > 180 || diastolic > 110)
                diagnosis= "Stage 4 Hypertension";
            else if (systolic > 160 || diastolic > 100)
                diagnosis= "Stage 3 Hypertension";
            else if (systolic > 140 || diastolic > 90)
                diagnosis= "Stage 2 Hypertension";
            else if (systolic > 130 || diastolic > 85)
                diagnosis= "Stage 1 Hypertension";
            else if (systolic > 120 || diastolic > 80)
                diagnosis= "Normal-high";
            else if (systolic > 110 || diastolic > 75)
                diagnosis= "Normal";
            else if (systolic > 90 || diastolic > 60)
                diagnosis= "Normal-low";
            else if (systolic > 60 || diastolic > 40)
                diagnosis= "Low";
            else if (systolic > 50 || diastolic > 33)
                diagnosis= "Too low";
            else
                diagnosis= "Dangerously low";
        }else if(age>6){
            if(sex=="male"){
                if (systolic > 130 || diastolic > 90)
                    diagnosis= "High";
                else if (systolic > 92 || diastolic > 53)
                    diagnosis= "Normal";
                else
                    diagnosis="Low";
            }else{
                if (systolic > 129 || diastolic > 88)
                    diagnosis= "High";
                else if (systolic > 93 || diastolic > 55)
                    diagnosis= "Normal";
                else
                    diagnosis="Low";
            }
        }else if(age>3){
            if(sex=="male"){
                if (systolic > 128 || diastolic > 84)
                    diagnosis= "High";
                else if (systolic > 88 || diastolic > 47)
                    diagnosis= "Normal";
                else
                    diagnosis="Low";
            }else{
                if (systolic > 122 || diastolic > 83)
                    diagnosis= "High";
                else if (systolic > 88 || diastolic > 50)
                    diagnosis= "Normal";
                else
                    diagnosis="Low";
            }
        }else{
            if(sex=="male"){
                if (systolic > 120 || diastolic > 75)
                    diagnosis= "High";
                else if (systolic > 80 || diastolic > 34)
                    diagnosis= "Normal";
                else
                    diagnosis="Low";
            }else{
                if (systolic > 117 || diastolic > 76)
                    diagnosis= "High";
                else if (systolic > 83 || diastolic > 38)
                    diagnosis= "Normal";
                else
                    diagnosis="Low";
            }
        }
        info= String.format("blood pressure test: %n age-%d%n sex-%s%n systolic-%d%n diastolic-%d%n diagnosis-%s",age,sex,systolic,diastolic,diagnosis);
    }
    public void saveToDatabase(){
            DatabaseManager db= new DatabaseManager(this);
            String fields[] = {"bp_id", "age", "sex", "systolic", "diastolic", "diagnosis"};
            String record[] = {"", Integer.toString(age), sex, Integer.toString(systolic), Integer.toString(diastolic), diagnosis};
            ContentValues values = new ContentValues();
            db.addRecord(values, "tbl_bloodpressure", fields, record);
    }
}
