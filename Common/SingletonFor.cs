using System;

namespace Common
{
    public static class SingletonFor<T>
		where T : class, new()
	{
		static Lazy<T> _instance = new Lazy<T>(() => new T(), true);
		public static T Instance => _instance.Value;
	}
}
