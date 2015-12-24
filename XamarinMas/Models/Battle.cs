using System;
using System.Collections.Generic;
using System.Dynamic;
using Xamarin.Forms;

namespace XamarinMas.Model
{
	/*
	 * "Battle: this describes a subset of a campaign that will have specific military goals and geographic objectives."
	 */
	public class Battle
	{
		
		public Battle ()
		{
		}

		public String Title { get; set; }

		public List<Strike> Strikes { get; set; }

	}
}

