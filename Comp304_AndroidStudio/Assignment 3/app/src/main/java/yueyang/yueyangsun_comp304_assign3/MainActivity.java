package yueyang.yueyangsun_comp304_assign3;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Spinner;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final ListView lv=findViewById(R.id.listView);
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener(){
            @Override
            public void onItemClick(AdapterView<?> arg0, View arg1, int pos, long arg3) {
                Intent in;
                switch(pos){
                    case 0:
                        in=new Intent(MainActivity.this,Task1Activity.class);
                        break;
                    case 1:
                        in=new Intent(MainActivity.this,Task2Activity.class);
                        break;
                    default:
                        in=new Intent(MainActivity.this,Task3Activity.class);
                        break;
                }
                startActivity(in);
            }
        });
    }
}
