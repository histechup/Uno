#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum CommonFileQuery 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DefaultQuery,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		OrderByName,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		OrderByTitle,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		OrderByMusicProperties,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		OrderBySearchRank,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		OrderByDate,
		#endif
	}
	#endif
}