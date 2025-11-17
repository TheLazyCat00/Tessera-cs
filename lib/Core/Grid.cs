namespace Tessera.Core;

public class Grid {
	List<Types.Widget> widgets;
	List<int> columnsWidth;
	List<int> rowsHeight;
	Types.Color bgColor;
	Types.RenderCallback RenderFunc;

	public Grid(List<int> columnsWidth, List<int> rowsHeight, Types.Color bgColor){
		widgets = new List<Types.Widget>();

		this.columnsWidth = columnsWidth;
		this.rowsHeight = rowsHeight;
		this.bgColor = bgColor;
		this.RenderFunc = Render;
	}

	public Interfaces.PixelSurface Render(Types.Dimension2<Types.Pixel> dimensions) {
		var canvas = new Surfaces.RgbaSurface(dimensions, new Types.Color(0, 0, 0, 255));
		foreach (var widget in widgets){
			RenderWidget(new(widget, dimensions, canvas));
		}
		return null;
	}

	record RenderContext(Types.Widget widget, Types.Dimension2<Types.Pixel> dimensions, Surfaces.RgbaSurface canvas);

	void RenderWidget(RenderContext renderContext){
	}

	Types.Dimension2<Types.Pixel> getWidgetDimension(RenderContext renderContext){
		var topLeft = getTopLeftPos(renderContext);
		var bottomRight = getBottomRightPos(renderContext);

		return bottomRight - topLeft;
	}

	Types.Vector2<Types.Pixel> getBottomRightPos(RenderContext renderContext){
		Types.Cell cellsAfterX = columnsWidth.GetRange(0, renderContext.widget.BottomRight.X).Sum();
		Types.Cell cellsAfterY = rowsHeight.GetRange(0, renderContext.widget.BottomRight.Y).Sum();

		Types.Pixel pixelAfterX = renderContext.dimensions.Width / columnsWidth.Sum() * cellsAfterX;
		Types.Pixel pixelAfterY = renderContext.dimensions.Height / rowsHeight.Sum() * cellsAfterY;

		return new(pixelAfterX, pixelAfterY);
	}

	Types.Vector2<Types.Pixel> getTopLeftPos(RenderContext renderContext){
		Types.Cell cellsBeforeX = columnsWidth.GetRange(0, renderContext.widget.TopLeft.X).Sum();
		Types.Cell cellsBeforeY = rowsHeight.GetRange(0, renderContext.widget.TopLeft.Y).Sum();

		cellsBeforeX -= columnsWidth[renderContext.widget.TopLeft.X];
		cellsBeforeY -= rowsHeight[renderContext.widget.TopLeft.Y];

		Types.Pixel pixelBeforeX = renderContext.dimensions.Width / columnsWidth.Sum() * cellsBeforeX;
		Types.Pixel pixelBeforeY = renderContext.dimensions.Height / rowsHeight.Sum() * cellsBeforeY;

		return new(pixelBeforeX, pixelBeforeY);
	}

	public void Register(Types.Widget widget) {
		widgets.Add(widget);
	}
}
