package sun.yueyangsun_comp304_assignment4;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class DeleteSeekerActivity extends AppCompatActivity {
    EditText edit;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_delete_seeker);
        edit=findViewById(R.id.editText);
    }
    public void deleteSeeker(View v){
        DatabaseManager db = new DatabaseManager(this);
        db.deleteRecord("tbl_seeker","seeker_id",edit.toString());

        Intent in=new Intent(DeleteSeekerActivity.this ,OptionAdminActivity.class);
        startActivity(in);
    }
}
