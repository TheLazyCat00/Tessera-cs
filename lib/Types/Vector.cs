namespace Tessera.Types;

public struct Vector2<T>{
	public T X { get; }
	public T Y { get; }

	public Vector2(T x, T y)
	{
		X = x;
		Y = y;
	}

	public static Vector2<T> operator -(Vector2<T> a, Vector2<T> b)
		=> new((dynamic)a.X - b.X, (dynamic)a.Y - b.Y);

	public static implicit operator Vector2<T>(Dimension2<T> value) => new (value.Width, value.Height);
}

