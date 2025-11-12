namespace Tessera.Surfaces;

public class RgbaSurface : Interfaces.PixelSurface {
	private readonly byte[] _pixels;

	public int Width { get; }
	public int Height { get; }
	public ReadOnlyMemory<byte> Pixels => _pixels;

	public RgbaSurface(int width, int height, Types.Color color) {
		Width = width;
		Height = height;
		_pixels = new byte[width * height * 4];

		for (int i = 0; i < _pixels.Length; i += 4) {
			_pixels[i + 0] = color.r;
			_pixels[i + 1] = color.g;
			_pixels[i + 2] = color.b;
			_pixels[i + 3] = color.a;
		}
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

	public void Blit(Types.Index2 topLeft, Types.Index2 bottomRight, byte[] src) {
		int rectWidth = bottomRight.X - topLeft.X;
		int rectHeight = bottomRight.Y - topLeft.Y;
		int rowSize = rectWidth * 4;

		for (int row = 0; row < rectHeight; row++) {
			int dstIndex = ((topLeft.Y + row) * Width + topLeft.X) * 4;
			int srcIndex = row * rowSize;
			Buffer.BlockCopy(src, srcIndex, _pixels, dstIndex, rowSize);
		}
	}
}
