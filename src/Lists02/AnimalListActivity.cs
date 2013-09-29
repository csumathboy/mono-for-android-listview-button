using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Android.Content;

namespace ListviewButton
{
	[Activity(Label = "Animal List", MainLauncher = true)]
	public class AnimalListActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			
			this.ListAdapter = new AnimalListAdapter (this,
			                                         new List<Animal> () {
				new Animal() { Name = "Elephant", 
						Description = "Big and Gray, but what the hey", 
						Image = Resource.Drawable.Elephant },
				new Animal() { Name = "Chinchilla", 
						Description = "Little people of the andes", 
						Image = Resource.Drawable.Chinchilla },
				new Animal() { Name = "Lion", 
						Description = "Cowardly lion, anyone?", 
						Image = Resource.Drawable.Lion },
				new Animal() { Name = "Skunk", 
						Description = "Ello, baby. I am ze locksmith...",
						Image = Resource.Drawable.Skunk }
			});
			
		}
		protected override void OnListItemClick (ListView l, View v, int position, long id)
		{
			Intent intent = new Intent (this, typeof(DetailActivity)); 
			StartActivity (intent);
		}
	}
}
