namespace Tessera.Types;

public struct Dimension2<T>{
	public T Width { get; }
	public T Height { get; }

	public Dimension2(T width, T height){
		Width = width;
		Height = height;
	}

	public static implicit operator Dimension2<T>(Vector2<T> value) => new (value.X, value.Y);
}
