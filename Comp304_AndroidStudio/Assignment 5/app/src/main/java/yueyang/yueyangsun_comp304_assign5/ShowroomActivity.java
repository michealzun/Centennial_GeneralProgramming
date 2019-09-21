package yueyang.yueyangsun_comp304_assign5;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Spinner;

public class ShowroomActivity extends AppCompatActivity {
    Spinner sp;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_showroom);
        sp= findViewById(R.id.spShowroom);
    }

    public void next(View v){
        Intent intent = new Intent(ShowroomActivity.this, LocationActivity.class);
        intent.putExtra("showroom", sp.getSelectedItem().toString());
        startActivity(intent);
    }
}
