namespace Tessera.Types;

public record Widget(
	Vector2<Cell> TopLeft,
	Vector2<Cell> BottomRight,
	List<Viewport> Viewports,
	int CurrentViewport
);
