namespace Tessera.Types;

public record Pixel(int Value) : Number<int>(Value){
	public static implicit operator int(Pixel pixel) => pixel.Value;
}
public record Cell(int Value) : Number<int>(Value){
	public static implicit operator int(Cell cell) => cell.Value;
}
public record FlexWeight(int Value) : Number<int>(Value){
	public static implicit operator int(FlexWeight flexWeight) => flexWeight.Value;
}
