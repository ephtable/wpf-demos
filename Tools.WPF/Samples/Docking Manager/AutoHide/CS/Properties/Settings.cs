#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace WindowsApplication1.Properties
{
	public partial class Settings : System.Configuration.ApplicationSettingsBase
	{
		private static Settings m_Value;

		private static object m_SyncObject = new object();

		public static Settings Value
		{
			get
			{
				if ((Settings.m_Value == null))
				{
					System.Threading.Monitor.Enter(Settings.m_SyncObject);
					if ((Settings.m_Value == null))
					{
						try
						{
							Settings.m_Value = new Settings();
						}
						finally
						{
							System.Threading.Monitor.Exit(Settings.m_SyncObject);
						}
					}
				}
				return Settings.m_Value;
			}
		}
	}
}