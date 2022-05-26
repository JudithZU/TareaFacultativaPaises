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
    [Activity(Label = "ActivityDetalleContinente")]
    public class ActivityDetalleContinente : Activity
    {
        Continente continente;
        TextView txtnombre, info;
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.detallecontinente);

            int id = Intent.GetIntExtra("id", 0);
            //recuperamos el continente
            continente = Global.Continentes.Where(x => x.Id == id).FirstOrDefault();

            txtnombre = FindViewById<TextView>(Resource.Id.textView1);
            info = FindViewById<TextView>(Resource.Id.textView2);
            vlista = FindViewById<ListView>(Resource.Id.listView1);

            txtnombre.Text = continente.Nombrecontinente;
            info.Text = "Lista de Paises con su codigo y prefijo";
            vlista.Adapter = new AdapterPaises(this, Global.Paises.Where(x => x.IdContinente == continente.Id).ToList());
        }
    }
}