#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IStorageFilePropertiesWithAvailability 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool IsAvailable
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Storage.IStorageFilePropertiesWithAvailability.IsAvailable.get
	}
}
