using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPaises
{
    [Activity(Label = "ActivityListaContinentes", MainLauncher = true)]
    public class ActivityListaContinentes : Activity
    {
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListaContinente);

            //vinculamos la fuente de los datos con el listview mediante el adaptercontinente
            vlista = FindViewById<ListView>(Resource.Id.listView1);
            vlista.Adapter = new AdapterContinentes(this, Global.Continentes);

            vlista.ItemClick += Vlista_ItemClick;
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetalleContinente));

            //obtener el id de los continentes seleccionados
            Continente continente = Global.Continentes[e.Position];

            i.PutExtra("id", continente.Id);

            StartActivity(i);
        }
    }
}