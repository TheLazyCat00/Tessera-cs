namespace Tessera.Core;

public class Grid {
	List<Types.Widget> widgets;
	List<int> columnsWidth;
	List<int> rowsHeight;
	Types.Color bgColor;

	public Types.RenderCallback Render = (int width, int height) => {
		var canvas = new Surfaces.RgbaSurface(width, height);
		return null;
	};

	public Grid(List<int> columnsWidth, List<int> rowsHeight, Types.Color bgColor){
		widgets = new List<Types.Widget>();

		this.columnsWidth = columnsWidth;
		this.rowsHeight = rowsHeight;
		this.bgColor = bgColor;
	}

	public void Register(Types.Widget widget) {
		widgets.Add(widget);
	}
}
