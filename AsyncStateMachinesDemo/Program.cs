namespace AsyncStateMachinesDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var a = await GetIpAddress();
            Console.WriteLine(a.Replace(".", ""));
        }

        // Gets the ip address from https://api.my-ip.io/ip and prints it to the console
        private static async Task<string> GetIpAddress()
        {
            using var client = new HttpClient();
            var response = await client.GetAsync("https://api.my-ip.io/ip");
            var ipAddress = await response.Content.ReadAsStringAsync();
            Console.Out.WriteLine(ipAddress);
            return ipAddress;
        }
    }
}


// Wont be compiled, but we get syntax highliting :)
#if OUTPUT
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncStateMachinesDemo
{
	[NullableContext(1)]
	[Nullable(0)]
	internal class Program
	{
		private static async Task Main(string[] args)
		{
			string text = await Program.GetIpAddress();
			string a = text;
			text = null;
			Console.WriteLine(a.Replace(".", ""));
		}

		private static async Task<string> GetIpAddress()
		{
			string text2;
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage httpResponseMessage = await client.GetAsync("https://api.my-ip.io/ip");
				HttpResponseMessage response = httpResponseMessage;
				httpResponseMessage = null;
				string text = await response.Content.ReadAsStringAsync();
				string ipAddress = text;
				text = null;
				Console.Out.WriteLine(ipAddress);
				text2 = ipAddress;
			}
			return text2;
		}

		public Program()
		{
		}

		[DebuggerStepThrough]
		private static void <Main>(string[] args)
		{
			Program.Main(args).GetAwaiter().GetResult();
		}

		[CompilerGenerated]
		private sealed class <GetIpAddress>d__1 : IAsyncStateMachine
		{
			public <GetIpAddress>d__1()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				string text;
				try
				{
					if (num > 1)
					{
						this.<client>5__1 = new HttpClient();
					}
					try
					{
						TaskAwaiter<string> awaiter;
						TaskAwaiter<HttpResponseMessage> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<string>);
								num = (this.<>1__state = -1);
								goto IL_115;
							}
							awaiter2 = this.<client>5__1.GetAsync("https://api.my-ip.io/ip").GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (this.<>1__state = 0);
								this.<>u__1 = awaiter2;
								Program.<GetIpAddress>d__1 <GetIpAddress>d__ = this;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Program.<GetIpAddress>d__1>(ref awaiter2, ref <GetIpAddress>d__);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<HttpResponseMessage>);
							num = (this.<>1__state = -1);
						}
						this.<>s__4 = awaiter2.GetResult();
						this.<response>5__2 = this.<>s__4;
						this.<>s__4 = null;
						awaiter = this.<response>5__2.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (this.<>1__state = 1);
							this.<>u__2 = awaiter;
							Program.<GetIpAddress>d__1 <GetIpAddress>d__ = this;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Program.<GetIpAddress>d__1>(ref awaiter, ref <GetIpAddress>d__);
							return;
						}
						IL_115:
						this.<>s__5 = awaiter.GetResult();
						this.<ipAddress>5__3 = this.<>s__5;
						this.<>s__5 = null;
						Console.Out.WriteLine(this.<ipAddress>5__3);
						text = this.<ipAddress>5__3;
					}
					finally
					{
						if (num < 0 && this.<client>5__1 != null)
						{
							((IDisposable)this.<client>5__1).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<client>5__1 = null;
					this.<response>5__2 = null;
					this.<ipAddress>5__3 = null;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<client>5__1 = null;
				this.<response>5__2 = null;
				this.<ipAddress>5__3 = null;
				this.<>t__builder.SetResult(text);
			}

			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			public int <>1__state;

			[Nullable(0)]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Nullable(0)]
			private HttpClient <client>5__1;

			[Nullable(0)]
			private HttpResponseMessage <response>5__2;

			[Nullable(0)]
			private string <ipAddress>5__3;

			[Nullable(0)]
			private HttpResponseMessage <>s__4;

			[Nullable(0)]
			private string <>s__5;

			[Nullable(new byte[] { 0, 1 })]
			private TaskAwaiter<HttpResponseMessage> <>u__1;

			[Nullable(new byte[] { 0, 1 })]
			private TaskAwaiter<string> <>u__2;
		}

		[CompilerGenerated]
		private sealed class <Main>d__0 : IAsyncStateMachine
		{
			public <Main>d__0()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = Program.GetIpAddress().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							Program.<Main>d__0 <Main>d__ = this;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Program.<Main>d__0>(ref awaiter, ref <Main>d__);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
					}
					this.<>s__2 = awaiter.GetResult();
					this.<a>5__1 = this.<>s__2;
					this.<>s__2 = null;
					Console.WriteLine(this.<a>5__1.Replace(".", ""));
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<a>5__1 = null;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<a>5__1 = null;
				this.<>t__builder.SetResult();
			}

			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			public int <>1__state;

			public AsyncTaskMethodBuilder <>t__builder;

			[Nullable(new byte[] { 0, 1 })]
			public string[] args;

			[Nullable(0)]
			private string <a>5__1;

			[Nullable(0)]
			private string <>s__2;

			[Nullable(new byte[] { 0, 1 })]
			private TaskAwaiter<string> <>u__1;
		}
	}
}

#endif