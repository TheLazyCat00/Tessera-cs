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
			RenderWidget(widget, dimensions, canvas);
		}
		return null;
	}

	public void RenderWidget(Types.Widget widget, Types.Dimension2<Types.Pixel> dimensions, Surfaces.RgbaSurface canvas){
		dimensions.Width/columnsWidth.Sum()
	}

	public void Register(Types.Widget widget) {
		widgets.Add(widget);
	}
}
