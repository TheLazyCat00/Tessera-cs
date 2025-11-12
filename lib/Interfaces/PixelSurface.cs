namespace Tessera.Interfaces;

public interface PixelSurface{
	int Width { get; }
	int Height { get; }
	ReadOnlyMemory<byte> Pixels { get; }
}
