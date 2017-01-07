using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SommeWhat.ViewModels;

namespace SommeWhat
{
	public class ViewModelLocator
	{
		static ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			SimpleIoc.Default.Register<RootViewModel>();
		}

		/// <summary>
		/// Gets the Main property.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
			"CA1822:MarkMembersAsStatic",
			Justification = "This non-static member is needed for data binding purposes.")]
		public RootViewModel RootViewModel
		{
			get
			{
				return ServiceLocator.Current.GetInstance<RootViewModel>();
			}
		}
	}
}
