package mike.healthapp;

import android.app.Service;
import android.content.Intent;
import android.media.MediaPlayer;
import android.os.IBinder;
import android.widget.Toast;

public class Sound extends Service {
    MediaPlayer mp;
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        mp = MediaPlayer.create(this,R.raw.beat);
        mp.setLooping(true);
        mp.start();
        return START_STICKY;
    }
    @Override
    public void onDestroy() {
        super.onDestroy();
        mp.stop();
    }
}
