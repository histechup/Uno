#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDefaultAudioDeviceChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string Id
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Media.Devices.AudioDeviceRole Role
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs.Id.get
		// Forced skipping of method Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs.Role.get
	}
}
