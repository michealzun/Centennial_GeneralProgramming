package yueyang.yueyangsun_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class CustomerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customer);
    }

    //previous button
    public void previous(View v){
        Intent in=new Intent(CustomerActivity.this,FoodActivity.class);
        in.putExtra("cuisine",getIntent().getStringExtra("cuisine"));
        startActivity(in);
    }
    //next button
    public void next(View v){
        TextView[] userInput=new TextView[6];
        userInput[0]=findViewById(R.id.userName);
        userInput[1]=findViewById(R.id.userAddress);
        userInput[2]=findViewById(R.id.userCard);
        userInput[3]=findViewById(R.id.userExpire);
        userInput[4]=findViewById(R.id.userFavRest);
        userInput[5]=findViewById(R.id.userFavFood);
        boolean noEmptyString=true;
        String[] inputString=new String[6];
        for (int i=0; i<6; i++) {
            if(userInput[i].getText().toString().isEmpty())
            {
                noEmptyString=false;
            }
            else
            {
                inputString[i]=userInput[i].getText().toString();
            }
        }

        //check for fields filled
        if(noEmptyString){
        String info=String.format("Your order have been complete %norder item: %s %nname: %s %naddress: %s %ncard number: %s %nexpire date: %s %nfavorite restaurant: %s %nfavorite food: %s %n",
                getIntent().getStringExtra("order"),
                inputString[0],inputString[1],inputString[2],inputString[3],inputString[4],inputString[5]);
        Intent in=new Intent(CustomerActivity.this,CheckoutActivity.class);
        in.putExtra("info",info);
        startActivity(in);
        }
        //if not filled
        else{
            TextView tv=findViewById(R.id.warning);
            tv.setText(getResources().getString(R.string.warning));
        }
    }
}
