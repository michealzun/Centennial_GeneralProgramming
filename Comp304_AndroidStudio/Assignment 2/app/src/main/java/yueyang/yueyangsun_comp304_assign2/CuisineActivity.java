package yueyang.yueyangsun_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;
import android.widget.RadioGroup;

public class CuisineActivity extends AppCompatActivity {
    String cuisine;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cuisine);

        //for selection
        final RadioGroup rg=findViewById(R.id.radioGroup);
        final RadioButton radioButton1=findViewById(R.id.radioButton1);
        final RadioButton radioButton2=findViewById(R.id.radioButton2);
        final RadioButton radioButton3=findViewById(R.id.radioButton3);
        //go to next page when selected
        rg.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                    if(radioButton1.isChecked()){
                        Intent in=new Intent(CuisineActivity.this,FoodActivity.class);
                        in.putExtra("cuisine","local");
                        startActivity(in);
                    }
                    else if(radioButton2.isChecked()){
                        Intent in=new Intent(CuisineActivity.this,FoodActivity.class);
                        in.putExtra("cuisine","english");
                        startActivity(in);
                    }
                    else if(radioButton3.isChecked()){
                        Intent in=new Intent(CuisineActivity.this,FoodActivity.class);
                        in.putExtra("cuisine","chinese");
                        startActivity(in);
                    }

            }
        });
    }
}
