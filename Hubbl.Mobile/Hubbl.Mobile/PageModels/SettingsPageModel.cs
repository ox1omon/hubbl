﻿using FreshMvvm;
using PropertyChanged;

namespace Hubbl.Mobile.PageModels
{
	[ImplementPropertyChanged]
	public class SettingsPageModel : FreshBasePageModel
	{
		public SettingsPageModel(){}
		public string Username { get; set; }

	}
}
