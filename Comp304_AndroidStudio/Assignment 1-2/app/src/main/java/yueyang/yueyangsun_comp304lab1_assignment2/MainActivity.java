package yueyang.yueyangsun_comp304lab1_assignment2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    protected void button_click(View v){
        EditText edit1=findViewById(R.id.editText7);
        EditText edit2=findViewById(R.id.editText5);
        EditText edit3=findViewById(R.id.editText6);
        EditText edit4=findViewById(R.id.editText8);
        Intent nextPage= new Intent(MainActivity.this,SubActivity.class);
        nextPage.putExtra("name",edit1.getText().toString());
        nextPage.putExtra("program",edit2.getText().toString());
        nextPage.putExtra("semester",edit3.getText().toString());
        nextPage.putExtra("course",edit4.getText().toString());
        startActivity(nextPage);
    }
}
