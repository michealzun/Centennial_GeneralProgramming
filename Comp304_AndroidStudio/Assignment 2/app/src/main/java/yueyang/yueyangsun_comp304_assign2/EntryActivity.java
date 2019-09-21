package yueyang.yueyangsun_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class EntryActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_entry);
    }
    //for the button
    public void next(View v){
        Intent in=new Intent(EntryActivity.this,CuisineActivity.class);
        startActivity(in);
    }
}
