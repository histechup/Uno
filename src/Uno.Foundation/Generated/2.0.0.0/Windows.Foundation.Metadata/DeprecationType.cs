#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Metadata
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum DeprecationType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Deprecate,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Remove,
		#endif
	}
	#endif
}
