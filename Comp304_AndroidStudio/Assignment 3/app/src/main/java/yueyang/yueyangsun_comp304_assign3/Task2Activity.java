package yueyang.yueyangsun_comp304_assign3;

import android.graphics.drawable.AnimationDrawable;
import android.graphics.drawable.BitmapDrawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

public class Task2Activity extends AppCompatActivity {
    AnimationDrawable anime;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task2);

        ImageView image= findViewById(R.id.imageView);
        anime= new AnimationDrawable();
        anime.setOneShot(false);
        anime.addFrame(getResources().getDrawable(R.drawable.frame0),50);
        anime.addFrame(getResources().getDrawable(R.drawable.frame1),50);
        anime.addFrame(getResources().getDrawable(R.drawable.frame2),50);
        anime.addFrame(getResources().getDrawable(R.drawable.frame3),50);
        anime.addFrame(getResources().getDrawable(R.drawable.frame4),50);
        anime.addFrame(getResources().getDrawable(R.drawable.frame5),50);
        anime.addFrame(getResources().getDrawable(R.drawable.frame6),50);
        anime.addFrame(getResources().getDrawable(R.drawable.frame7),50);
        image.setBackground(anime);
        anime.setVisible(true,true);
        anime.start();
    }
    public void start(View v){
        anime.start();
    }
    public void stop(View v){
        anime.stop();
    }
}
