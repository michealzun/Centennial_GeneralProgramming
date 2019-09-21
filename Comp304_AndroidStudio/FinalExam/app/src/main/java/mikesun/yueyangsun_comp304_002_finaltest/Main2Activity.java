package mikesun.yueyangsun_comp304_002_finaltest;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.webkit.WebView;

public class Main2Activity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);

        WebView wv=findViewById(R.id.wv);
        wv.loadUrl("https://www.ford.ca/cars/fusion/");
    }
}
