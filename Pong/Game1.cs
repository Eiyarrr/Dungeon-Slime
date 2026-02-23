using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace Pong;

public class Game1 : Core
{
    // MonoGame logo texture
    private Texture2D _logo;

    public Game1() : base("Pong", 1920, 1080, false)
    {

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        _logo = Content.Load<Texture2D>("images/logo");
        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        // TODO: Add your drawing code here

        // Begin sprite batch to prepare for rendering
        SpriteBatch.Begin();

        // Draw logo texture
        SpriteBatch.Draw(_logo, Vector2.Zero, Color.White);

        // End sprite batch when finished rendering (ALWAYS DO)
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}