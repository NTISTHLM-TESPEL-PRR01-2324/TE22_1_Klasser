// using Raylib_cs;

// Raylib.InitWindow(800, 600, "Title");
// Raylib.SetTargetFPS(60);

// Defender hero = new Defender();

// while (!Raylib.WindowShouldClose())
// {
//   Raylib.BeginDrawing();
//   Raylib.ClearBackground(Color.Beige);

//   hero.Update();

//   hero.Draw();

//   Raylib.EndDrawing();
// }



Fighter hero = new Fighter();
Fighter enemy = new Fighter();

hero.name = "Micke";
enemy.name = "Martin";

hero.Attack(enemy);

// hero.hp = 0;
hero.IsDead();


// Console.WriteLine(hero.name);

Console.ReadLine();