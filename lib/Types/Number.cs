using System.Numerics;

namespace Tessera.Types;

public abstract record Number<T>(T Value) where T : INumber<T>{
	public static Number<T> operator +(Number<T> a, Number<T> b)
		=> a with { Value = a.Value + b.Value };

	public static Number<T> operator -(Number<T> a, Number<T> b)
		=> a with { Value = a.Value - b.Value };

	public static Number<T> operator *(Number<T> a, Number<T> b)
		=> a with { Value = a.Value * b.Value };

	public static Number<T> operator /(Number<T> a, Number<T> b)
		=> a with { Value = a.Value / b.Value };

	// Implicit conversion to the underlying type
	public static implicit operator T(Number<T> n) => n.Value;

	private static Number<T> Create<U>(U value) where U : INumber<U>
		=> throw new NotImplementedException("This will be handled by derived record classes.");
}
