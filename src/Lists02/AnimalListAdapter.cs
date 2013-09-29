using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.Content;

namespace ListviewButton
{
	public class AnimalListAdapter : BaseAdapter<Animal>
	{
		Activity context;
		public List<Animal> Animals;

		public AnimalListAdapter (Activity context, List<Animal> animals)
			: base()
		{
			this.context = context;
			this.Animals = animals;
		}

		public override int Count {
			get { return this.Animals.Count; }
		}

		public override Animal this [int position] {
			get { return this.Animals [position]; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = this.Animals [position];
			var view = convertView;
			//chinese:如果复用item,那么if只会加载第一个item的时候执行
			//English: reuse item, only give one click on button click
			if (convertView == null || !(convertView is LinearLayout)) {
				view = context.LayoutInflater.Inflate (Resource.Layout.AnimalItem, parent, false);
			    Button btn = view.FindViewById<Button> (Resource.Id.btn_Take);
				//chinese:使用Tag来记录当前button对应的position
				//English:use Tag to record position
			    btn.Tag = position;
				btn.Click += delegate { 
					//chinese:点击的时候先获取当前点击的是那个button
					//English:get the position 
					int pos=Convert.ToInt32(btn.Tag);
					Animal anml=this.Animals [pos];
					//chinese:启动新的activity
					//English:start activity 
					Intent intent = new Intent (this.context, typeof(BuyActivity)); 
					intent.PutExtra("name",anml.Name);
					context.StartActivity (intent);
				};
			} else {
				Button btn = view.FindViewById<Button> (Resource.Id.btn_Take);
				//chinese:使用Tag来记录当前button对应的position
				//English:use Tag to record position
				btn.Tag = position;
			}
			var imageItem = view.FindViewById (Resource.Id.imageItem) as ImageView;
			var textTop = view.FindViewById (Resource.Id.textTop) as TextView;
			var textBottom = view.FindViewById (Resource.Id.textBottom) as TextView;
			imageItem.SetImageResource (item.Image);
			textTop.SetText (item.Name, TextView.BufferType.Normal);
			textBottom.SetText (item.Description, TextView.BufferType.Normal);
			return view;
		}
		public override long GetItemId (int position)
		{
			return position;
		}
	}
}
