namespace Tessera.Surfaces;

public class RgbaSurface : Interfaces.PixelSurface {
	private readonly byte[] _pixels;

	public int Width { get; }
	public int Height { get; }
	public ReadOnlyMemory<byte> Pixels => _pixels;

	public RgbaSurface(int width, int height) {
		Width = width;
		Height = height;
		_pixels = new byte[width * height * 4];
	}

	public void SetPixel(int x, int y, byte r, byte g, byte b, byte a = 255) {
		int i = (y * Width + x) * 4;
		_pixels[i + 0] = r;
		_pixels[i + 1] = g;
		_pixels[i + 2] = b;
		_pixels[i + 3] = a;
	}

	public (byte r, byte g, byte b, byte a) GetPixel(int x, int y) {
		int i = (y * Width + x) * 4;
		return (_pixels[i], _pixels[i + 1], _pixels[i + 2], _pixels[i + 3]);
	}

	public void BlitTo(byte[] target, int targetWidth, int targetHeight, int x, int y) {
		for (int row = 0; row < Height; row++) {
			int srcIndex = row * Width * 4;
			int dstIndex = ((y + row) * targetWidth + x) * 4;
			Buffer.BlockCopy(_pixels, srcIndex, target, dstIndex, Width * 4);
		}
	}
}
