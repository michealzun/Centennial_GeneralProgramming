package yueyang.yueyangsun_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.CheckBox;
import android.widget.TextView;
import android.widget.Toast;

public class FoodActivity extends AppCompatActivity {
    String cuisineChoice;
    boolean selectedRes;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_food);
        selectedRes=false;
        //for passing values with intents
        cuisineChoice =getIntent().getStringExtra("cuisine");
    }
    //for the restaurant options
    public boolean onCreateOptionsMenu(Menu menu){
        switch(cuisineChoice){
            case("local"):
                getMenuInflater().inflate(R.menu.local,menu);
                break;
            case("english"):
                getMenuInflater().inflate(R.menu.english,menu);
                break;
            default:
                getMenuInflater().inflate(R.menu.chinese,menu);
                break;
        }

        return true;
    }
    //display the corresponding food list
    public boolean onOptionsItemSelected(MenuItem item){
        CheckBox cb1=findViewById(R.id.checkBox1);
        CheckBox cb2=findViewById(R.id.checkBox2);
        switch(cuisineChoice){
            case("local"):
                switch(item.getItemId()){
                    case R.id.item1:
                        cb1.setText(getResources().getStringArray(R.array.StakeHouse)[0]);
                        cb2.setText(getResources().getStringArray(R.array.StakeHouse)[1]);
                        selectedRes=true;
                        break;
                    case R.id.item2:
                        cb1.setText(getResources().getStringArray(R.array.SuperBurger)[0]);
                        cb2.setText(getResources().getStringArray(R.array.SuperBurger)[1]);
                        selectedRes=true;
                        break;
                }
                break;
            case("english"):
                switch(item.getItemId()){
                    case R.id.item1:
                        cb1.setText(getResources().getStringArray(R.array.AbbotCastle)[0]);
                        cb2.setText(getResources().getStringArray(R.array.AbbotCastle)[1]);
                        selectedRes=true;
                        break;
                    case R.id.item2:
                        cb1.setText(getResources().getStringArray(R.array.TheFireplace)[0]);
                        cb2.setText(getResources().getStringArray(R.array.TheFireplace)[1]);
                        selectedRes=true;
                        break;
                }
                break;
            default:
                switch(item.getItemId()){
                    case R.id.item1:
                        cb1.setText(getResources().getStringArray(R.array.WongsBento)[0]);
                        cb2.setText(getResources().getStringArray(R.array.WongsBento)[1]);
                        selectedRes=true;
                        break;
                    case R.id.item2:
                        cb1.setText(getResources().getStringArray(R.array.PheonixNight)[0]);
                        cb2.setText(getResources().getStringArray(R.array.PheonixNight)[1]);
                        selectedRes=true;
                        break;
                }
                break;
        }
        return true;
    }

    //previous button
    public void previous(View v){
        Intent in=new Intent(FoodActivity.this,CuisineActivity.class);
        startActivity(in);
    }
    //next button
    public void next(View v){
        CheckBox cb1=findViewById(R.id.checkBox1);
        CheckBox cb2=findViewById(R.id.checkBox2);
        //check if any option selected
        if((cb1.isChecked()||cb2.isChecked())&&selectedRes){
            //food order
            String food="";
            if(cb1.isChecked())
                food+=cb1.getText() + "  ";
            if(cb2.isChecked())
                food+=cb2.getText() + "  ";
            //set intent
            Intent in=new Intent(FoodActivity.this,CustomerActivity.class);
            in.putExtra("cuisine",cuisineChoice);
            in.putExtra("order",food);
            startActivity(in);
        }
        //in case if nothing is selected
        else{
            TextView tv =findViewById(R.id.textView);
            tv.setText(getResources().getString(R.string.noselect));
        }
    }
}
