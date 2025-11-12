namespace Tessera.Core;

public class Grid {
	List<Types.Widget> widgets;
	List<int> columnsWidth;
	List<int> rowsHeight;
	public Types.RenderCallback Render = (int width, int height) => {
		// TODO: Replace with your actual implementation
		return null;
	};

	public Grid(List<int> columnsWidth, List<int> rowsHeight){
		widgets = new List<Types.Widget>();

		this.columnsWidth = columnsWidth;
		this.rowsHeight = rowsHeight;
	}

	public void Register(Types.Widget widget) {
		// TODO: Add widget to internal collection
	}
}
