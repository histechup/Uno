#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaPlayerFailedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Playback.MediaPlayerError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlayerError MediaPlayerFailedEventArgs.Error is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  string ErrorMessage
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MediaPlayerFailedEventArgs.ErrorMessage is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::System.Exception ExtendedErrorCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception MediaPlayerFailedEventArgs.ExtendedErrorCode is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayerFailedEventArgs.Error.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayerFailedEventArgs.ExtendedErrorCode.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayerFailedEventArgs.ErrorMessage.get
	}
}