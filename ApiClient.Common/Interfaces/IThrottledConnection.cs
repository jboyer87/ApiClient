namespace ApiClient.Common
{
	/// <summary>
	/// The <c>IThrottledConnection</c> interface defines the public interface for throttled 
	/// connections.
	/// </summary>
	public interface IThrottledConnection
	{
		/// <summary>
		/// Throttles the connection.
		/// </summary>
		public void Throttle();
	}
}
