package mikesun.yueyangsun_comp304_002_finaltest;

import android.content.ContentValues;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

import java.net.URL;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    CarManager db;
    String table="tb_Car";
    String tableData = "CREATE TABLE tb_Car (manufacturerID INTEGER PRIMARY KEY AUTOINCREMENT , brandName TEXT, model TEXT, year INTEGER, price double);";
    RadioButton rb1;
    RadioButton rb2;
    RadioButton rb3;
    TextView tx;
    WebView wv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        RadioGroup rGroup = (RadioGroup)findViewById(R.id.rGroup);
        rb1= findViewById(R.id.rb1);
        rb2= findViewById(R.id.rb2);
        rb3= findViewById(R.id.rb3);
        tx=findViewById(R.id.tx);
        rGroup.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                selectCar();
            }
           });

        try {
            db = new CarManager(this);
            db.dbInitialize(table, tableData);
        }
        catch(Exception e){}
    }

    public void AddCarInventory(View v) throws Exception {
        String record1[] = {"100", "GeosGarage", "k2", "2010", "10000"};
        String record2[] = {"234", "TheRaceShop", "landrover", "2015", "50000"};
        String record3[] = {"567", "Tuckers", "customTruck", "2010", "30000"};
        addCar(record1);
        addCar(record2);
        addCar(record3);
    }

    void addCar(String[] info){
        String offerFields[] = {"manufacturerID", "brandName", "model", "year", "price"};
        String record1[] = {info[0], info[1], info[2], info[3], info[4]};
        ContentValues values = new ContentValues();
        for (int i = 1; i < record1.length; i++)
            values.put(offerFields[i], record1[i]);
        try {
            db.insertRecord(values);
        }catch (Exception exx){tx.setText("no");}
    }

    void selectCar(){
        int id=0;

        if(rb1.isChecked()){
            id=100;
        }
        else if(rb2.isChecked()){
            id=234;
        }
        else if(rb3.isChecked()){
            id=567;
        }

        try{
        CarManager db = new CarManager(this);
        Car car = db.getCarById(id,"manufacturerID");
        String message= String.format("brand: %s%nmodel: %s%nyear: %d%nprice: %f",car.brandName,car.model,car.year,car.price);
        tx.setText(message);}
        catch(Exception ex){}
    }

    public void WebView(View v){
        Intent intent=new Intent(MainActivity.this,Main2Activity.class);
        startActivity(intent);
    }

}
