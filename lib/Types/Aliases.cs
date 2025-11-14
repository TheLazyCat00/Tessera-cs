namespace Tessera.Types;

public struct Pixel{
	public int Value;
	public Pixel(int value) => Value = value;

	public static implicit operator int(Pixel p) => p.Value;
	public static implicit operator Pixel(int v) => new Pixel(v);
}

public struct Cell{
	public int Value;
	public Cell(int value) => Value = value;

	public static implicit operator int(Cell p) => p.Value;
	public static implicit operator Cell(int v) => new Cell(v);
}
