namespace Tessera.Interfaces;

public interface PixelSurface{
	int Width { get; }
	int Height { get; }
	ReadOnlyMemory<byte> Pixels { get; }

	void BlitTo(byte[] target, int targetWidth, int targetHeight, int x, int y);
}
