using Raylib_cs;
using static Raylib_cs.Raylib;

InitWindow(800, 450, "HI");

while (!WindowShouldClose())
{
	BeginDrawing();
		ClearBackground(Color.Black);
	EndDrawing();
}

CloseWindow();
