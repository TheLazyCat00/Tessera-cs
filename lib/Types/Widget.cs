namespace Tessera.Types;

public struct Widget{
	public CellPosition TopLeft;
	public CellPosition BottomRight;
	public List<Viewport> Viewports;
	public int CurrentViewport;
}
