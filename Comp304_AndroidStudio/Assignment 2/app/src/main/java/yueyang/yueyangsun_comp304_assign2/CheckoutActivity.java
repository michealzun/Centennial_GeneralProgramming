package yueyang.yueyangsun_comp304_assign2;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class CheckoutActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_checkout);
        //display info
        TextView tv=findViewById(R.id.textView2);
        tv.setText(getIntent().getStringExtra("info"));
    }
}
