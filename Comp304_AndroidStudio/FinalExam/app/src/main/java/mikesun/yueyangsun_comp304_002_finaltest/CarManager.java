package mikesun.yueyangsun_comp304_002_finaltest;


import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;


public class CarManager extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "VehiclesDB";
    private static final int DATABASE_VERSION = 1;

    private static String tableName;
    private static String tableCreatorString;

    public CarManager(Context context)
    {
        super(context, DATABASE_NAME , null, DATABASE_VERSION);
    }

    // Called when the database is created for the first time.
    @Override
    public void onCreate(SQLiteDatabase db) {
        //create the table
        db.execSQL(tableCreatorString);
    }

    // Called when the database needs to be upgraded.
    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        //drop table if existed
        db.execSQL("DROP TABLE IF EXISTS " + tableName);
        //recreate the table
        onCreate(db);
    }



    public void dbInitialize(String tableName, String tableCreatorString)
    {
        this.tableName=tableName;
        this.tableCreatorString=tableCreatorString;
    }


    public boolean insertRecord (ContentValues values) throws Exception {
        SQLiteDatabase db = this.getWritableDatabase();
        // Insert the record
        long nr= db.insert(tableName, null, values);
        //close database connection
        db.close();
        return nr> -1;
    }

    // This method returns an object which holds the table row with the given name
    public Car getCarById(Object id, String fieldName) throws Exception{
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor =  db.rawQuery( "select * from " + tableName + " where "+ fieldName + "='"+String.valueOf(id)+"'", null );
        //create a new object
        Car car = new Car();
        //if row exists
        if (cursor.moveToFirst()) {
            //move to first row
            cursor.moveToFirst();
            //initialize the instance variables of object
            car.setBrandName(cursor.getString(0));
            car.setModel(cursor.getString(1));
            car.setYear(cursor.getInt(2));
            car.setPrice(cursor.getDouble(3));
            cursor.close();

        } else {
            car = null;
        }
        db.close();
        return car;

    }

}
