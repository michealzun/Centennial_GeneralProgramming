package yueyang.yueyangsun_comp304_assign5;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.Drawable;
import android.location.Address;
import android.location.Geocoder;
import android.net.Uri;
import android.support.v4.app.FragmentActivity;
import android.os.Bundle;
import android.view.View;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;

import java.util.Iterator;
import java.util.List;

public class MapsActivity extends FragmentActivity implements OnMapReadyCallback {

    private GoogleMap mMap;
    String shop;
    String location;
    Geocoder coder;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_maps);
        // Obtain the SupportMapFragment and get notified when the map is ready to be used.
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager().findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);

        shop=getIntent().getStringExtra("showroom");
        location=getIntent().getStringExtra("location");
        coder= new Geocoder(getApplicationContext());
    }


    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;
        addLocations();
    }

    private void addLocations(){
        try {
            List<Address> geocodeResults = coder.getFromLocationName("toronto "+ location + shop, 3);
            Iterator<Address> locations = geocodeResults.iterator();
            LatLng latlng=new LatLng(43.6426, -79.3871);

            while (locations.hasNext()) {
                Address loc = locations.next();
                latlng=new LatLng(loc.getLatitude(),loc.getLongitude());
                String locInfo = String.format("%s %s %s", loc.getLocality(), loc.getFeatureName(), loc.getThoroughfare());

                Marker m= mMap.addMarker(new MarkerOptions().position(latlng).title(shop).snippet(locInfo));
                }
            mMap.moveCamera(CameraUpdateFactory.newLatLngZoom(latlng, 10));
            mMap.animateCamera(CameraUpdateFactory.zoomTo(10), 1000, null);
        }catch(Exception e){}
    }
}
