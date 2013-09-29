
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListviewButton
{
	[Activity (Label = "BuyActivity")]			
	public class BuyActivity : ListActivity
	{
		string [] items;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			
			items=new string[] {
				"item one",
				"tow item",
				"item three",
				"four item",
				"item five"
			};

			this.ListAdapter=new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1,items);
		}
	}
}

