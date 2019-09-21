package yueyang.yueyangsun_comp304_assign3;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.PorterDuff;
import android.graphics.Typeface;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TextView;

public class Task1Activity extends AppCompatActivity {
    ImageView imageView;

    //every time we draw a line we need a starting point and end point
    int startx = 10;
    int starty = 30;
    int endx=10;
    int endy=30;
    //for reference
    RadioGroup rg;
    TextView position;
    Spinner spinner;
    Paint paint;
    Bitmap bitmap;
    Canvas canvas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task1);


        rg=findViewById(R.id.radioGroup);
        position= findViewById(R.id.textViewPosition);
        spinner=findViewById(R.id.spinner);
        //set default paint, can be changed with on screen controls
        paint = new Paint();
        paint.setColor(Color.RED);
        paint.setStrokeWidth(20);
        //setting up the images
        bitmap = Bitmap.createBitmap( getWindowManager()
                .getDefaultDisplay().getWidth(),getWindowManager()
                .getDefaultDisplay().getHeight(), Bitmap.Config.ARGB_8888);
        canvas = new Canvas(bitmap);
        imageView = findViewById(R.id.drawView);
        imageView.setImageBitmap(bitmap);

        //for spinner
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parentView, View selectedItemView, int position, long id) {
                switch(position){
                    case 0:
                        paint.setStrokeWidth(20);
                        break;
                    case 1:
                        paint.setStrokeWidth(21);
                        break;
                    case 2:
                        paint.setStrokeWidth(22);
                        break;
                    case 3:
                        paint.setStrokeWidth(23);
                        break;
                    case 4:
                        paint.setStrokeWidth(24);
                        break;
                    case 5:
                        paint.setStrokeWidth(25);
                        break;
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> parentView) {
                // your code here
            }
        });
    }

    //for changing color
    public void colorChange(View v){
        switch (rg.getCheckedRadioButtonId()){
            case R.id.radioYellow:
                paint.setColor(Color.YELLOW);
                break;
            case R.id.radioRed:
                paint.setColor(Color.RED);
                break;
            case R.id.radioBlue:
                paint.setColor(Color.BLUE);
                break;
        }
    }
    //key presses
    public boolean onKeyDown(int keyCode, KeyEvent event)
    {
        switch(keyCode)
        {
            case KeyEvent.KEYCODE_DPAD_LEFT:
                move(-5,0);
                return true;

            case KeyEvent.KEYCODE_DPAD_DOWN:
                move(0,5);
                return true;

            case KeyEvent.KEYCODE_DPAD_UP:
                move(0,-5);
                return true;

            case KeyEvent.KEYCODE_DPAD_RIGHT:
                move(5,0);
                return true;

        }
        return false;
    }
    //on screen arrows
    public void arrowButton(View view)
    {
        switch(view.getId()) {
            case R.id.imageViewLeft:
                move(-10,0);
                break;
            case R.id.imageViewDown:
                move(0,10);
                break;
            case R.id.imageViewUp:
                move(0,-10);
                break;
            case R.id.imageViewRight:
                move(10,0);
                break;
            default:
                break;
        }
    }
    //for moving and drawing
    public void move(int deltaX, int deltaY){
        imageView.setFocusable(true);
        imageView.requestFocus();
        endx+=deltaX;
        endy+=deltaY;
        canvas.drawLine(startx, starty, endx, endy, paint);
        startx=endx;
        starty=endy;
        position.setText("x: "+ startx + "   y: " + starty);
        imageView.invalidate();
    }
    //clearing
    public void clear(View view)
    {
        canvas.drawColor(Color.TRANSPARENT, PorterDuff.Mode.CLEAR);
    }
    public void back(View view)
    {
        startActivity(new Intent(Task1Activity.this,MainActivity.class));
    }
}
