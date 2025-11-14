namespace Tessera.Types;

public record Viewport(
	RenderCallback RenderFunc,
	Offset<Pixel> Margin
);
