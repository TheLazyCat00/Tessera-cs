namespace Tessera;

public interface IPixelSurface{
	int Width { get; }
	int Height { get; }
	ReadOnlyMemory<byte> Pixels { get; }

	void BlitTo(byte[] target, int targetWidth, int targetHeight, int x, int y);
}

public delegate IPixelSurface RenderCallback(int width, int height);

class Grid{
	struct Item = {
		RenderCallback renderFunction;
	}

	public RenderCallback Render = (int width, int height) => {
		// TODO: Replace with your actual implementation
		return null;
	};

	public Grid(){

	}
}
