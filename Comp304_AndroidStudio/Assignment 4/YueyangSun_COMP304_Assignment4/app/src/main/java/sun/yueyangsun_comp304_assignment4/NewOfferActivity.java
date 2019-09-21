package sun.yueyangsun_comp304_assignment4;

import android.content.ContentValues;
import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.EditText;

public class NewOfferActivity extends AppCompatActivity {

    DatabaseManager db;
    EditText[] eTexts=new EditText[6];
    String[] offerRecord=new String[6];
    String offerFields[] = {"offer_id", "interview_date", "interview_status", "company", "position", "recruitment_status"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_new_offer);
        db = new DatabaseManager(this);
        eTexts[0] = findViewById(R.id.editText18);
        eTexts[1] = findViewById(R.id.editText3);
        eTexts[2] = findViewById(R.id.editText15);
        eTexts[3] = findViewById(R.id.editText16);
        eTexts[4] = findViewById(R.id.editText17);
        eTexts[5] = findViewById(R.id.editText2);
    }

    void getTexts(){

        for (int i=0;i < 6;i++) {
            offerRecord[i]=eTexts[i].getText().toString();
        }
    }

    public void newOffer(View v){
        getTexts();
        ContentValues values = new ContentValues();
        db.addRecord(values, "tbl_offer", offerFields, offerRecord);

        Intent in=new Intent(NewOfferActivity.this,OptionAdminActivity.class);
        startActivity(in);
    }
    public void editOffer(View v){
        getTexts();
        ContentValues values = new ContentValues();
        db.updateRecord(values, "tbl_offer", offerFields,offerRecord);

        Intent in=new Intent(NewOfferActivity.this,OptionAdminActivity.class);
        startActivity(in);
    }

}
