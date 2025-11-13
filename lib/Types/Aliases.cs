namespace Tessera.Types;

public struct CellPosition{
	public Index2 Value;
	public int X => Value.X;
	public int Y => Value.Y;

	public CellPosition(Index2 value) { Value = value; }
}

public struct PixelPosition{
	public Index2 Value;
	public int X => Value.X;
	public int Y => Value.Y;

	public PixelPosition(Index2 value) { Value = value; }
}
