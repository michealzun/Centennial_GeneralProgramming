package yueyang.yueyangsun_comp304lab1_assignment1;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class FirstActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_first);
    }

    protected void button_click(View v){
        EditText edit=findViewById(R.id.editText);
        Intent nextPage= new Intent(FirstActivity.this,SecondActivity.class);
        nextPage.putExtra("userInput",edit.getText().toString());
        startActivity(nextPage);
    }
}
