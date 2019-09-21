package yueyang.yueyangsun_comp304_assign5;

import android.content.Intent;
import android.location.Address;
import android.location.Geocoder;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.CheckBox;
import android.widget.Spinner;

import java.io.IOException;
import java.util.Iterator;
import java.util.List;

public class LocationActivity extends AppCompatActivity {
    Spinner s;
    String shop;
    String location;
    Geocoder coder;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_location);
        coder = new Geocoder(getApplicationContext());
        s=findViewById(R.id.spinner);
        shop=getIntent().getStringExtra("showroom");
    }
    public void next(View v){
        location=s.getSelectedItem().toString();

        Intent intent = new Intent(LocationActivity.this,MapsActivity.class);
        intent.putExtra("showroom", shop);
        intent.putExtra("location", location);
        startActivity(intent);
    }
}
