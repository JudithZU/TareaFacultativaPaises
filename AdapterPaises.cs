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
    class AdapterPaises : BaseAdapter
    {
        Activity context;
        List<Pais> lista;

        public AdapterPaises(Activity context, List<Pais> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
            
                view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombrepais;
                view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = item.Codigo1;
                //view.FindViewById<TextView>(Android.Resource.Id.Text3).Text = item.Codigo2;
                //view.FindViewById<TextView>(Android.Resource.Id.Text4).Text = item.Nombrecapital;
                //view.FindViewById<TextView>(Android.Resource.Id.Text5).Text = item.Prefijo;
            return view;
        }
    }
}