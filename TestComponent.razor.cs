using System;
using Microsoft.AspNetCore.Components;

namespace BlazorGenericsBugLib
{
		// Any nullable constraints (class, Enum, MyType...) won't compile if the #nullable setting is [enable]
		// It compiles fine if you alter the constraints to 'struct' or remove the #nullable switch
#nullable enable
		public partial class TestComponent<T> : TestComponentBase<T>
				where T : class  // Here... 
		{
				public int TestVal { get; set; }
		}

		public class TestComponentBase<T> : ComponentBase
				where T : class // And here....
		{
				public int BaseVal { get; set; }
		}
}
