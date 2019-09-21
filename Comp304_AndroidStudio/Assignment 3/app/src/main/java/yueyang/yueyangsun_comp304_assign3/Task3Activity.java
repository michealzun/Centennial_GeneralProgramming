package yueyang.yueyangsun_comp304_assign3;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.Typeface;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;

public class Task3Activity extends AppCompatActivity {

    ImageView moon;
    ImageView earth;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task3);

        Bitmap bitmap = Bitmap.createBitmap((int) getWindowManager()
                .getDefaultDisplay().getWidth(), (int) getWindowManager()
                .getDefaultDisplay().getHeight(), Bitmap.Config.ARGB_8888);
        moon = findViewById(R.id.TweenImage);
        moon.setImageResource(R.drawable.moon);
        moon.setVisibility(View.VISIBLE);
        moon.setImageBitmap(bitmap);


        earth= findViewById(R.id.TweenImage2);
        earth.setImageResource(R.drawable.earth);
        earth.setVisibility(View.VISIBLE);
        earth.setImageBitmap(bitmap);
    }
    public void start(View view)
    {

        Animation animeTrans=AnimationUtils.loadAnimation(getApplicationContext(), R.anim.translate);
        moon.startAnimation(animeTrans);
        Animation animeRotate =  AnimationUtils.loadAnimation(getApplicationContext(), R.anim.rotate);
        earth.startAnimation(animeRotate);

    }

    public void stop(View view){
        moon.clearAnimation();
        earth.clearAnimation();
    }

}
