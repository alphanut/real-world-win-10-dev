﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Lesson4_LayoutDemos
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class RelativePanelDemo : Page
	{
		public RelativePanelDemo()
		{
			this.InitializeComponent();
			this.Loaded += RelativePanelDemo_Loaded;
		}

		private void RelativePanelDemo_Loaded(object sender, RoutedEventArgs e)
		{
			stack_bottom.SetValue(RelativePanel.BelowProperty, stack_left);
			stack_bottom.SetValue(RelativePanel.AlignLeftWithPanelProperty, true);
			stack_bottom.SetValue(RelativePanel.AlignRightWithPanelProperty, true);

			
		}
	}




}
