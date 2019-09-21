package sun.yueyangsun_comp304_assignment4;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class OptionAdminActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_option_admin);
    }
    public void offers(View v){
        Intent in=new Intent(OptionAdminActivity.this ,AllOfferActivity.class);
        startActivity(in);
    }
    public void delete(View v){
        Intent in=new Intent(OptionAdminActivity.this ,DeleteSeekerActivity.class);
        startActivity(in);
    }
    public void editOffers(View v){
        Intent in=new Intent(OptionAdminActivity.this ,NewOfferActivity.class);
        startActivity(in);
    }
    public void seeker(View v){
        Intent in=new Intent(OptionAdminActivity.this ,AllSeekerActivity.class);
        startActivity(in);
    }
}
